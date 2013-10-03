/*
 * Created by SharpDevelop.
 * User: eroreng
 * Date: 03/10/2013
 * Time: 17:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using CoGeBridge.Invokers;
using CoGeBridge.Model;

namespace TransformationDePascalAC.Controller
{
	/// <summary>
	/// Gestore della comunicazione tra EnsembleCodeGenerator Form e la libreria CoGeInvoker
	/// </summary>
	public class EnsembleCodeGeneratorController
	{
		#region Singleton
		
		private static EnsembleCodeGeneratorController _instance;
		
		private EnsembleCodeGeneratorController(){}
		
		public static EnsembleCodeGeneratorController Insance{
			get{
				if(_instance == null)
					_instance = new EnsembleCodeGeneratorController();
				
				return _instance;
			}
		}
		
		#endregion
		
		public List<Procedure> BuildProceduresFromScript(string scriptPath)
		{
			string xml = ProceduresInvoker.InvokeCoGe(scriptPath).ToString();
			List<Procedure> procs = ProceduresBuilder.BuildProceduresFromXml(xml);
			return procs;
		}
		
		public string DoGeneration(string scriptPath, string service, List<Procedure> selectedandCheckedProcs, bool saveOnFile){
			return EnsembleECOInvoker.InvokeCoGe(scriptPath, service, selectedandCheckedProcs, saveOnFile) as string;
		}
	}
}
