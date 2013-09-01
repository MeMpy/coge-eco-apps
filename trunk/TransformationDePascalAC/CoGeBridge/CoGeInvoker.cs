using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace CoGeBridge
{
    public class CoGeInvoker
    {

        private static readonly string cogeExe = Path.Combine(Directory.GetCurrentDirectory(), "coge_dist", "CoGe.exe");
        
        ProcessStartInfo startInfo;


        public CoGeInvoker()
        {
            // Use ProcessStartInfo class
            startInfo = new ProcessStartInfo();
            startInfo.FileName = cogeExe;
            

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

        protected void SetProcessArgument(params string[] args)
        {
            startInfo.Arguments += " -p ";
            foreach (var arg in args)
            {
                startInfo.Arguments += arg + " ";
            }
        }
        /// <summary>
        /// Launch the CoGe application redirecting output.
        /// </summary>
        public object ExecuteCoGe()
        {

            startInfo.RedirectStandardOutput = true;
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;           

            object result = null;

            // Start the process with the info we specified.
            // Call WaitForExit and then the using statement will close.
            using (Process exeProcess = Process.Start(startInfo))
            {
                result = this.ProcessOutput(exeProcess.StandardOutput);
                exeProcess.WaitForExit();


            }

            return result;

        }

        protected virtual object ProcessOutput(StreamReader streamReader)
        {


            return streamReader.ReadToEnd();


        }

    }
}
