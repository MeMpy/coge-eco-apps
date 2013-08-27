using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace DrawItems
{
    /// <summary>
    /// Incapsula l'item Label e fornisce il metodo per scrivere il codice 
    /// che lo disegna in una windows form. L' id e il text di questo item 
    /// hanno lo stesso valore.
    /// </summary>
    public class LabelItem: DrawItem
    {
       

        private string id;

        public LabelItem(string id)
        {
            this.id = id;

        }

        public string writeCode()
        {
            StringBuilder code = new StringBuilder();
            string newLine = Environment.NewLine;
            code.AppendLine("System.Windows.Forms.Label {LabelId};");
            code.AppendLine("{LabelId} = new System.Windows.Forms.Label();");
            code.AppendLine();
            code.AppendLine("//");
            code.AppendLine("// init base properties {LabelId}");
            code.AppendLine("//");
            code.AppendLine("// ");
            code.AppendLine("{LabelId}.Name = \"{LabelId}\";");
            code.AppendLine("{LabelId}.Text = \"{LabelId}\";");
            code.AppendLine("{LabelId}.AutoSize = true;");
            code.AppendLine();

            code.Replace(@"{LabelId}", this.id);
           
            return code.ToString();
        }

        public string getItemName()
        {
            return id;
        }
    }


    
}
