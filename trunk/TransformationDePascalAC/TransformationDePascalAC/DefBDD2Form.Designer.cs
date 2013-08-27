namespace TransformationDePascalAC
{
    partial class DefBDD2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSfoglia = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtCodeGenerated = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.labelPosizRelativa = new System.Windows.Forms.Label();
            this.labelPosizione = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelPoizX = new System.Windows.Forms.Label();
            this.labelPosizY = new System.Windows.Forms.Label();
            this.labelCarattere = new System.Windows.Forms.Label();
            this.txtSizeW = new System.Windows.Forms.TextBox();
            this.txtPosY = new System.Windows.Forms.TextBox();
            this.txtPosX = new System.Windows.Forms.TextBox();
            this.cbPosizioneRelativa = new System.Windows.Forms.ComboBox();
            this.cbCarattere = new System.Windows.Forms.ComboBox();
            this.btnGenerateCode = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.labelNumCol = new System.Windows.Forms.Label();
            this.txtNumCol = new System.Windows.Forms.TextBox();
            this.labelStile = new System.Windows.Forms.Label();
            this.cbStile = new System.Windows.Forms.ComboBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSfoglia
            // 
            this.btnSfoglia.Location = new System.Drawing.Point(513, 16);
            this.btnSfoglia.Name = "btnSfoglia";
            this.btnSfoglia.Size = new System.Drawing.Size(75, 22);
            this.btnSfoglia.TabIndex = 0;
            this.btnSfoglia.Text = "Sfoglia";
            this.btnSfoglia.UseVisualStyleBackColor = true;
            this.btnSfoglia.Click += new System.EventHandler(this.btnSfoglia_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(27, 18);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(480, 20);
            this.txtPath.TabIndex = 1;
            // 
            // txtCodeGenerated
            // 
            this.txtCodeGenerated.Location = new System.Drawing.Point(318, 63);
            this.txtCodeGenerated.Multiline = true;
            this.txtCodeGenerated.Name = "txtCodeGenerated";
            this.txtCodeGenerated.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCodeGenerated.Size = new System.Drawing.Size(270, 226);
            this.txtCodeGenerated.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(502, 295);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(86, 23);
            this.btnSelectAll.TabIndex = 18;
            this.btnSelectAll.Text = "Copia codice";
            this.toolTip.SetToolTip(this.btnSelectAll, "Copia negli appunti l\'intero codice presente nella textbox");
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // labelPosizRelativa
            // 
            this.labelPosizRelativa.AutoSize = true;
            this.labelPosizRelativa.Location = new System.Drawing.Point(24, 138);
            this.labelPosizRelativa.Name = "labelPosizRelativa";
            this.labelPosizRelativa.Size = new System.Drawing.Size(89, 13);
            this.labelPosizRelativa.TabIndex = 9;
            this.labelPosizRelativa.Text = "Posizione relativa";
            this.toolTip.SetToolTip(this.labelPosizRelativa, "Posizione label rispetto alla textbox");
            // 
            // labelPosizione
            // 
            this.labelPosizione.AutoSize = true;
            this.labelPosizione.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosizione.ForeColor = System.Drawing.Color.Black;
            this.labelPosizione.Location = new System.Drawing.Point(24, 63);
            this.labelPosizione.Name = "labelPosizione";
            this.labelPosizione.Size = new System.Drawing.Size(53, 14);
            this.labelPosizione.TabIndex = 2;
            this.labelPosizione.Text = "Posizione";
            this.toolTip.SetToolTip(this.labelPosizione, "Posizione da cui si inizia a disegnare la GUI");
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(24, 96);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(96, 13);
            this.labelSize.TabIndex = 7;
            this.labelSize.Text = "Larghezza text box";
            // 
            // labelPoizX
            // 
            this.labelPoizX.AutoSize = true;
            this.labelPoizX.Location = new System.Drawing.Point(155, 63);
            this.labelPoizX.Name = "labelPoizX";
            this.labelPoizX.Size = new System.Drawing.Size(14, 13);
            this.labelPoizX.TabIndex = 3;
            this.labelPoizX.Text = "X";
            // 
            // labelPosizY
            // 
            this.labelPosizY.AutoSize = true;
            this.labelPosizY.Location = new System.Drawing.Point(234, 63);
            this.labelPosizY.Name = "labelPosizY";
            this.labelPosizY.Size = new System.Drawing.Size(14, 13);
            this.labelPosizY.TabIndex = 5;
            this.labelPosizY.Text = "Y";
            // 
            // labelCarattere
            // 
            this.labelCarattere.AutoSize = true;
            this.labelCarattere.Location = new System.Drawing.Point(24, 220);
            this.labelCarattere.Name = "labelCarattere";
            this.labelCarattere.Size = new System.Drawing.Size(50, 13);
            this.labelCarattere.TabIndex = 13;
            this.labelCarattere.Text = "Carattere";
            // 
            // txtSizeW
            // 
            this.txtSizeW.Location = new System.Drawing.Point(175, 93);
            this.txtSizeW.Name = "txtSizeW";
            this.txtSizeW.Size = new System.Drawing.Size(42, 20);
            this.txtSizeW.TabIndex = 8;
            this.txtSizeW.Text = "50";
            this.txtSizeW.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt_Validating);
            // 
            // txtPosY
            // 
            this.txtPosY.Location = new System.Drawing.Point(254, 60);
            this.txtPosY.Name = "txtPosY";
            this.txtPosY.Size = new System.Drawing.Size(42, 20);
            this.txtPosY.TabIndex = 6;
            this.txtPosY.Text = "0";
            this.txtPosY.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt_Validating);
            // 
            // txtPosX
            // 
            this.txtPosX.Location = new System.Drawing.Point(175, 60);
            this.txtPosX.Name = "txtPosX";
            this.txtPosX.Size = new System.Drawing.Size(42, 20);
            this.txtPosX.TabIndex = 4;
            this.txtPosX.Text = "0";
            this.txtPosX.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt_Validating);
            // 
            // cbPosizioneRelativa
            // 
            this.cbPosizioneRelativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPosizioneRelativa.FormattingEnabled = true;
            this.cbPosizioneRelativa.Location = new System.Drawing.Point(175, 138);
            this.cbPosizioneRelativa.Name = "cbPosizioneRelativa";
            this.cbPosizioneRelativa.Size = new System.Drawing.Size(121, 21);
            this.cbPosizioneRelativa.TabIndex = 10;
            // 
            // cbCarattere
            // 
            this.cbCarattere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarattere.FormattingEnabled = true;
            this.cbCarattere.Location = new System.Drawing.Point(175, 217);
            this.cbCarattere.Name = "cbCarattere";
            this.cbCarattere.Size = new System.Drawing.Size(121, 21);
            this.cbCarattere.TabIndex = 14;
            this.cbCarattere.SelectedIndexChanged += new System.EventHandler(this.cbCarattere_SelectedIndexChanged);
            // 
            // btnGenerateCode
            // 
            this.btnGenerateCode.Location = new System.Drawing.Point(182, 295);
            this.btnGenerateCode.Name = "btnGenerateCode";
            this.btnGenerateCode.Size = new System.Drawing.Size(114, 43);
            this.btnGenerateCode.TabIndex = 16;
            this.btnGenerateCode.Text = "Genera codice";
            this.btnGenerateCode.UseVisualStyleBackColor = true;
            this.btnGenerateCode.Click += new System.EventHandler(this.btnGenerateCode_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(24, 315);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(86, 23);
            this.btnColor.TabIndex = 16;
            this.btnColor.Text = "Scegli Colore";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.Black;
            this.txtColor.Location = new System.Drawing.Point(116, 318);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(19, 20);
            this.txtColor.TabIndex = 20;
            // 
            // labelNumCol
            // 
            this.labelNumCol.AutoSize = true;
            this.labelNumCol.Location = new System.Drawing.Point(24, 181);
            this.labelNumCol.Name = "labelNumCol";
            this.labelNumCol.Size = new System.Drawing.Size(86, 13);
            this.labelNumCol.TabIndex = 21;
            this.labelNumCol.Text = "Numero Colonne";
            // 
            // txtNumCol
            // 
            this.txtNumCol.Location = new System.Drawing.Point(175, 173);
            this.txtNumCol.Name = "txtNumCol";
            this.txtNumCol.Size = new System.Drawing.Size(42, 20);
            this.txtNumCol.TabIndex = 11;
            this.txtNumCol.Text = "2";
            this.txtNumCol.Validating += new System.ComponentModel.CancelEventHandler(this.txtInt_Validating);
            // 
            // labelStile
            // 
            this.labelStile.AutoSize = true;
            this.labelStile.Location = new System.Drawing.Point(24, 265);
            this.labelStile.Name = "labelStile";
            this.labelStile.Size = new System.Drawing.Size(27, 13);
            this.labelStile.TabIndex = 22;
            this.labelStile.Text = "Stile";
            // 
            // cbStile
            // 
            this.cbStile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStile.FormattingEnabled = true;
            this.cbStile.Location = new System.Drawing.Point(175, 262);
            this.cbStile.Name = "cbStile";
            this.cbStile.Size = new System.Drawing.Size(121, 21);
            this.cbStile.TabIndex = 23;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(318, 295);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(110, 43);
            this.btnPreview.TabIndex = 24;
            this.btnPreview.Text = "Anteprima";
            this.toolTip.SetToolTip(this.btnPreview, "Mostra  l\'anteprima del codice generato");
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // DefBDD2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.cbStile);
            this.Controls.Add(this.labelStile);
            this.Controls.Add(this.txtNumCol);
            this.Controls.Add(this.labelNumCol);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.btnGenerateCode);
            this.Controls.Add(this.cbCarattere);
            this.Controls.Add(this.cbPosizioneRelativa);
            this.Controls.Add(this.txtPosX);
            this.Controls.Add(this.txtPosY);
            this.Controls.Add(this.txtSizeW);
            this.Controls.Add(this.labelCarattere);
            this.Controls.Add(this.labelPosizRelativa);
            this.Controls.Add(this.labelPosizY);
            this.Controls.Add(this.labelPoizX);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.labelPosizione);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.txtCodeGenerated);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnSfoglia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DefBDD2Form";
            this.Text = "DefBDD2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSfoglia;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtCodeGenerated;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label labelPosizione;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelPoizX;
        private System.Windows.Forms.Label labelPosizY;
        private System.Windows.Forms.Label labelPosizRelativa;
        private System.Windows.Forms.Label labelCarattere;
        private System.Windows.Forms.TextBox txtSizeW;
        private System.Windows.Forms.TextBox txtPosY;
        private System.Windows.Forms.TextBox txtPosX;
        private System.Windows.Forms.ComboBox cbPosizioneRelativa;
        private System.Windows.Forms.ComboBox cbCarattere;
        private System.Windows.Forms.Button btnGenerateCode;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label labelNumCol;
        private System.Windows.Forms.TextBox txtNumCol;
        private System.Windows.Forms.Label labelStile;
        private System.Windows.Forms.ComboBox cbStile;
        private System.Windows.Forms.Button btnPreview;
    }
}