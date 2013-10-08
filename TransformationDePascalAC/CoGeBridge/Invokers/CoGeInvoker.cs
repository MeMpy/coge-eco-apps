using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace CoGeBridge.Invokers
{
    public class CoGeInvoker
    {

    	private static readonly string executeDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.
    	                                                                            GetExecutingAssembly().Location);
        private static readonly string cogeExeRelativ = Path.Combine("coge_dist", "CoGePy.exe");
        
        protected ProcessStartInfo startInfo;


        public CoGeInvoker()
        {
            // Use ProcessStartInfo class
            startInfo = new ProcessStartInfo();
            startInfo.FileName = Path.Combine(executeDir, cogeExeRelativ);
            

        }

        protected void SetTemplate(string template)
        {
            startInfo.Arguments = template;
        }


        protected void SetReaderArguments(string filePath, params string[] args)
        {
            startInfo.Arguments += " -r ";
            if(!string.IsNullOrEmpty(filePath))
                startInfo.Arguments += "\"" + @filePath + "\"";
            foreach (var arg in args)
            {
                startInfo.Arguments += arg + " ";
            }
        }

        protected void SetProcessArguments(params string[] args)
        {
            startInfo.Arguments += " -p ";
            foreach (var arg in args)
            {
                startInfo.Arguments += arg + " ";
            }
        }
        
        protected virtual void setSpecificsProcessArguments(object args)
        {
        	//Not implemented
        }
        
        /// <summary>
        /// Launch the CoGe application redirecting output.
        /// </summary>
        public object ExecuteCoGe()
        {

            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;

            startInfo.StandardOutputEncoding = new UTF8Encoding();

            object result = null;

            // Start the process with the info we specified.
            // Call WaitForExit and then the using statement will close.
            using (Process exeProcess = Process.Start(startInfo))
            {
                
            	
                result = this.ProcessOutput(exeProcess.StandardOutput);
                exeProcess.WaitForExit();
                
                this.ProcessError(exeProcess.StandardError);


            }

            return result;

        }

        protected virtual object ProcessOutput(StreamReader streamReader)
        {


            return streamReader.ReadToEnd();


        }
        
        protected virtual void ProcessError(StreamReader streamReader)
        {
        	string error = string.Empty;
        	error = streamReader.ReadToEnd();
        	if (!string.IsNullOrEmpty(error))
        	    throw new Exception(error);
        }

    }
}
