/*
 * Created by SharpDevelop.
 * User: eroreng
 * Date: 04/09/2013
 * Time: 14:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TransformationDePascalAC
{
	partial class TrasformCodeSingle
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
			this.lbCsharp = new System.Windows.Forms.Label();
			this.txtCSharp = new System.Windows.Forms.TextBox();
			this.btnSelezionaCSharp = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPascal = new System.Windows.Forms.TextBox();
			this.btnSelezionaPascal = new System.Windows.Forms.Button();
			this.btnConvert = new System.Windows.Forms.Button();
			this.txtResult = new System.Windows.Forms.TextBox();
			this.opdCSharp = new System.Windows.Forms.OpenFileDialog();
			this.opdPascal = new System.Windows.Forms.OpenFileDialog();
			this.lbDest = new System.Windows.Forms.Label();
			this.txtDest = new System.Windows.Forms.TextBox();
			this.btnDest = new System.Windows.Forms.Button();
			this.fbdDest = new System.Windows.Forms.FolderBrowserDialog();
			this.SuspendLayout();
			// 
			// lbCsharp
			// 
			this.lbCsharp.AutoSize = true;
			this.lbCsharp.Location = new System.Drawing.Point(12, 9);
			this.lbCsharp.Name = "lbCsharp";
			this.lbCsharp.Size = new System.Drawing.Size(111, 13);
			this.lbCsharp.TabIndex = 11;
			this.lbCsharp.Text = "Seleziona defBDD C#";
			// 
			// txtCSharp
			// 
			this.txtCSharp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtCSharp.Location = new System.Drawing.Point(108, 27);
			this.txtCSharp.Name = "txtCSharp";
			this.txtCSharp.ReadOnly = true;
			this.txtCSharp.Size = new System.Drawing.Size(279, 20);
			this.txtCSharp.TabIndex = 10;
			// 
			// btnSelezionaCSharp
			// 
			this.btnSelezionaCSharp.Location = new System.Drawing.Point(12, 25);
			this.btnSelezionaCSharp.Name = "btnSelezionaCSharp";
			this.btnSelezionaCSharp.Size = new System.Drawing.Size(75, 22);
			this.btnSelezionaCSharp.TabIndex = 9;
			this.btnSelezionaCSharp.Text = "Sfoglia";
			this.btnSelezionaCSharp.UseVisualStyleBackColor = true;
			this.btnSelezionaCSharp.Click += new System.EventHandler(this.BtnSelezionaCSharpClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Seleziona defBDD Pascal";
			// 
			// txtPascal
			// 
			this.txtPascal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtPascal.Location = new System.Drawing.Point(108, 86);
			this.txtPascal.Name = "txtPascal";
			this.txtPascal.ReadOnly = true;
			this.txtPascal.Size = new System.Drawing.Size(279, 20);
			this.txtPascal.TabIndex = 13;
			// 
			// btnSelezionaPascal
			// 
			this.btnSelezionaPascal.Location = new System.Drawing.Point(12, 84);
			this.btnSelezionaPascal.Name = "btnSelezionaPascal";
			this.btnSelezionaPascal.Size = new System.Drawing.Size(75, 22);
			this.btnSelezionaPascal.TabIndex = 12;
			this.btnSelezionaPascal.Text = "Sfoglia";
			this.btnSelezionaPascal.UseVisualStyleBackColor = true;
			this.btnSelezionaPascal.Click += new System.EventHandler(this.BtnSelezionaPascalClick);
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(142, 174);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(94, 36);
			this.btnConvert.TabIndex = 15;
			this.btnConvert.Text = "Converti";
			this.btnConvert.UseVisualStyleBackColor = true;
			this.btnConvert.Click += new System.EventHandler(this.BtnConvertClick);
			// 
			// txtResult
			// 
			this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.txtResult.Location = new System.Drawing.Point(12, 216);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtResult.Size = new System.Drawing.Size(365, 143);
			this.txtResult.TabIndex = 16;
			this.txtResult.WordWrap = false;
			// 
			// opdCSharp
			// 
			this.opdCSharp.FileName = "openFileDialog1";
			// 
			// opdPascal
			// 
			this.opdPascal.FileName = "openFileDialog2";
			// 
			// lbDest
			// 
			this.lbDest.AutoSize = true;
			this.lbDest.Location = new System.Drawing.Point(11, 121);
			this.lbDest.Name = "lbDest";
			this.lbDest.Size = new System.Drawing.Size(313, 13);
			this.lbDest.TabIndex = 19;
			this.lbDest.Text = "Seleziona cartella di destinazione (lascia vuoto per sovrascrivere)";
			// 
			// txtDest
			// 
			this.txtDest.Location = new System.Drawing.Point(110, 139);
			this.txtDest.Name = "txtDest";
			this.txtDest.ReadOnly = true;
			this.txtDest.Size = new System.Drawing.Size(277, 20);
			this.txtDest.TabIndex = 18;
			// 
			// btnDest
			// 
			this.btnDest.Location = new System.Drawing.Point(14, 137);
			this.btnDest.Name = "btnDest";
			this.btnDest.Size = new System.Drawing.Size(73, 22);
			this.btnDest.TabIndex = 17;
			this.btnDest.Text = "Sfoglia";
			this.btnDest.UseVisualStyleBackColor = true;
			this.btnDest.Click += new System.EventHandler(this.BtnDestClick);
			// 
			// TrasformCodeSingle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 371);
			this.Controls.Add(this.lbDest);
			this.Controls.Add(this.txtDest);
			this.Controls.Add(this.btnDest);
			this.Controls.Add(this.txtResult);
			this.Controls.Add(this.btnConvert);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPascal);
			this.Controls.Add(this.btnSelezionaPascal);
			this.Controls.Add(this.lbCsharp);
			this.Controls.Add(this.txtCSharp);
			this.Controls.Add(this.btnSelezionaCSharp);
			this.Name = "TrasformCodeSingle";
			this.Text = "TrasformCodeSingle";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.FolderBrowserDialog fbdDest;
		private System.Windows.Forms.Button btnDest;
		private System.Windows.Forms.TextBox txtDest;
		private System.Windows.Forms.Label lbDest;
		private System.Windows.Forms.OpenFileDialog opdPascal;
		private System.Windows.Forms.OpenFileDialog opdCSharp;
		private System.Windows.Forms.TextBox txtResult;
		private System.Windows.Forms.Button btnConvert;
		private System.Windows.Forms.Button btnSelezionaPascal;
		private System.Windows.Forms.TextBox txtPascal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSelezionaCSharp;
		private System.Windows.Forms.TextBox txtCSharp;
		private System.Windows.Forms.Label lbCsharp;
	}
}
