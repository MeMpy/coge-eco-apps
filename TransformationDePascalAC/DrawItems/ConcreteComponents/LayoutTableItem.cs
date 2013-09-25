using DrawItems.AbstractComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawItems.ConcreteComponents
{
    public class LayoutTableItem:DrawItem
    {
        private string name;
        
        private int numColonne;
        private int numRighe;
        private float x;
        private float y;

        #region DrawItem Membri di

        public LayoutTableItem(string name, int numColonne, int numRighe, float x, float y)
        {
            this.name = name;
            this.numColonne = numColonne;
            this.numRighe = numRighe;
            this.x = x;
            this.y = y;
        }

        public string writeCode()
        {
            StringBuilder code = new StringBuilder();
            string newLine = Environment.NewLine;
            code.AppendLine("//");
            code.AppendLine("// {Name} tableLayoutPanel");
            code.AppendLine("//");
            code.AppendLine("System.Windows.Forms.TableLayoutPanel {Name} = new System.Windows.Forms.TableLayoutPanel();");
            code.AppendLine("// ");
            code.AppendLine("// {Name} init base properties");
            code.AppendLine("// ");
            code.AppendLine("{Name}.AutoSize = true;");
            code.AppendLine("{Name}.ColumnCount = "+"{numColonne}"+";");
            code.AppendLine("{Name}.RowCount = "+"{numRighe}"+";");
            code.AppendLine("{Name}.Location = new System.Drawing.Point(" + "{point.x}" + ", " + "{point.y}" + ");");
            code.AppendLine("{Name}.Name = "+"\"{Name}\""+";");

            code.Replace(@"{Name}", this.name);
            code.Replace(@"{point.x}", this.x.ToString());
            code.Replace(@"{point.y}", this.y.ToString());
            code.Replace(@"{numColonne}", this.numColonne.ToString());
            code.Replace(@"{numRighe}", this.numRighe.ToString());

            return code.ToString();
        }

        
        public string getItemName()
        {
            return name;
        }

        #endregion
    }
}
