using CoGeBridge.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


namespace CoGeBridge.Invokers
{
    public class EnsembleECOInvoker: CoGeInvoker
    {
        private static readonly string outPutFolder = Path.Combine(Directory.GetCurrentDirectory(), "generatedFile");

        private const string templateECO = "EnsembleECO";

        private bool saveToFile;

        private static EnsembleECOInvoker invoker = new EnsembleECOInvoker();

        
        protected override void setSpecificsProcessArguments(object args)
		{			
        	List<Procedure> selectedProcs = args as List<Procedure>;
        	if(selectedProcs== null)
        		throw new Exception("Args type error expected List<Procedure>");
        	
            if(selectedProcs.Count == 0)
            	throw new Exception("No procedure selected");
            
            foreach (Procedure proc in selectedProcs)
            {
            	startInfo.Arguments += string.Format(" +proc {0} {1}",  proc.Name, proc.CollectParam);
            }
		}

        protected override object ProcessOutput(StreamReader streamReader)
        {

            Directory.CreateDirectory(outPutFolder);
            string outPutFile = Path.Combine(outPutFolder, templateECO + ".cs");
            if (saveToFile)
            {
                CopyStreamToFile(outPutFile, streamReader);
                return @outPutFile;
            }
            else
            {
                return streamReader.ReadToEnd();
            }


        }

        private void CopyStreamToFile(string outPutFile, StreamReader streamReader)
        {
            FileStream f = null;

            
            try
            {
                f = File.Open(outPutFile, FileMode.Create, FileAccess.Write);
                using (StreamWriter writer = new StreamWriter(f))
                {
                    char[] buffer = new char[8192];
                    int length;
                    while ((length = streamReader.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        writer.Write(buffer, 0, length);
                    }
                }

            }
            finally
            {
                if (f != null)
                    f.Close();
            }
        }

        public void SetSaveToFile(bool value)
        {
            this.saveToFile = value;
        }

        //Entry Point
        public static object InvokeCoGe(string filePath, string serviceName, List<Procedure> selectedProcs, bool saveToFile)
        {
            invoker.SetTemplate(EnsembleECOInvoker.templateECO);
            invoker.SetReaderArguments(@filePath);
            invoker.SetProcessArguments(serviceName);
            invoker.setSpecificsProcessArguments(selectedProcs);
            invoker.SetSaveToFile(saveToFile);
            return invoker.ExecuteCoGe();
        }
        
		


    }
}
