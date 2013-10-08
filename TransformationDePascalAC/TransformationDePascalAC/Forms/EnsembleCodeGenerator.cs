using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using CoGeBridge;
using CoGeBridge.Invokers;
using CoGeBridge.Model;
using TransformationDePascalAC.Controller;

namespace TransformationDePascalAC.Forms
{
	public partial class EnsembleCodeGenerator : Form
	{
		
		private EnsembleCodeGeneratorController controller;
		
		public EnsembleCodeGenerator()
		{
			InitializeComponent();
			
			controller = EnsembleCodeGeneratorController.Insance;
			
		}

		private void btnSelezionaC_Click(object sender, EventArgs e)
		{
			

			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				txtScript.Text = openFileDialog1.FileName;
				
				try 
				{
					List<Procedure> procs = controller.BuildProceduresFromScript(txtScript.Text);
					procedureBindingSource.DataSource = procs;
					
				} catch (Exception ex) {
					
					MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					
				}
				
				

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
			
			List<Procedure> selectedandCheckedProcs = selectProcedureBS.DataSource as List<Procedure>;
			
			if(selectedandCheckedProcs.Count == 0)
			{
				MessageBox.Show("Devi selezionare almeno una procedura da generare");
				return;
			}
			
			string result = controller.DoGeneration(txtScript.Text, txtService.Text, selectedandCheckedProcs, chkSaveFile.Checked) as string;

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
