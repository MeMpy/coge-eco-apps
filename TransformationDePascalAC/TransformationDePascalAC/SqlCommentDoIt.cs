/*
 * Created by SharpDevelop.
 * User: eroreng
 * Date: 04/09/2013
 * Time: 16:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Linq;

using CoGeBridge;
using EnsembleCoGe;

namespace TransformationDePascalAC
{
	/// <summary>
	/// Description of SqlCommentDoIt.
	/// </summary>
	public class SqlCommentDoIt
	{
		private  List<Procedure> procedures;
		
		private string pkgFilePath, name, pass, source;
		
		private bool saveToFile;
		
		public SqlCommentDoIt(string pkgFilePath, string name, string pass, string source, bool saveToFile)
		{
			string xml = ProceduresInvoker.InvokeCoGe(pkgFilePath).ToString();
			procedures = ProceduresBuilder.BuildProceduresFromXml(xml);
			this.pkgFilePath = pkgFilePath;
			this.name = name;
			this.pass = pass;
			this.source = source;
			this.saveToFile = saveToFile;
		}
		
		public object ExecuteGeneration()
		{
			
			string result = doIt();
			if(!saveToFile)
				return result;
			//Scrittura dei commenti nel file
			return printCommentIntoFile();
		}
		
		private bool printCommentIntoFile()
		{
			StringBuilder pkgWithComment = new StringBuilder();
			
			IOrderedEnumerable<Procedure> orderedProcs = procedures.OrderBy( (p) => { return p.LineIndex;});
			
			int procCount = 0;
			int lineCount = 0;
			
			try
			{
				using (StreamReader f = new StreamReader(pkgFilePath,  Encoding.GetEncoding("iso-8859-1")))
				{
					string line = null;
					Procedure p = orderedProcs.ElementAt(procCount);
					
					while((line = f.ReadLine())!=null)
					{
						if(lineCount == p.LineIndex)
						{
							pkgWithComment.AppendLine(p.Comments);
							pkgWithComment.Append(line);							
							procCount++;
							//Se ci sono ancora procedure vai avanti
							if(procCount< procedures.Count)
								p= orderedProcs.ElementAt(procCount);
							//Altrimenti devi scrivere il resto del file uguale
							//Questo avviene perchè lineCount supera LineIndex
							
							
						}else
						{
							pkgWithComment.AppendLine(line);
							
						}
						
						lineCount++;
						
					}
					
				}
				
				StreamWriter sf = new StreamWriter(pkgFilePath);
				sf.Write(pkgWithComment);
				sf.Close();
				
				return true;
				
			}catch(Exception ){
				
				return false;
			}
			
			
			
			
		}
		
		//TODO Testare su VM
		
		private string doIt()
		{
			
			StringBuilder result = null;
			
			using (OracleConnection con = new OracleConnection())
			{
				//using connection string attributes to connect to Oracle Database
				con.ConnectionString = "User Id="+name+";Password="+pass+";Data Source="+source;
				con.Open();
				Console.WriteLine("Connected to Oracle" + con.ServerVersion);
				
				OracleCommand command = con.CreateCommand();
				
				result = new StringBuilder();
				result.AppendLine("-- Params             Description");
				
				StringBuilder singleComment = new StringBuilder();
				foreach (Procedure p in procedures) 
				{
					
					singleComment.AppendLine("\\**************************************\\");
					singleComment.AppendLine("*          "+p.Name.ToUpper()+"         *");
					singleComment.AppendLine("\\**************************************\\");
					singleComment.Append(BuildParamsComments(command, p));
					p.Comments = singleComment.ToString();
					result.AppendLine(singleComment.ToString());
					singleComment.Clear();
				}
				
				
				
				// Close and Dispose OracleConnection object
				con.Close();
				con.Dispose();
				Console.WriteLine("Disconnected");
				
				
			}
			
			return result.ToString().TrimEnd(Environment.NewLine.ToCharArray());
			
		}
		
		private string BuildParamsComments(OracleCommand command, Procedure p)
		{
			StringBuilder result = new StringBuilder();
			
			foreach (Parameter param in p.GetParameters()) {
				if (!param.Type.ToUpper().EndsWith("TYPE")) {
					continue;
				}
				String[] paramSplitted = param.Type.Split(new char[] {
				                                          	'.',
				                                          	'%'
				                                          });
				String[] paramNameSplitted = paramSplitted[0].Split(new char[] { ' ' });
				String paramName = param.Name;
				String table = paramNameSplitted[paramNameSplitted.Length - 1];
				string sql = "select table_name, column_name, comments from user_col_comments where table_name = '" + table + "' and column_name = '" + paramSplitted[1] + "'";
				command.CommandText = sql;
				OracleDataReader reader = command.ExecuteReader();
				while (reader.Read()) {
					string myField = reader["comments"] as string;
					if (myField != null) {
						string space = "                   ";
						space = space.Substring(paramName.Length);
						Console.WriteLine("-- %param " + paramName + space + myField);
						result.AppendLine("-- %param " + paramName + space + myField);
					} else {
						Console.WriteLine("-- %param " + paramName);
						result.AppendLine("-- %param " + paramName);
					}
				}
			}
			
			return result.ToString();
		}
	}
}
