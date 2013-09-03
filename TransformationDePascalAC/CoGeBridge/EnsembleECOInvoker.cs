using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CoGeBridge
{
    public class EnsembleECOInvoker: CoGeInvoker
    {
        private static readonly string outPutFolder = Path.Combine(Directory.GetCurrentDirectory(), "generatedFile");

        private const string templateECO = "EnsembleECO";

        private bool saveToFile;

        private static EnsembleECOInvoker invoker = new EnsembleECOInvoker();


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
        public static object InvokeCoGe(string filePath, string serviceName, bool saveToFile)
        {
            invoker.SetTemplate(EnsembleECOInvoker.templateECO);
            invoker.SetReaderArguments(@filePath);
            invoker.SetProcessArgument(serviceName);
            invoker.SetSaveToFile(saveToFile);
            return invoker.ExecuteCoGe();
        }


    }
}
