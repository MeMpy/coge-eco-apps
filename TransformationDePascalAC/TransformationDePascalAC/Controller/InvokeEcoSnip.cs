/*
 * Created by SharpDevelop.
 * User: eroreng
 * Date: 10/09/2013
 * Time: 16:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Diagnostics;
using System.IO;

namespace TransformationDePascalAC.Controller
{
	/// <summary>
	/// Description of InvokeEcoSnip.
	/// </summary>
	public class InvokeEcoSnipController
	{
		private static readonly string executeDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.
    	                                                                            GetExecutingAssembly().Location);
        private static readonly string ecoSnip = Path.Combine("EcoSnip", "EcoSnip.exe");
        
        ProcessStartInfo startInfo;

        #region Singleton
        
        private static InvokeEcoSnipController _instance;
        
        public static InvokeEcoSnipController Instance 
        {
        	get 
        	{
        		if(_instance == null)
        			_instance = new InvokeEcoSnipController();
        		
        		return _instance;
        		
        	}
        }
        
		private InvokeEcoSnipController()
		{
			 // Use ProcessStartInfo class
            startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(executeDir, ecoSnip);
            
		}
		
		#endregion
		
		
		public object OpenEcoSnip()
        {            
            startInfo.UseShellExecute = false;

                        
            // Start the process with the info we specified.
            // Call WaitForExit and then the using statement will close.
            using (Process exeProcess = Process.Start(startInfo))
            {
                
                exeProcess.WaitForExit();


            }

            return null;

        }
	}
}
