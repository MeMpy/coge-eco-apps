using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrawItems;
using CodeTransformation;
using System.Drawing;
using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.Reflection;
using CodeTransformation.Model;
using DrawItems.Decorators;
using DrawItems.AbstractComponents;
using DrawItems.ConcreteComponents;

namespace TransformationDePascalAC.Controller
{
    public class DefBDD2FormController
    {
    	
    	#region Singleton
    	
    	private static DefBDD2FormController _instance;
    	
    	private DefBDD2FormController(){}
    	
    	public static DefBDD2FormController Instance{
    		get{
    			if(_instance == null)
    				_instance = new DefBDD2FormController();
				return _instance;    			
    		}
    	}
    	
    	#endregion
    	
    	
        #region Fields

        private string fileCSharpPath;

        public string FileCSharpPath
        {
            get { return fileCSharpPath; }
            set { fileCSharpPath = value; }
        }

        
        private int xPos;

        public int XPos
        {
            get { return xPos; }
            set { xPos = value; }
        }
        
        private int yPos;

        public int YPos
        {
            get { return yPos; }
            set { yPos = value; }
        }

        private int textBoxWidth;

        public int TextBoxWidth
        {
            get { return textBoxWidth; }
            set { textBoxWidth = value; }
        }

        private int numCol;

        public int NumCol
        {
            get { return numCol; }
            set { numCol = value; }
        }

        private string posRel;

        public string PosRel
        {
            get { return posRel; }
            set { posRel = value; }
        }

        private string fontName;

        public string FontName
        {
            get { return fontName; }
            set { fontName = value; }
        }

        private FontStyle fontStyle;

        public FontStyle FontStyle
        {
            get { return fontStyle; }
            set { fontStyle = value; }
        }

        private int fontColor;

        public int FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }
        }

        #endregion

        #region Private fields

        //Contiene il codice generato. Utile per creare un'anteprima
        private string codeGenerated;
        private const string layoutName = "layout";

        #endregion

        /// <summary>
        /// Genera il codice per creare i componenti grafici per visualizzare i campi contenuti
        /// nel file C# passato in input.
        /// Visualizza una coppia: 
        /// Label - TextBox
        /// </summary>
        public string generateCode()
        {

            LabelTextPositionDecorator.RelativePosition pos = extractRelativePositionFromString(posRel);
            int numRows = 0;

            DrawItem label;
            DrawItem text;
            DrawItem labelTextDecoreted;


            CSharpFileCode fileCSharp = new CSharpFileCode();
            fileCSharp.setItems(fileCSharpPath);
            FileItem[] fileItems = fileCSharp.getItems();
            numRows = fileItems.Length;
            StringBuilder code = new StringBuilder();
            DrawItem layoutTableItem = new LayoutTableItem(layoutName, numCol, numRows, xPos, yPos);
            bool drawLayout = true;
            foreach (FileItem item in fileItems)
            {
                label = new LabelItem(item.Name);
                label = new FontStyleDecorator(label, fontColor, fontName, fontStyle);
                text = new TextItem("ed" + item.Name, string.Empty, textBoxWidth);
                labelTextDecoreted = new LabelTextPositionDecorator(layoutTableItem, label, text, pos, drawLayout);
                drawLayout = false;


                code.AppendLine(labelTextDecoreted.writeCode());



            }

            codeGenerated = code.ToString();

            return codeGenerated;



        }

        /// <summary>
        /// 
        /// </summary>
        public void generatePreview()
        {

            if (string.IsNullOrEmpty(codeGenerated))
                return;

            string previwCode = @"
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransformationDePascalAC{
public class FormProva : Form
    {
        public FormProva()
        {
this.SuspendLayout();
            // 
            // FormProva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = ""FormProva"";
            this.Text = ""FormProva"";
            this.ResumeLayout(false);
" + @codeGenerated+ @"
        }

public static void Main(string str)
        {
            FormProva p = new FormProva();
            p.Show();
        }
    }
}";            

            var csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v3.5" } });
            var parameters = new CompilerParameters(new[] { "mscorlib.dll","System.dll", "System.Core.dll", "System.Drawing.dll", "System.Data.dll", "System.Windows.Forms.dll" });
            parameters.GenerateInMemory = true;
            parameters.TreatWarningsAsErrors = false;
            parameters.GenerateExecutable = false;

            CompilerResults compile = csc.CompileAssemblyFromSource(parameters, previwCode);

            if (compile.Errors.HasErrors)
            {
                string text = "Compile error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    text += "rn" + ce.ToString();
                }
                throw new Exception(text);
            }

            

            Module module = compile.CompiledAssembly.GetModules()[0];
            Type mt = null;
            MethodInfo methInfo = null;

            if (module != null)
            {
                mt = module.GetType("TransformationDePascalAC.FormProva");
            }

            if (mt != null)
            {
                methInfo = mt.GetMethod("Main");
            }

            if (methInfo != null)
            {
                methInfo.Invoke(null, new object[] { "preview" });
            }
            //results.Errors.Cast<CompilerError>().ToList().ForEach(error => Console.WriteLine(error.ErrorText));
        }

        #region Private Methods

        private LabelTextPositionDecorator.RelativePosition extractRelativePositionFromString(string posRel)
        {
            LabelTextPositionDecorator.RelativePosition pos = LabelTextPositionDecorator.RelativePosition.labelDown;


            if (posRel == "Destra")
            {
                pos = LabelTextPositionDecorator.RelativePosition.labelRight;

            }
            else if (posRel == "Sinistra")
            {
                pos = LabelTextPositionDecorator.RelativePosition.labelLeft;

            }
            else if (posRel == "Sopra")
            {
                pos = LabelTextPositionDecorator.RelativePosition.labelUp;
            }
            else if (posRel == "Sotto")
            {
                pos = LabelTextPositionDecorator.RelativePosition.labelDown;
            }
            return pos;
        }

        #endregion
    }
}
