using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using TransformationDePascalAC.model;
using CodeTransformation;
using CoGeBridge;
using EnsembleCoGe;

namespace TransformationDePascalAC
{
	public partial class TransformCode : Form
	{
		
		private string[] filesPascal;
		private string[] filesC;

		private List<FileMatched> filesMatched;

		public TransformCode()
		{
			InitializeComponent();
			
		}


		#region Event

		#region Button click

		private void btnSelezionaP_Click(object sender, EventArgs e)
		{
			//al click si apre finestra per selezionare cartella contenente files Pascal
			DialogResult folderResult = folderSource.ShowDialog();

			if (folderResult == DialogResult.OK)
			{
				filesPascal = Directory.GetFiles(folderSource.SelectedPath, @"*.pas", SearchOption.AllDirectories);
				txtPascal.Text = folderSource.SelectedPath;
			}
		}

		private void btnSelezionaC_Click(object sender, EventArgs e)
		{
			//al click si apre finestra per selezionare cartella contenente files C#
			DialogResult folderResult = folderSource.ShowDialog();

			if (folderResult == DialogResult.OK)
			{

				txtCSharp.Text = folderSource.SelectedPath;
			}
		}

		private void btnDest_Click(object sender, EventArgs e)
		{
			//al click si apre finestra per selezionare cartella di destinazione
			DialogResult folderResult = folderSource.ShowDialog();

			if (folderResult == DialogResult.OK)
			{

				txtDest.Text = folderSource.SelectedPath;
			}
		}



		private void btnRunMatch_Click(object sender, EventArgs e)
		{
			//messagebox se non si selezionano cartella origine o cartella destinazione

			if (txtCSharp.Text == string.Empty)
			{
				MessageBox.Show("Selezionare cartella contenente files da aggiornare");
			}
			else if (txtPascal.Text == string.Empty)
			{
				MessageBox.Show("Selezionare cartella contenente files con dati utili per l'aggiornamento");
			}
			else
			{
				filesC = Directory.GetFiles(txtCSharp.Text, @"*.cs", SearchOption.AllDirectories);
				filesPascal = Directory.GetFiles(txtPascal.Text, @"*.pas", SearchOption.AllDirectories);
				filesMatched = TransformationPascalC.findMatchesCSharpIntoPascal(filesC, filesPascal);



				gridViewFileMatched.DataSource = filesMatched;

			}
		}

		private void btntrasform_Click(object sender, EventArgs e)
		{
			List<FileMatched> fileMatchedFromGrid = gridViewFileMatched.DataSource as List<FileMatched>;
			int count = 0;
			object trasformed = null;

			string destPath = string.IsNullOrEmpty(txtDest.Text)? null: txtDest.Text;

			foreach (FileMatched item in fileMatchedFromGrid)
			{
				if (item.CheckedForTransformation)
				{
					trasformed = TransformationPascalC.doTransformation(item.FullPathPascalFile, item.FullPathCFile, destPath);
					if (trasformed!=null)
						count++;
				}
			}

			if (count > 0)
			{
				MessageBox.Show("Trasformazione effettuata per: " + count + " files");
			}
			else
			{
				MessageBox.Show("Nessuna trasformazione effettuata");
			}


		}

		


		#endregion
		
		#region ToolStrip Menu
		private void esciToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
			this.Dispose();
		}
		
		private void generatoreGuiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			OpenNewForm(new DefBDD2Form());
		}


		private void generatoreEnsemblesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			OpenNewForm(new EnsembleCodeGenerator());
		}
		
		private void ConvertiDefBDDSingoliToolStripMenuItemClick(object sender, EventArgs e)
        {
        	OpenNewForm(new TrasformCodeSingle());
        }
		
		private void GeneraCommentiSqlToolStripMenuItemClick(object sender, EventArgs e)
        {
			OpenNewForm(new SqlCommentGenerator());
        }

		private void OpenNewForm(Form f)
		{
			this.Visible = false;
			DialogResult diag = f.ShowDialog();

			this.Visible = true;
		}
		
		void ViewCodesToolStripMenuItemClick(object sender, EventArgs e)
        {
			new InvokeEcoSnip().OpenEcoSnip();
        }

		#endregion

		private void selectAllChkBox_CheckedChanged(object sender, EventArgs e)
		{
			for (int i = 0; i < gridViewFileMatched.RowCount; i++)
			{
				gridViewFileMatched[2, i].Value = selectAllChkBox.Checked;
			}
		}

		#endregion

        
       
        
        
	}

}