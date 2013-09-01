namespace TransformationDePascalAC
{
    partial class EnsembleCodeGenerator
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
            this.lbScript = new System.Windows.Forms.Label();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.btnSelezionaC = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gwProcedures = new System.Windows.Forms.DataGridView();
            this.btnSelectRows = new System.Windows.Forms.Button();
            this.gwSelectedRow = new System.Windows.Forms.DataGridView();
            this.colCoGe = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.colParams = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectProcedureBS = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtService = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gwProcedures)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwSelectedRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectProcedureBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbScript
            // 
            this.lbScript.AutoSize = true;
            this.lbScript.Location = new System.Drawing.Point(12, 9);
            this.lbScript.Name = "lbScript";
            this.lbScript.Size = new System.Drawing.Size(418, 13);
            this.lbScript.TabIndex = 11;
            this.lbScript.Text = "Seleziona lo script del package body contenente le procedure da cui generare il c" +
    "odice";
            // 
            // txtScript
            // 
            this.txtScript.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScript.Location = new System.Drawing.Point(108, 27);
            this.txtScript.Name = "txtScript";
            this.txtScript.ReadOnly = true;
            this.txtScript.Size = new System.Drawing.Size(423, 20);
            this.txtScript.TabIndex = 10;
            // 
            // btnSelezionaC
            // 
            this.btnSelezionaC.Location = new System.Drawing.Point(12, 25);
            this.btnSelezionaC.Name = "btnSelezionaC";
            this.btnSelezionaC.Size = new System.Drawing.Size(75, 22);
            this.btnSelezionaC.TabIndex = 9;
            this.btnSelezionaC.Text = "Sfoglia";
            this.btnSelezionaC.UseVisualStyleBackColor = true;
            this.btnSelezionaC.Click += new System.EventHandler(this.btnSelezionaC_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gwProcedures
            // 
            this.gwProcedures.AllowUserToAddRows = false;
            this.gwProcedures.AllowUserToDeleteRows = false;
            this.gwProcedures.AllowUserToOrderColumns = true;
            this.gwProcedures.AllowUserToResizeRows = false;
            this.gwProcedures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gwProcedures.AutoGenerateColumns = false;
            this.gwProcedures.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gwProcedures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwProcedures.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.gwProcedures.DataSource = this.procedureBindingSource;
            this.gwProcedures.Location = new System.Drawing.Point(13, 50);
            this.gwProcedures.Name = "gwProcedures";
            this.gwProcedures.ReadOnly = true;
            this.gwProcedures.RowHeadersVisible = false;
            this.gwProcedures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gwProcedures.Size = new System.Drawing.Size(518, 171);
            this.gwProcedures.TabIndex = 12;
            // 
            // btnSelectRows
            // 
            this.btnSelectRows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSelectRows.Location = new System.Drawing.Point(201, 227);
            this.btnSelectRows.Name = "btnSelectRows";
            this.btnSelectRows.Size = new System.Drawing.Size(116, 31);
            this.btnSelectRows.TabIndex = 13;
            this.btnSelectRows.Text = "Aggiungi procedure";
            this.btnSelectRows.UseVisualStyleBackColor = true;
            this.btnSelectRows.Click += new System.EventHandler(this.btnSelectRows_Click);
            // 
            // gwSelectedRow
            // 
            this.gwSelectedRow.AllowUserToAddRows = false;
            this.gwSelectedRow.AllowUserToDeleteRows = false;
            this.gwSelectedRow.AllowUserToOrderColumns = true;
            this.gwSelectedRow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gwSelectedRow.AutoGenerateColumns = false;
            this.gwSelectedRow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gwSelectedRow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gwSelectedRow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colCoGe,
            this.colParams});
            this.gwSelectedRow.DataSource = this.selectProcedureBS;
            this.gwSelectedRow.Location = new System.Drawing.Point(13, 277);
            this.gwSelectedRow.Name = "gwSelectedRow";
            this.gwSelectedRow.ReadOnly = true;
            this.gwSelectedRow.RowHeadersVisible = false;
            this.gwSelectedRow.Size = new System.Drawing.Size(520, 149);
            this.gwSelectedRow.TabIndex = 14;
            // 
            // colCoGe
            // 
            this.colCoGe.HeaderText = "Genera Codice per la procedura";
            this.colCoGe.Name = "colCoGe";
            this.colCoGe.ReadOnly = true;
            this.colCoGe.Width = 92;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.Location = new System.Drawing.Point(201, 479);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(116, 31);
            this.btnGenerate.TabIndex = 15;
            this.btnGenerate.Text = "Genera!!!";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // colParams
            // 
            this.colParams.DataPropertyName = "Identifier";
            this.colParams.HeaderText = "Genera Collected Params";
            this.colParams.Name = "colParams";
            this.colParams.ReadOnly = true;
            this.colParams.Width = 120;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // selectProcedureBS
            // 
            this.selectProcedureBS.DataSource = typeof(EnsembleCoGe.Procedure);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procedureBindingSource
            // 
            this.procedureBindingSource.DataSource = typeof(EnsembleCoGe.Procedure);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Inserisci il nome del servizio (DmService senza il \"Dm\")\r\n";
            // 
            // txtService
            // 
            this.txtService.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtService.Location = new System.Drawing.Point(317, 432);
            this.txtService.Name = "txtService";
            this.txtService.Size = new System.Drawing.Size(214, 20);
            this.txtService.TabIndex = 16;
            // 
            // EnsembleCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtService);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.gwSelectedRow);
            this.Controls.Add(this.btnSelectRows);
            this.Controls.Add(this.gwProcedures);
            this.Controls.Add(this.lbScript);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.btnSelezionaC);
            this.Name = "EnsembleCodeGenerator";
            this.Text = "EnsembleCodeGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.gwProcedures)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gwSelectedRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectProcedureBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procedureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbScript;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.Button btnSelezionaC;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView gwProcedures;
        private System.Windows.Forms.BindingSource procedureBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSelectRows;
        private System.Windows.Forms.DataGridView gwSelectedRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCoGe;
        private System.Windows.Forms.BindingSource selectProcedureBS;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtService;
    }
}