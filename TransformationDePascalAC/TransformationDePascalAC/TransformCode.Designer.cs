using TransformationDePascalAC.model;
namespace TransformationDePascalAC
{
    partial class TransformCode
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileC = new System.Windows.Forms.OpenFileDialog();
            this.txtPascal = new System.Windows.Forms.TextBox();
            this.btnSelezionaP = new System.Windows.Forms.Button();
            this.folderSource = new System.Windows.Forms.FolderBrowserDialog();
            this.txtCSharp = new System.Windows.Forms.TextBox();
            this.btnSelezionaC = new System.Windows.Forms.Button();
            this.btnRunMatch = new System.Windows.Forms.Button();
            this.gridViewFileMatched = new System.Windows.Forms.DataGridView();
            this.filePascalSimpleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fileCSimpleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Trasform = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fileMatchedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblC = new System.Windows.Forms.Label();
            this.lblPascal = new System.Windows.Forms.Label();
            this.btntrasform = new System.Windows.Forms.Button();
            this.selectAllChkBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatoreCodiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnTrasformDefBDD = new System.Windows.Forms.Panel();
            this.lbDest = new System.Windows.Forms.Label();
            this.txtDest = new System.Windows.Forms.TextBox();
            this.btnDest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFileMatched)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileMatchedBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pnTrasformDefBDD.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileC
            // 
            this.openFileC.FileName = "openFileDialog1";
            // 
            // txtPascal
            // 
            this.txtPascal.Location = new System.Drawing.Point(108, 83);
            this.txtPascal.Name = "txtPascal";
            this.txtPascal.ReadOnly = true;
            this.txtPascal.Size = new System.Drawing.Size(298, 20);
            this.txtPascal.TabIndex = 3;
            this.txtPascal.Text = "E:\\SVN_USI_ECO\\TransformationDePascalAC\\project - Copy (file for test)\\Pascal";
            // 
            // btnSelezionaP
            // 
            this.btnSelezionaP.Location = new System.Drawing.Point(12, 81);
            this.btnSelezionaP.Name = "btnSelezionaP";
            this.btnSelezionaP.Size = new System.Drawing.Size(75, 22);
            this.btnSelezionaP.TabIndex = 2;
            this.btnSelezionaP.Text = "Sfoglia";
            this.btnSelezionaP.UseVisualStyleBackColor = true;
            this.btnSelezionaP.Click += new System.EventHandler(this.btnSelezionaP_Click);
            // 
            // txtCSharp
            // 
            this.txtCSharp.Location = new System.Drawing.Point(108, 34);
            this.txtCSharp.Name = "txtCSharp";
            this.txtCSharp.ReadOnly = true;
            this.txtCSharp.Size = new System.Drawing.Size(298, 20);
            this.txtCSharp.TabIndex = 5;
            this.txtCSharp.Text = "E:\\SVN_USI_ECO\\TransformationDePascalAC\\project - Copy (file for test)\\C#";
            // 
            // btnSelezionaC
            // 
            this.btnSelezionaC.Location = new System.Drawing.Point(12, 32);
            this.btnSelezionaC.Name = "btnSelezionaC";
            this.btnSelezionaC.Size = new System.Drawing.Size(75, 22);
            this.btnSelezionaC.TabIndex = 4;
            this.btnSelezionaC.Text = "Sfoglia";
            this.btnSelezionaC.UseVisualStyleBackColor = true;
            this.btnSelezionaC.Click += new System.EventHandler(this.btnSelezionaC_Click);
            // 
            // btnRunMatch
            // 
            this.btnRunMatch.Location = new System.Drawing.Point(120, 181);
            this.btnRunMatch.Name = "btnRunMatch";
            this.btnRunMatch.Size = new System.Drawing.Size(152, 30);
            this.btnRunMatch.TabIndex = 6;
            this.btnRunMatch.Text = "Trova corrispondenza files";
            this.btnRunMatch.UseVisualStyleBackColor = true;
            this.btnRunMatch.Click += new System.EventHandler(this.btnRunMatch_Click);
            // 
            // gridViewFileMatched
            // 
            this.gridViewFileMatched.AllowUserToAddRows = false;
            this.gridViewFileMatched.AllowUserToDeleteRows = false;
            this.gridViewFileMatched.AllowUserToResizeRows = false;
            this.gridViewFileMatched.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewFileMatched.AutoGenerateColumns = false;
            this.gridViewFileMatched.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridViewFileMatched.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewFileMatched.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filePascalSimpleNameDataGridViewTextBoxColumn,
            this.fileCSimpleNameDataGridViewTextBoxColumn,
            this.Trasform});
            this.gridViewFileMatched.DataSource = this.fileMatchedBindingSource;
            this.gridViewFileMatched.Location = new System.Drawing.Point(12, 235);
            this.gridViewFileMatched.MultiSelect = false;
            this.gridViewFileMatched.Name = "gridViewFileMatched";
            this.gridViewFileMatched.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewFileMatched.RowHeadersVisible = false;
            this.gridViewFileMatched.Size = new System.Drawing.Size(422, 198);
            this.gridViewFileMatched.TabIndex = 7;
            // 
            // filePascalSimpleNameDataGridViewTextBoxColumn
            // 
            this.filePascalSimpleNameDataGridViewTextBoxColumn.DataPropertyName = "FilePascalSimpleName";
            this.filePascalSimpleNameDataGridViewTextBoxColumn.HeaderText = "FilePascalSimpleName";
            this.filePascalSimpleNameDataGridViewTextBoxColumn.Name = "filePascalSimpleNameDataGridViewTextBoxColumn";
            this.filePascalSimpleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fileCSimpleNameDataGridViewTextBoxColumn
            // 
            this.fileCSimpleNameDataGridViewTextBoxColumn.DataPropertyName = "FileCSimpleName";
            this.fileCSimpleNameDataGridViewTextBoxColumn.HeaderText = "FileCSimpleName";
            this.fileCSimpleNameDataGridViewTextBoxColumn.Name = "fileCSimpleNameDataGridViewTextBoxColumn";
            this.fileCSimpleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Trasform
            // 
            this.Trasform.DataPropertyName = "CheckedForTransformation";
            this.Trasform.HeaderText = "Eseguire Trasformazione";
            this.Trasform.Name = "Trasform";
            this.Trasform.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // fileMatchedBindingSource
            // 
            this.fileMatchedBindingSource.DataSource = typeof(TransformationDePascalAC.model.FileMatched);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(12, 16);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(194, 13);
            this.lblC.TabIndex = 8;
            this.lblC.Text = "Selezionare cartella contenente files C#";
            // 
            // lblPascal
            // 
            this.lblPascal.AutoSize = true;
            this.lblPascal.Location = new System.Drawing.Point(9, 65);
            this.lblPascal.Name = "lblPascal";
            this.lblPascal.Size = new System.Drawing.Size(212, 13);
            this.lblPascal.TabIndex = 9;
            this.lblPascal.Text = "Selezionare cartella contenente files Pascal";
            // 
            // btntrasform
            // 
            this.btntrasform.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btntrasform.Location = new System.Drawing.Point(120, 450);
            this.btntrasform.Name = "btntrasform";
            this.btntrasform.Size = new System.Drawing.Size(152, 30);
            this.btntrasform.TabIndex = 10;
            this.btntrasform.Text = "Eseguire Trasformazione";
            this.btntrasform.UseVisualStyleBackColor = true;
            this.btntrasform.Click += new System.EventHandler(this.btntrasform_Click);
            // 
            // selectAllChkBox
            // 
            this.selectAllChkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectAllChkBox.AutoSize = true;
            this.selectAllChkBox.Location = new System.Drawing.Point(354, 439);
            this.selectAllChkBox.Name = "selectAllChkBox";
            this.selectAllChkBox.Size = new System.Drawing.Size(94, 17);
            this.selectAllChkBox.TabIndex = 11;
            this.selectAllChkBox.Text = "seleziona tutto";
            this.selectAllChkBox.UseVisualStyleBackColor = true;
            this.selectAllChkBox.CheckedChanged += new System.EventHandler(this.selectAllChkBox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operazioniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(452, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operazioniToolStripMenuItem
            // 
            this.operazioniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generatoreCodiceToolStripMenuItem,
            this.esciToolStripMenuItem});
            this.operazioniToolStripMenuItem.Name = "operazioniToolStripMenuItem";
            this.operazioniToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.operazioniToolStripMenuItem.Text = "Operazioni";
            // 
            // generatoreCodiceToolStripMenuItem
            // 
            this.generatoreCodiceToolStripMenuItem.Name = "generatoreCodiceToolStripMenuItem";
            this.generatoreCodiceToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.generatoreCodiceToolStripMenuItem.Text = "Generatore Codice";
            this.generatoreCodiceToolStripMenuItem.Click += new System.EventHandler(this.generatoreCodiceToolStripMenuItem_Click);
            // 
            // esciToolStripMenuItem
            // 
            this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
            this.esciToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.esciToolStripMenuItem.Text = "Esci";
            this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
            // 
            // pnTrasformDefBDD
            // 
            this.pnTrasformDefBDD.BackColor = System.Drawing.Color.Transparent;
            this.pnTrasformDefBDD.Controls.Add(this.lbDest);
            this.pnTrasformDefBDD.Controls.Add(this.txtDest);
            this.pnTrasformDefBDD.Controls.Add(this.btnDest);
            this.pnTrasformDefBDD.Controls.Add(this.btntrasform);
            this.pnTrasformDefBDD.Controls.Add(this.lblPascal);
            this.pnTrasformDefBDD.Controls.Add(this.lblC);
            this.pnTrasformDefBDD.Controls.Add(this.gridViewFileMatched);
            this.pnTrasformDefBDD.Controls.Add(this.btnRunMatch);
            this.pnTrasformDefBDD.Controls.Add(this.txtCSharp);
            this.pnTrasformDefBDD.Controls.Add(this.btnSelezionaC);
            this.pnTrasformDefBDD.Controls.Add(this.txtPascal);
            this.pnTrasformDefBDD.Controls.Add(this.btnSelezionaP);
            this.pnTrasformDefBDD.Controls.Add(this.selectAllChkBox);
            this.pnTrasformDefBDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTrasformDefBDD.Location = new System.Drawing.Point(0, 24);
            this.pnTrasformDefBDD.Name = "pnTrasformDefBDD";
            this.pnTrasformDefBDD.Size = new System.Drawing.Size(452, 484);
            this.pnTrasformDefBDD.TabIndex = 13;
            // 
            // lbDest
            // 
            this.lbDest.AutoSize = true;
            this.lbDest.Location = new System.Drawing.Point(12, 126);
            this.lbDest.Name = "lbDest";
            this.lbDest.Size = new System.Drawing.Size(313, 13);
            this.lbDest.TabIndex = 14;
            this.lbDest.Text = "Seleziona cartella di destinazione (lascia vuoto per sovrascrivere)";
            // 
            // txtDest
            // 
            this.txtDest.Location = new System.Drawing.Point(111, 144);
            this.txtDest.Name = "txtDest";
            this.txtDest.ReadOnly = true;
            this.txtDest.Size = new System.Drawing.Size(298, 20);
            this.txtDest.TabIndex = 13;
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(15, 142);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(75, 22);
            this.btnDest.TabIndex = 12;
            this.btnDest.Text = "Sfoglia";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // TransformCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 508);
            this.Controls.Add(this.pnTrasformDefBDD);
            this.Controls.Add(this.menuStrip1);
            this.Name = "TransformCode";
            this.Text = "Trasforma Codice";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFileMatched)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileMatchedBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnTrasformDefBDD.ResumeLayout(false);
            this.pnTrasformDefBDD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileC;
        private System.Windows.Forms.TextBox txtPascal;
        private System.Windows.Forms.Button btnSelezionaP;
        private System.Windows.Forms.FolderBrowserDialog folderSource;
        private System.Windows.Forms.TextBox txtCSharp;
        private System.Windows.Forms.Button btnSelezionaC;
        private System.Windows.Forms.Button btnRunMatch;
        private System.Windows.Forms.DataGridView gridViewFileMatched;
        private System.Windows.Forms.BindingSource fileMatchedBindingSource;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblPascal;
        private System.Windows.Forms.Button btntrasform;
        private System.Windows.Forms.DataGridViewTextBoxColumn filePascalSimpleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileCSimpleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Trasform;
        private System.Windows.Forms.CheckBox selectAllChkBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operazioniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generatoreCodiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
        private System.Windows.Forms.Panel pnTrasformDefBDD;
        private System.Windows.Forms.Label lbDest;
        private System.Windows.Forms.TextBox txtDest;
        private System.Windows.Forms.Button btnDest;
    }
}

