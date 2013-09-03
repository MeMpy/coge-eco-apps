using CoGeBridge;
using EnsembleCoGe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TransformationDePascalAC
{
    public partial class EnsembleCodeGenerator : Form
    {
        public EnsembleCodeGenerator()
        {
            InitializeComponent();
        }

        private void btnSelezionaC_Click(object sender, EventArgs e)
        {
            

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtScript.Text = openFileDialog1.FileName;
                string xml = ProceduresInvoker.InvokeCoGe(txtScript.Text).ToString();
                List<Procedure> procs = ProceduresBuilder.BuildProceduresFromXml(xml);
                procedureBindingSource.DataSource = procs;

            }




        }

        private void btnSelectRows_Click(object sender, EventArgs e)
        {
            List<Procedure> selectedProcs = new List<Procedure>();
            foreach (DataGridViewRow rowView in gwProcedures.SelectedRows)
            {
                selectedProcs.Add(rowView.DataBoundItem as Procedure);
            }

            selectProcedureBS.DataSource = selectedProcs;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtService.Text))
            {
                MessageBox.Show("Devi inserire anche il nome del servizio");
                return;
            }
            string result = EnsembleECOInvoker.InvokeCoGe(txtScript.Text, txtService.Text, chkSaveFile.Checked) as string;

            //TODO Fare per bene
            if (chkSaveFile.Checked)
            {
                //In result ci sarà il nome del file in cui è stato salvato il codice
                if (!string.IsNullOrEmpty(result))
                {
                    System.Diagnostics.Process.Start(result);
                }
            }
            else
            {
                //in result ci sarà proprio il codice
                if (!string.IsNullOrEmpty(result))
                {
                    txtCode.Text = result;
                }

            }
            
        }
    }
}
