﻿namespace ProjetBanque
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmdExit = new System.Windows.Forms.Button();
            this.txtPayIban = new System.Windows.Forms.TextBox();
            this.cmdPay = new System.Windows.Forms.Button();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.lblPayIban = new System.Windows.Forms.Label();
            this.cboPayList = new System.Windows.Forms.ComboBox();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.txtPayReason = new System.Windows.Forms.TextBox();
            this.lblPayReason = new System.Windows.Forms.Label();
            this.cmdModifyList = new System.Windows.Forms.Button();
            this.grpPayement = new System.Windows.Forms.GroupBox();
            this.lblEmailReceiver = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblIban = new System.Windows.Forms.Label();
            this.cmdProfil = new System.Windows.Forms.Button();
            this.lblHistory = new System.Windows.Forms.Label();
            this.datHistory = new System.Windows.Forms.DataGridView();
            this.datColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColNameReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // txtPayIban
            // 
            this.txtPayIban.Location = new System.Drawing.Point(97, 19);
            this.txtPayIban.Name = "txtPayIban";
            this.txtPayIban.Size = new System.Drawing.Size(157, 20);
            this.txtPayIban.TabIndex = 2;
            this.txtPayIban.TextChanged += new System.EventHandler(this.txtPayIban_TextChanged);
            // 
            // cmdPay
            // 
            this.cmdPay.Enabled = false;
            this.cmdPay.Location = new System.Drawing.Point(12, 215);
            this.cmdPay.Name = "cmdPay";
            this.cmdPay.Size = new System.Drawing.Size(248, 23);
            this.cmdPay.TabIndex = 4;
            this.cmdPay.Text = "Payer";
            this.cmdPay.UseVisualStyleBackColor = true;
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(103, 124);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(157, 20);
            this.txtPayAmount.TabIndex = 5;
            // 
            // lblPayIban
            // 
            this.lblPayIban.AutoSize = true;
            this.lblPayIban.Location = new System.Drawing.Point(6, 22);
            this.lblPayIban.Name = "lblPayIban";
            this.lblPayIban.Size = new System.Drawing.Size(85, 13);
            this.lblPayIban.TabIndex = 4;
            this.lblPayIban.Text = "Iban destinataire";
            // 
            // cboPayList
            // 
            this.cboPayList.Enabled = false;
            this.cboPayList.FormattingEnabled = true;
            this.cboPayList.Location = new System.Drawing.Point(15, 97);
            this.cboPayList.Name = "cboPayList";
            this.cboPayList.Size = new System.Drawing.Size(155, 21);
            this.cboPayList.TabIndex = 6;
            this.cboPayList.Text = "Liste entreprise";
            // 
            // lblPayAmount
            // 
            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Location = new System.Drawing.Point(12, 127);
            this.lblPayAmount.Name = "lblPayAmount";
            this.lblPayAmount.Size = new System.Drawing.Size(46, 13);
            this.lblPayAmount.TabIndex = 8;
            this.lblPayAmount.Text = "Montant";
            // 
            // txtPayReason
            // 
            this.txtPayReason.Location = new System.Drawing.Point(103, 150);
            this.txtPayReason.Multiline = true;
            this.txtPayReason.Name = "txtPayReason";
            this.txtPayReason.Size = new System.Drawing.Size(157, 59);
            this.txtPayReason.TabIndex = 9;
            // 
            // lblPayReason
            // 
            this.lblPayReason.AutoSize = true;
            this.lblPayReason.Location = new System.Drawing.Point(12, 153);
            this.lblPayReason.Name = "lblPayReason";
            this.lblPayReason.Size = new System.Drawing.Size(40, 13);
            this.lblPayReason.TabIndex = 10;
            this.lblPayReason.Text = "Raison";
            // 
            // cmdModifyList
            // 
            this.cmdModifyList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdModifyList.Enabled = false;
            this.cmdModifyList.Location = new System.Drawing.Point(176, 95);
            this.cmdModifyList.Name = "cmdModifyList";
            this.cmdModifyList.Size = new System.Drawing.Size(73, 23);
            this.cmdModifyList.TabIndex = 15;
            this.cmdModifyList.Text = "Modifier liste";
            this.cmdModifyList.UseVisualStyleBackColor = true;
            // 
            // grpPayement
            // 
            this.grpPayement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPayement.Controls.Add(this.lblEmailReceiver);
            this.grpPayement.Controls.Add(this.cmdModifyList);
            this.grpPayement.Controls.Add(this.lblPayReason);
            this.grpPayement.Controls.Add(this.txtPayReason);
            this.grpPayement.Controls.Add(this.lblPayAmount);
            this.grpPayement.Controls.Add(this.cboPayList);
            this.grpPayement.Controls.Add(this.lblPayIban);
            this.grpPayement.Controls.Add(this.txtPayAmount);
            this.grpPayement.Controls.Add(this.cmdPay);
            this.grpPayement.Controls.Add(this.txtPayIban);
            this.grpPayement.Location = new System.Drawing.Point(478, 186);
            this.grpPayement.Name = "grpPayement";
            this.grpPayement.Size = new System.Drawing.Size(260, 249);
            this.grpPayement.TabIndex = 5;
            this.grpPayement.TabStop = false;
            this.grpPayement.Text = "Payements";
            // 
            // lblEmailReceiver
            // 
            this.lblEmailReceiver.AutoSize = true;
            this.lblEmailReceiver.Location = new System.Drawing.Point(6, 52);
            this.lblEmailReceiver.Name = "lblEmailReceiver";
            this.lblEmailReceiver.Size = new System.Drawing.Size(0, 13);
            this.lblEmailReceiver.TabIndex = 16;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(12, 74);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(122, 31);
            this.lblMoney.TabIndex = 11;
            this.lblMoney.Text = "lblMoney";
            // 
            // lblIban
            // 
            this.lblIban.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIban.AutoSize = true;
            this.lblIban.Location = new System.Drawing.Point(586, 42);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(38, 13);
            this.lblIban.TabIndex = 12;
            this.lblIban.Text = "lblIban";
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
            this.datHistory.Location = new System.Drawing.Point(12, 186);
            this.datHistory.Name = "datHistory";
            this.datHistory.RowHeadersVisible = false;
            this.datHistory.RowTemplate.Height = 42;
            this.datHistory.RowTemplate.ReadOnly = true;
            this.datHistory.Size = new System.Drawing.Size(450, 249);
            this.datHistory.TabIndex = 14;
            // 
            // datColName
            // 
            this.datColName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datColName.HeaderText = "Nom / Iban(Destinataire)";
            this.datColName.Name = "datColName";
            this.datColName.Width = 135;
            // 
            // datColNameReceiver
            // 
            this.datColNameReceiver.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datColNameReceiver.HeaderText = "Nom / Iban(Receveur)";
            this.datColNameReceiver.Name = "datColNameReceiver";
            this.datColNameReceiver.Width = 127;
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
            this.datColReason.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datColReason.HeaderText = "Raison";
            this.datColReason.Name = "datColReason";
            this.datColReason.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.datColReason.Width = 65;
            // 
            // datColDate
            // 
            this.datColDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.datColDate.HeaderText = "Date";
            this.datColDate.Name = "datColDate";
            this.datColDate.Width = 55;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 503);
            this.Controls.Add(this.datHistory);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.cmdProfil);
            this.Controls.Add(this.lblIban);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.grpPayement);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(766, 542);
            this.Name = "FrmHome";
            this.Text = "Accueil";
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
        private System.Windows.Forms.TextBox txtPayIban;
        private System.Windows.Forms.Button cmdPay;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label lblPayIban;
        private System.Windows.Forms.ComboBox cboPayList;
        private System.Windows.Forms.Label lblPayAmount;
        private System.Windows.Forms.TextBox txtPayReason;
        private System.Windows.Forms.Label lblPayReason;
        private System.Windows.Forms.Button cmdModifyList;
        private System.Windows.Forms.GroupBox grpPayement;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblIban;
        private System.Windows.Forms.Button cmdProfil;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.DataGridView datHistory;
        private System.Windows.Forms.Label lblEmailReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColNameReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColDate;
    }
}