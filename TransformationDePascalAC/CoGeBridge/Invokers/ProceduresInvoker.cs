using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoGeBridge.Invokers
{
    public class ProceduresInvoker: CoGeInvoker
    {
        private static ProceduresInvoker invoker = new ProceduresInvoker();        

        private const string templateProcedures = "Procedures";

        public static object InvokeCoGe(string filePath)
        {
            invoker.SetTemplate(templateProcedures);
            invoker.SetReaderArguments(@filePath);

            return invoker.ExecuteCoGe();
        }
    }
}
