﻿/*
 * Created by SharpDevelop.
 * User: eroreng
 * Date: 04/09/2013
 * Time: 16:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TransformationDePascalAC
{
	/// <summary>
	/// Description of SqlCommentGenerator.
	/// </summary>
	public partial class SqlCommentGenerator : Form
	{
		
		string filePkg = null;
		
		public SqlCommentGenerator()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		
		}
		
		void BtnSelezionaPkgClick(object sender, EventArgs e)
		{
			filePkg = null;
			if(opfPkg.ShowDialog()== DialogResult.OK)
			{
				filePkg = opfPkg.FileName;
				txtPkg.Text = opfPkg.SafeFileName;
			}
		}
	}
}