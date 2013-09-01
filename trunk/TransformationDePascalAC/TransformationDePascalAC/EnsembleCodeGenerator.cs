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
            //TODO Fare per bene
            string fileGenerated = EnsembleECOInvoker.InvokeCoGe(txtScript.Text, txtService.Text) as string;

            if (!string.IsNullOrEmpty(fileGenerated))
            {
                System.Diagnostics.Process.Start(@fileGenerated);
            }
            

        }
    }
}
