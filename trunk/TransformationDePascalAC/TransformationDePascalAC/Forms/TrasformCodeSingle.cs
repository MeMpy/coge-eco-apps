/*
 * Created by SharpDevelop.
 * User: eroreng
 * Date: 04/09/2013
 * Time: 14:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using CodeTransformation;
using TransformationDePascalAC.Controller;
using CodeTransformation.Model;

namespace TransformationDePascalAC.Forms
{
	/// <summary>
	/// Description of TrasformCodeSingle.
	/// </summary>
	public partial class TrasformCodeSingle : Form
	{
		string fileCSharp = null;
		string filePascal = null;
		
		public TrasformCodeSingle()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			

		}
		
		void BtnSelezionaCSharpClick(object sender, EventArgs e)
		{
			fileCSharp = null;
			if(opdCSharp.ShowDialog()== DialogResult.OK)
			{
				fileCSharp = opdCSharp.FileName;
				txtCSharp.Text = opdCSharp.SafeFileName;
			}
			
		}
		
		void BtnSelezionaPascalClick(object sender, EventArgs e)
		{
			filePascal = null;
			if(opdPascal.ShowDialog()== DialogResult.OK)
			{
				filePascal = opdPascal.FileName;
				txtPascal.Text = opdPascal.SafeFileName;
			}
			
		}
		
		void BtnDestClick(object sender, EventArgs e)
		{
			string destPath = null;
			if(fbdDest.ShowDialog()== DialogResult.OK)
			{
				destPath = opdCSharp.FileName;
				txtDest.Text = destPath;
			}
		}
		
		void BtnConvertClick(object sender, EventArgs e)
		{
			 string destPath = string.IsNullOrEmpty(txtDest.Text)? null: txtDest.Text;			 
			 
			 object trasformed = null;
			 
			 if (fileCSharp != null && filePascal != null){
			 	
			 	trasformed = TransformCodeController.doTransformation(filePascal, fileCSharp, destPath);
			 	
			 	if(trasformed!=null)
			 	{
			 		FileCode trasformedFile = trasformed as FileCode;
			 		if(trasformedFile!=null)
			 		{
			 			txtResult.Text = string.Empty;
			 			foreach (var element in trasformedFile.getItems()) {
			 				txtResult.Text+=element.ToString() + System.Environment.NewLine;
			 			}
			 		}
			 	}else
			 	{
			 		 MessageBox.Show("Nessuna trasformazione effettuata");	
			 	}
			 }
			 
			 
			 
			
		}
		
		
	}
}
