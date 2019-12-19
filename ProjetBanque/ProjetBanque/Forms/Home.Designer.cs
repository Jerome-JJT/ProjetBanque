namespace ProjetBanque
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.cmdPay = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblIbanPayement = new System.Windows.Forms.Label();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.cmdList = new System.Windows.Forms.Button();
            this.grpPayement = new System.Windows.Forms.GroupBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdProfil = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            this.datHistory = new System.Windows.Forms.DataGridView();
            this.datColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPayement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.Location = new System.Drawing.Point(586, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(152, 33);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "lblEmail";
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.Location = new System.Drawing.Point(624, 451);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(114, 40);
            this.cmdExit.TabIndex = 1;
            this.cmdExit.Text = "Quitter";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(97, 19);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(157, 20);
            this.txtIban.TabIndex = 2;
            // 
            // cmdPay
            // 
            this.cmdPay.Location = new System.Drawing.Point(12, 215);
            this.cmdPay.Name = "cmdPay";
            this.cmdPay.Size = new System.Drawing.Size(248, 23);
            this.cmdPay.TabIndex = 4;
            this.cmdPay.Text = "Payer";
            this.cmdPay.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(103, 124);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(157, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // lblIbanPayement
            // 
            this.lblIbanPayement.AutoSize = true;
            this.lblIbanPayement.Location = new System.Drawing.Point(6, 22);
            this.lblIbanPayement.Name = "lblIbanPayement";
            this.lblIbanPayement.Size = new System.Drawing.Size(85, 13);
            this.lblIbanPayement.TabIndex = 4;
            this.lblIbanPayement.Text = "Iban destinataire";
            // 
            // cboCompany
            // 
            this.cboCompany.Enabled = false;
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(15, 97);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(155, 21);
            this.cboCompany.TabIndex = 6;
            this.cboCompany.Text = "Liste entreprise";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(12, 127);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Montant";
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(103, 150);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(157, 59);
            this.txtReason.TabIndex = 9;
            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(12, 153);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(40, 13);
            this.lblReason.TabIndex = 10;
            this.lblReason.Text = "Raison";
            // 
            // cmdList
            // 
            this.cmdList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdList.Enabled = false;
            this.cmdList.Location = new System.Drawing.Point(176, 95);
            this.cmdList.Name = "cmdList";
            this.cmdList.Size = new System.Drawing.Size(73, 23);
            this.cmdList.TabIndex = 15;
            this.cmdList.Text = "Modifier liste";
            this.cmdList.UseVisualStyleBackColor = true;
            // 
            // grpPayement
            // 
            this.grpPayement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPayement.Controls.Add(this.cmdList);
            this.grpPayement.Controls.Add(this.lblReason);
            this.grpPayement.Controls.Add(this.txtReason);
            this.grpPayement.Controls.Add(this.lblAmount);
            this.grpPayement.Controls.Add(this.cboCompany);
            this.grpPayement.Controls.Add(this.lblIbanPayement);
            this.grpPayement.Controls.Add(this.txtAmount);
            this.grpPayement.Controls.Add(this.cmdPay);
            this.grpPayement.Controls.Add(this.txtIban);
            this.grpPayement.Location = new System.Drawing.Point(478, 186);
            this.grpPayement.Name = "grpPayement";
            this.grpPayement.Size = new System.Drawing.Size(260, 249);
            this.grpPayement.TabIndex = 5;
            this.grpPayement.TabStop = false;
            this.grpPayement.Text = "Payements";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(12, 74);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(139, 31);
            this.lblBalance.TabIndex = 11;
            this.lblBalance.Text = "lblBalance";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "lblIban";
            // 
            // cmdProfil
            // 
            this.cmdProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdProfil.Location = new System.Drawing.Point(575, 84);
            this.cmdProfil.Name = "cmdProfil";
            this.cmdProfil.Size = new System.Drawing.Size(73, 23);
            this.cmdProfil.TabIndex = 11;
            this.cmdProfil.Text = "Votre profil";
            this.cmdProfil.UseVisualStyleBackColor = true;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(12, 170);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(131, 13);
            this.lblHistory.TabIndex = 13;
            this.lblHistory.Text = "Historique des payements:";
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
            this.datColAmount,
            this.datColReason,
            this.datColDate});
            this.datHistory.Location = new System.Drawing.Point(12, 186);
            this.datHistory.Name = "datHistory";
            this.datHistory.RowHeadersVisible = false;
            this.datHistory.RowTemplate.ReadOnly = true;
            this.datHistory.Size = new System.Drawing.Size(430, 249);
            this.datHistory.TabIndex = 14;
            // 
            // datColName
            // 
            this.datColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datColName.HeaderText = "Nom / Iban(Destinataire)";
            this.datColName.Name = "datColName";
            this.datColName.Width = 135;
            // 
            // datColAmount
            // 
            this.datColAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datColAmount.HeaderText = "Montant";
            this.datColAmount.Name = "datColAmount";
            this.datColAmount.Width = 71;
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
            this.datColDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datColDate.HeaderText = "Date";
            this.datColDate.Name = "datColDate";
            this.datColDate.Width = 55;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 503);
            this.Controls.Add(this.datHistory);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.cmdProfil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.grpPayement);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(766, 542);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.grpPayement.ResumeLayout(false);
            this.grpPayement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdExit;
        public System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomIbanDestinataire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Button cmdPay;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblIbanPayement;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.Button cmdList;
        private System.Windows.Forms.GroupBox grpPayement;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdProfil;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView datHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColDate;
    }
}