using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TransformationDePascalAC.Controller;

namespace TransformationDePascalAC.Forms
{
    public partial class DefBDD2Form : Form
    {
        private string[] positions = { "Sopra", "Sotto", "Destra", "Sinistra" };

        private DefBDD2FormController controller;

        public DefBDD2Form()
        {
            InitializeComponent();
            
            controller = DefBDD2FormController.Instance;

            //Init FontName ComboBox
            initFontComboBox(cbCarattere);
            //Init Position ComboBox
            initPositionComboBox(cbPosizioneRelativa);
        }

        private void initPositionComboBox(ComboBox cbPosizioneRelativa)
        {
            foreach (string pos in positions)
            {
                cbPosizioneRelativa.Items.Add(pos);
            }

            cbPosizioneRelativa.SelectedIndex = 0;
        }

        private void initFontComboBox(ComboBox cbCarattere)
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                cbCarattere.Items.Add(oneFontFamily.Name);
            }

            cbCarattere.SelectedIndex = 0;
        }

        private string cSharpPath;

        private void btnSfoglia_Click(object sender, EventArgs e)
        {
            //al click si apre finestra per selezionare cartella contenente files C#
            DialogResult fileResult = openFileDialog1.ShowDialog();

            if (fileResult == DialogResult.OK)
            {
                cSharpPath = openFileDialog1.FileName;
                txtPath.Text = cSharpPath;
                
            }

        }
        
        private void btnSelectAll_Click(object sender, EventArgs e)
        {

            txtCodeGenerated.SelectAll();
            txtCodeGenerated.Copy();

        }

        private void btnGenerateCode_Click(object sender, EventArgs e)
        {
            if ((txtPosX.Text == string.Empty) || (txtPosY.Text == string.Empty) || (txtSizeW.Text == string.Empty) || (txtNumCol.Text == string.Empty)||(txtPath.Text==string.Empty))
            {
                MessageBox.Show("Inserire tutti i dati");
            }

            else
            {
                
                controller.FileCSharpPath = cSharpPath;
                controller.FontColor = colorDialog.Color.ToArgb();
                controller.FontName = cbCarattere.SelectedItem.ToString();
                controller.FontStyle = (FontStyle) cbStile.SelectedItem ;
                controller.NumCol = int.Parse(txtNumCol.Text);
                controller.PosRel = cbPosizioneRelativa.SelectedItem.ToString();
                controller.TextBoxWidth = int.Parse(txtSizeW.Text);
                controller.XPos = int.Parse(txtPosX.Text);
                controller.YPos = int.Parse(txtPosY.Text);

               


                string code = controller.generateCode();                

                txtCodeGenerated.Text = code;

            }
        }
        private void txtInt_Validating(object sender, CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                try
                {
                    int x = int.Parse(textBox.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Inserire un numero intero");
                }
            }
        }

        

        private void btnColor_Click(object sender, EventArgs e)
        {
            // Show the color dialog.
            DialogResult result = colorDialog.ShowDialog();
            // See if user pressed ok.
            if (result == DialogResult.OK)
            {
                // Set form background to the selected color.
                txtColor.BackColor = colorDialog.Color;
            }

        }

        private void cbCarattere_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbStile.Items.Clear();
            FontFamily f = new FontFamily(cbCarattere.SelectedItem.ToString());
            foreach (FontStyle style in Enum.GetValues(typeof(FontStyle)))
            {
                if (f.IsStyleAvailable(style) )
                {
                    cbStile.Items.Add(style);
                }
            }

            cbStile.SelectedIndex = 0;

           
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            controller.generatePreview();
        }

      

      

      

       
    }
}
