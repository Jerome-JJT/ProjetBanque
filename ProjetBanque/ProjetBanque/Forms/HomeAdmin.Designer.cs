namespace ProjetBanque.Forms
{
    partial class frmHomeAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datHistory = new System.Windows.Forms.DataGridView();
            this.datColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColNameReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblHistory = new System.Windows.Forms.Label();
            this.cmdProfil = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // datHistory
            // 
            this.datHistory.AllowUserToAddRows = false;
            this.datHistory.AllowUserToDeleteRows = false;
            this.datHistory.AllowUserToResizeColumns = false;
            this.datHistory.AllowUserToResizeRows = false;
            this.datHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.datColName,
            this.datColNameReceiver,
            this.datColAmount,
            this.datColReason,
            this.datColDate});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datHistory.DefaultCellStyle = dataGridViewCellStyle1;
            this.datHistory.Location = new System.Drawing.Point(36, 50);
            this.datHistory.Name = "datHistory";
            this.datHistory.RowHeadersVisible = false;
            this.datHistory.RowTemplate.Height = 42;
            this.datHistory.RowTemplate.ReadOnly = true;
            this.datHistory.Size = new System.Drawing.Size(555, 430);
            this.datHistory.TabIndex = 22;
            // 
            // datColName
            // 
            this.datColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.datColName.HeaderText = "Nom / Iban(Destinataire)";
            this.datColName.Name = "datColName";
            // 
            // datColNameReceiver
            // 
            this.datColNameReceiver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.datColNameReceiver.HeaderText = "Nom / Iban(Receveur)";
            this.datColNameReceiver.Name = "datColNameReceiver";
            this.datColNameReceiver.Width = 127;
            // 
            // datColAmount
            // 
            this.datColAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.datColAmount.HeaderText = "Montant";
            this.datColAmount.Name = "datColAmount";
            this.datColAmount.Width = 75;
            // 
            // datColReason
            // 
            this.datColReason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.datColReason.HeaderText = "Raison";
            this.datColReason.Name = "datColReason";
            this.datColReason.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // datColDate
            // 
            this.datColDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.datColDate.HeaderText = "Date";
            this.datColDate.Name = "datColDate";
            this.datColDate.Width = 110;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(33, 29);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(131, 13);
            this.lblHistory.TabIndex = 21;
            this.lblHistory.Text = "Historique des payements:";
            // 
            // cmdProfil
            // 
            this.cmdProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdProfil.Location = new System.Drawing.Point(736, 50);
            this.cmdProfil.Name = "cmdProfil";
            this.cmdProfil.Size = new System.Drawing.Size(73, 23);
            this.cmdProfil.TabIndex = 16;
            this.cmdProfil.Text = "Votre profil";
            this.cmdProfil.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.Location = new System.Drawing.Point(820, 521);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(114, 40);
            this.cmdExit.TabIndex = 18;
            this.cmdExit.Text = "Quitter";
            this.cmdExit.UseVisualStyleBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.Location = new System.Drawing.Point(758, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(152, 33);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "lblEmail";
            // 
            // frmHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 573);
            this.Controls.Add(this.datHistory);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.cmdProfil);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblEmail);
            this.Name = "frmHomeAdmin";
            this.Text = "Home Administrateur";
            ((System.ComponentModel.ISupportInitialize)(this.datHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColNameReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColDate;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button cmdProfil;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblEmail;
    }
}