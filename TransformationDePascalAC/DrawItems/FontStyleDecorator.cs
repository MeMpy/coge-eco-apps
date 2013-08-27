using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DrawItems.Decorator
{
    public class FontStyleDecorator: DecoratedItem
    {

        private Color color;
        private string font;
        private FontStyle style;

        public FontStyleDecorator(DrawItem item, Color color, string font, FontStyle style)
        {
            setItem(item);
            this.color = color;
            this.font = font;
            this.style = style;
            
        }

        public FontStyleDecorator(DrawItem item, int color, string font, FontStyle style)
        {
            setItem(item);
            this.color = Color.FromArgb(color);
            this.font = font;
            this.style = style;
            

        }

        public override string writeCode()
        {
            StringBuilder code = new StringBuilder();
            code.AppendLine(base.writeCode());
            code.AppendLine("//");
			code.AppendLine("// {ItemName} font style");
			code.AppendLine("//");
            code.AppendLine("{ItemName}.Font = new System.Drawing.Font(\"{Font}\", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.{Style} | System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));");
            code.AppendLine("{ItemName}.ForeColor =  System.Drawing.Color.FromArgb({Color});");
                
            code.Replace(@"{ItemName}", base.getItemName());
            code.Replace(@"{Font}", this.font.ToString());
            code.Replace(@"{Style}", this.style.ToString());
            code.Replace(@"{Color}", this.color.ToArgb().ToString());
        
            return code.ToString();
        }

    }
}
