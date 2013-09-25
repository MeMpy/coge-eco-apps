/*
 * Created by SharpDevelop.
 * User: eroreng
 * Date: 04/09/2013
 * Time: 16:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TransformationDePascalAC.Forms
{
	partial class SqlCommentGenerator
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbCredit = new System.Windows.Forms.Label();
			this.lbSource = new System.Windows.Forms.Label();
			this.lbPass = new System.Windows.Forms.Label();
			this.lbName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.lbCsharp = new System.Windows.Forms.Label();
			this.txtPkg = new System.Windows.Forms.TextBox();
			this.btnSelezionaPkg = new System.Windows.Forms.Button();
			this.btnGenerate = new System.Windows.Forms.Button();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.opfPkg = new System.Windows.Forms.OpenFileDialog();
			this.chkOverwriteFile = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lbCredit
			// 
			this.lbCredit.Location = new System.Drawing.Point(12, 9);
			this.lbCredit.Name = "lbCredit";
			this.lbCredit.Size = new System.Drawing.Size(100, 23);
			this.lbCredit.TabIndex = 0;
			this.lbCredit.Text = "Credenziali DB";
			// 
			// lbSource
			// 
			this.lbSource.Location = new System.Drawing.Point(12, 108);
			this.lbSource.Name = "lbSource";
			this.lbSource.Size = new System.Drawing.Size(100, 23);
			this.lbSource.TabIndex = 1;
			this.lbSource.Text = "Database";
			// 
			// lbPass
			// 
			this.lbPass.Location = new System.Drawing.Point(12, 77);
			this.lbPass.Name = "lbPass";
			this.lbPass.Size = new System.Drawing.Size(100, 23);
			this.lbPass.TabIndex = 2;
			this.lbPass.Text = "Password";
			// 
			// lbName
			// 
			this.lbName.Location = new System.Drawing.Point(12, 44);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(100, 23);
			this.lbName.TabIndex = 3;
			this.lbName.Text = "User";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(83, 44);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 20);
			this.txtName.TabIndex = 1;
			// 
			// txtSource
			// 
			this.txtSource.Location = new System.Drawing.Point(83, 105);
			this.txtSource.Name = "txtSource";
			this.txtSource.Size = new System.Drawing.Size(100, 20);
			this.txtSource.TabIndex = 3;
			// 
			// txtPass
			// 
			this.txtPass.Location = new System.Drawing.Point(83, 74);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(100, 20);
			this.txtPass.TabIndex = 2;
			// 
			// lbCsharp
			// 
			this.lbCsharp.AutoSize = true;
			this.lbCsharp.Location = new System.Drawing.Point(9, 145);
			this.lbCsharp.Name = "lbCsharp";
			this.lbCsharp.Size = new System.Drawing.Size(293, 13);
			this.lbCsharp.TabIndex = 14;
			this.lbCsharp.Text = "Seleziona package contenente le procedure da commentare";
			// 
			// txtPkg
			// 
			this.txtPkg.Location = new System.Drawing.Point(105, 163);
			this.txtPkg.Name = "txtPkg";
			this.txtPkg.ReadOnly = true;
			this.txtPkg.Size = new System.Drawing.Size(197, 20);
			this.txtPkg.TabIndex = 13;
			// 
			// btnSelezionaPkg
			// 
			this.btnSelezionaPkg.Location = new System.Drawing.Point(9, 161);
			this.btnSelezionaPkg.Name = "btnSelezionaPkg";
			this.btnSelezionaPkg.Size = new System.Drawing.Size(74, 22);
			this.btnSelezionaPkg.TabIndex = 4;
			this.btnSelezionaPkg.Text = "Sfoglia";
			this.btnSelezionaPkg.UseVisualStyleBackColor = true;
			this.btnSelezionaPkg.Click += new System.EventHandler(this.BtnSelezionaPkgClick);
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(105, 189);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(125, 46);
			this.btnGenerate.TabIndex = 15;
			this.btnGenerate.Text = "Genera!!";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.BtnGenerateClick);
			// 
			// txtResult
			// 
			this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtResult.Location = new System.Drawing.Point(9, 241);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtResult.Size = new System.Drawing.Size(370, 143);
			this.txtResult.TabIndex = 17;
			this.txtResult.WordWrap = false;
			// 
			// opfPkg
			// 
			this.opfPkg.FileName = "openFileDialog1";
			// 
			// chkOverwriteFile
			// 
			this.chkOverwriteFile.Location = new System.Drawing.Point(236, 201);
			this.chkOverwriteFile.Name = "chkOverwriteFile";
			this.chkOverwriteFile.Size = new System.Drawing.Size(104, 24);
			this.chkOverwriteFile.TabIndex = 18;
			this.chkOverwriteFile.Text = "Sovrascrivi file";
			this.chkOverwriteFile.UseVisualStyleBackColor = true;
			// 
			// SqlCommentGenerator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(391, 392);
			this.Controls.Add(this.chkOverwriteFile);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.lbCsharp);
			this.Controls.Add(this.txtPkg);
			this.Controls.Add(this.btnSelezionaPkg);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.txtSource);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.lbName);
			this.Controls.Add(this.lbPass);
			this.Controls.Add(this.lbSource);
			this.Controls.Add(this.lbCredit);
			this.Name = "SqlCommentGenerator";
			this.Text = "SqlCommentGenerator";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.CheckBox chkOverwriteFile;
		private System.Windows.Forms.OpenFileDialog opfPkg;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnSelezionaPkg;
		private System.Windows.Forms.TextBox txtPkg;
		private System.Windows.Forms.Label lbCsharp;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lbName;
		private System.Windows.Forms.Label lbPass;
		private System.Windows.Forms.Label lbSource;
		private System.Windows.Forms.Label lbCredit;
	}
}
