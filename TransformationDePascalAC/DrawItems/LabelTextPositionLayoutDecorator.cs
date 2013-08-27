using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrawItems.Decorator
{
    /// <summary>
    /// Decora la posizione della coppia all'interno del tableLayout in maniera tale da
    /// posizionare la label sotto ( sopra, a destra, a sinistra) della textBox.
    /// 
    /// NB: I DrawItem nell'array drawitems sono memorizzati in quest'ordine: layout, label, textbox
    /// </summary>
    public class LabelTextPositionDecorator : DecoratedItem
    {
        public enum RelativePosition { labelUp, labelDown, labelLeft, labelRight };

        private RelativePosition position;

        private bool drawLayout;

        /// <summary>
        /// Costruisce un LabelTextPositionDecorator che posiziona in base al criterio passato
        /// la label e la textbox.
        /// NB: I DrawItem nell'array drawitems sono memorizzati in quest'ordine: layout, label, textbox
        /// </summary>
        /// <param name="layout"></param>
        /// <param name="labelItem"></param>
        /// <param name="textItem"></param>
        /// <param name="pos"></param>
        /// <param name="drawLayout"></param>
        public LabelTextPositionDecorator(DrawItem layout, DrawItem labelItem, DrawItem textItem, RelativePosition pos, bool drawLayout )
        {
            this.drawLayout = drawLayout;
            this.setItem(layout, labelItem, textItem);
            this.position = pos;
        }


        public override string writeCode()
        {
            DrawItem[] drawitems = this.getItems();
            StringBuilder code = new StringBuilder();
            if (drawLayout == true)
            {
                code.AppendLine(drawitems[0].writeCode());
            }

            code.AppendLine(drawitems[1].writeCode());
            code.AppendLine(drawitems[2].writeCode());
            string codeToAppend;
            switch (position)
            {
                case RelativePosition.labelUp:
                    codeToAppend = generateCodePosition(1, 2, drawitems[1], drawitems[2]);
                    code.AppendLine(codeToAppend);
                    break;

                case RelativePosition.labelDown:
                    codeToAppend = generateCodePosition(1, 2, drawitems[2], drawitems[1]);
                    code.AppendLine(codeToAppend);
                    break;

                case RelativePosition.labelLeft:
                    codeToAppend = generateCodePositionLeft();
                    code.AppendLine(codeToAppend);
                    break;

                case RelativePosition.labelRight:
                    codeToAppend = generateCodePositionRight();
                    code.AppendLine(codeToAppend);
                    break;

                default:
                    break;

            }

            return code.ToString();
        }

        

        private string generateCodePosition(int numCol, int numRow, DrawItem firstItem, DrawItem secondItem )
        {
            StringBuilder code = new StringBuilder();

            code.AppendLine("TableLayoutPanel {firstItem}Cell = new TableLayoutPanel();");
            code.AppendLine("{firstItem}Cell.AutoSize = true;");
            code.AppendLine("{firstItem}Cell.ColumnCount = {numCol};");
            code.AppendLine("{firstItem}Cell.RowCount = {numRow};");
            code.AppendLine("{firstItem}Cell.Controls.Add({firstItem});");
            code.AppendLine("{firstItem}Cell.Controls.Add({secondItem});");
            code.AppendLine("layout.Controls.Add({firstItem}Cell);");

            code.AppendLine("//Add {layoutName} to form");
            code.AppendLine("Controls.Add({layoutName});");
            code.AppendLine("{layoutName}.ResumeLayout(false);");
            code.AppendLine("{layoutName}.PerformLayout();");

            code.AppendLine("//Form");
            code.AppendLine("this.ResumeLayout(false);");
            code.AppendLine("this.PerformLayout();");

            DrawItem[] drawitems = this.getItems();
            code.Replace(@"{layoutName}", drawitems[0].getItemName());
            code.Replace(@"{firstItem}", firstItem.getItemName());
            code.Replace(@"{secondItem}", secondItem.getItemName());
            code.Replace(@"{numCol}", numCol.ToString());
            code.Replace(@"{numRow}", numRow.ToString());


            return code.ToString();
        }

        

        private string generateCodePositionRight()
        {
            StringBuilder code = new StringBuilder();

            code.AppendLine("{layoutName}.Controls.Add({textBoxName}, -1, -1);");
            code.AppendLine("{layoutName}.Controls.Add({labelName}, -1, -1);");

            code.AppendLine("//Add {layoutName} to form");
            code.AppendLine("Controls.Add({layoutName});");
            code.AppendLine("{layoutName}.ResumeLayout(false);");
            code.AppendLine("{layoutName}.PerformLayout();");

            code.AppendLine("//Form");
            code.AppendLine("this.ResumeLayout(false);");
            code.AppendLine("this.PerformLayout();");

            DrawItem[] drawitems = this.getItems();
            code.Replace(@"{layoutName}", drawitems[0].getItemName());
            code.Replace(@"{labelName}", drawitems[1].getItemName());
            code.Replace(@"{textBoxName}", drawitems[2].getItemName());


            return code.ToString();
        }




        private string generateCodePositionLeft()
        {
            StringBuilder code = new StringBuilder();
            
            code.AppendLine("{layoutName}.Controls.Add({labelName}, -1, -1);");
            code.AppendLine("{layoutName}.Controls.Add({textBoxName}, -1, -1);");
            

            code.AppendLine("//Add {layoutName} to form");
            code.AppendLine("Controls.Add({layoutName});");
            code.AppendLine("{layoutName}.ResumeLayout(false);");
            code.AppendLine("{layoutName}.PerformLayout();");

            code.AppendLine("//Form");
            code.AppendLine("this.ResumeLayout(false);");
            code.AppendLine("this.PerformLayout();");

            DrawItem[] drawitems = this.getItems();
            code.Replace(@"{layoutName}", drawitems[0].getItemName());
            code.Replace(@"{labelName}", drawitems[1].getItemName());
            code.Replace(@"{textBoxName}", drawitems[2].getItemName());


            return code.ToString();
        }

    }
}
