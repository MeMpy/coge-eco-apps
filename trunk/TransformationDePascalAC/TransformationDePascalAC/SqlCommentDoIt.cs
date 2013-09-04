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
using System.Runtime.Remoting.Messaging;
using System;
using System.Data;

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
		
		private string name, pass, source;
		
		public SqlCommentDoIt(string pkgFilePath, string name, string pass, string source)
		{
			string xml = ProceduresInvoker.InvokeCoGe(pkgFilePath).ToString();
			procedures = ProceduresBuilder.BuildProceduresFromXml(xml);
			this.name = name;
			this.pass = pass;
			this.source = source;
		}
		
		private string doIt()
		{
			
			string result = null;
			
//			using (OracleConnection con = new OracleConnection())
//			{
//				//using connection string attributes to connect to Oracle Database
//				con.ConnectionString = "User Id="+"name"+";Password="+pass+";Data Source="+source;
//				con.Open();
//				Console.WriteLine("Connected to Oracle" + con.ServerVersion);
//				
//				OracleCommand command = con.CreateCommand();
//				
//				result = "-- Params             Description\r\n";
//				
//				Procedure p = procedures[0];
//				foreach (Parameter param in p.GetParameters()) {
//					
//					
//					if (!param.Type.ToUpper().EndsWith("TYPE"))
//					{
//						continue;
//					}
//					
//					String[] paramSplitted = param.Type.Split(new char[] { '.', '%' });
//					String[] paramNameSplitted = paramSplitted[0].Split(new char[] { ' ' });
//					
//					String paramName = paramNameSplitted[0];
//					String table = paramNameSplitted[paramNameSplitted.Length - 1];
//					
//					string sql = "select table_name, column_name, comments from user_col_comments where table_name = '" + table + "' and column_name = '" + paramSplitted[1] + "'";
//					command.CommandText = sql;
//					
//					OracleDataReader reader = command.ExecuteReader();
//					while (reader.Read())
//					{
//						string myField = reader["comments"] as string;
//						
//						if (myField != null)
//						{
//							
//							string space = "                   ";
//							
//							space = space.Substring(paramName.Length);
//							
//							Console.WriteLine("\t-- %param " + paramName + space + myField);
//							result.AppendText("\t-- %param " + paramName + space + myField + "\r\n");
//						}
//						else
//						{
//							Console.WriteLine("\t-- %param " + paramName);
//							result.AppendText("\t-- %param " + paramName + "\r\n");
//						}
//					}
//				}
//				
//				// Close and Dispose OracleConnection object
//				con.Close();
//				con.Dispose();
//				Console.WriteLine("Disconnected");
//				
//				
//			}
			return result;
			
		}
	}
}
