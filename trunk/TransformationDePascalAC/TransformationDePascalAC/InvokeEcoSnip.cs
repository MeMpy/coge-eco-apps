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

namespace TransformationDePascalAC
{
	/// <summary>
	/// Description of InvokeEcoSnip.
	/// </summary>
	public class InvokeEcoSnip
	{
		private static readonly string executeDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.
    	                                                                            GetExecutingAssembly().Location);
        private static readonly string ecoSnip = Path.Combine("EcoSnip", "EcoSnip.exe");
        
        ProcessStartInfo startInfo;

        
		public InvokeEcoSnip()
		{
			 // Use ProcessStartInfo class
            startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(executeDir, ecoSnip);
            
		}
		
		
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
