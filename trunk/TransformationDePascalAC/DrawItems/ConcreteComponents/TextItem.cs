using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using DrawItems.AbstractComponents;

namespace DrawItems.ConcreteComponents
{
    public class TextItem : DrawItem
    {
        

        private string id;
        private string text;
        private int width;

        public TextItem(string id, string text, int width)
        {
            this.id = id;
            this.text = text;
            this.width = width;
            
        }

        public string writeCode()
        {
            StringBuilder code = new StringBuilder();
            string newLine = Environment.NewLine;

            code.AppendLine("System.Windows.Forms.TextBox {Name};");
            code.AppendLine("{Name} = new System.Windows.Forms.TextBox();");
            code.AppendLine();
            code.AppendLine("//");
            code.AppendLine("// init base properties {Name}");
            code.AppendLine("//");
            code.AppendLine("// ");
            code.AppendLine("{Name}.Name = \"{Name}\";");
            code.AppendLine("{Name}.Text = \"{Text}\";");
            code.AppendLine("{Name}.Size = new System.Drawing.Size({size.width}, 20);");
            code.AppendLine();

            
            code.Replace(@"{Name}", id);
            code.Replace(@"{Text}", text);
            code.Replace(@"{size.width}", width.ToString());


            return code.ToString();
        }


        public string getItemName()
        {
            return id;
        }

    }

}
