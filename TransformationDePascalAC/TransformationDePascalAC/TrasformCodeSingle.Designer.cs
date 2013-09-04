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
			this.txtCSharp.Size = new System.Drawing.Size(226, 20);
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
			this.txtPascal.Size = new System.Drawing.Size(226, 20);
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
			// 
			// btnConvert
			// 
			this.btnConvert.Location = new System.Drawing.Point(108, 126);
			this.btnConvert.Name = "btnConvert";
			this.btnConvert.Size = new System.Drawing.Size(94, 36);
			this.btnConvert.TabIndex = 15;
			this.btnConvert.Text = "Converti";
			this.btnConvert.UseVisualStyleBackColor = true;
			// 
			// txtResult
			// 
			this.txtResult.Location = new System.Drawing.Point(12, 173);
			this.txtResult.Multiline = true;
			this.txtResult.Name = "txtResult";
			this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtResult.Size = new System.Drawing.Size(312, 143);
			this.txtResult.TabIndex = 16;
			// 
			// TrasformCodeSingle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 328);
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
