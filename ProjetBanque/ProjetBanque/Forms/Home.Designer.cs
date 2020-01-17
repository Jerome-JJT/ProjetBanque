namespace ProjetBanque
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
            this.lblPayIban = new System.Windows.Forms.Label();
            this.cboPayList = new System.Windows.Forms.ComboBox();
            this.lblPayAmount = new System.Windows.Forms.Label();
            this.txtPayReason = new System.Windows.Forms.TextBox();
            this.lblPayReason = new System.Windows.Forms.Label();
            this.cmdModifyList = new System.Windows.Forms.Button();
            this.grpPayement = new System.Windows.Forms.GroupBox();
            this.lblListAmount = new System.Windows.Forms.Label();
            this.lblIbanFormat = new System.Windows.Forms.Label();
            this.updPayAmount = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.updPayAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.Location = new System.Drawing.Point(734, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(152, 33);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "lblEmail";
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.Location = new System.Drawing.Point(772, 576);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(114, 40);
            this.cmdExit.TabIndex = 7;
            this.cmdExit.Text = "Quitter";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // txtPayIban
            // 
            this.txtPayIban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayIban.Location = new System.Drawing.Point(113, 35);
            this.txtPayIban.Name = "txtPayIban";
            this.txtPayIban.Size = new System.Drawing.Size(170, 20);
            this.txtPayIban.TabIndex = 2;
            this.txtPayIban.TextChanged += new System.EventHandler(this.txtPayIban_TextChanged);
            // 
            // cmdPay
            // 
            this.cmdPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdPay.Enabled = false;
            this.cmdPay.Location = new System.Drawing.Point(13, 331);
            this.cmdPay.Name = "cmdPay";
            this.cmdPay.Size = new System.Drawing.Size(268, 33);
            this.cmdPay.TabIndex = 7;
            this.cmdPay.Text = "Payer";
            this.cmdPay.UseVisualStyleBackColor = true;
            this.cmdPay.Click += new System.EventHandler(this.cmdPay_Click);
            // 
            // lblPayIban
            // 
            this.lblPayIban.AutoSize = true;
            this.lblPayIban.Location = new System.Drawing.Point(12, 38);
            this.lblPayIban.Name = "lblPayIban";
            this.lblPayIban.Size = new System.Drawing.Size(85, 13);
            this.lblPayIban.TabIndex = 4;
            this.lblPayIban.Text = "Iban destinataire";
            // 
            // cboPayList
            // 
            this.cboPayList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboPayList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayList.Enabled = false;
            this.cboPayList.FormattingEnabled = true;
            this.cboPayList.Items.AddRange(new object[] {
            "Liste(s) de payements"});
            this.cboPayList.Location = new System.Drawing.Point(15, 98);
            this.cboPayList.Name = "cboPayList";
            this.cboPayList.Size = new System.Drawing.Size(184, 21);
            this.cboPayList.TabIndex = 3;
            this.cboPayList.SelectedIndexChanged += new System.EventHandler(this.cboPayList_SelectedIndexChanged);
            // 
            // lblPayAmount
            // 
            this.lblPayAmount.AutoSize = true;
            this.lblPayAmount.Location = new System.Drawing.Point(10, 156);
            this.lblPayAmount.Name = "lblPayAmount";
            this.lblPayAmount.Size = new System.Drawing.Size(46, 13);
            this.lblPayAmount.TabIndex = 8;
            this.lblPayAmount.Text = "Montant";
            // 
            // txtPayReason
            // 
            this.txtPayReason.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPayReason.Location = new System.Drawing.Point(15, 213);
            this.txtPayReason.Multiline = true;
            this.txtPayReason.Name = "txtPayReason";
            this.txtPayReason.Size = new System.Drawing.Size(268, 112);
            this.txtPayReason.TabIndex = 6;
            // 
            // lblPayReason
            // 
            this.lblPayReason.AutoSize = true;
            this.lblPayReason.Location = new System.Drawing.Point(12, 197);
            this.lblPayReason.Name = "lblPayReason";
            this.lblPayReason.Size = new System.Drawing.Size(40, 13);
            this.lblPayReason.TabIndex = 10;
            this.lblPayReason.Text = "Raison";
            // 
            // cmdModifyList
            // 
            this.cmdModifyList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdModifyList.Enabled = false;
            this.cmdModifyList.Location = new System.Drawing.Point(205, 96);
            this.cmdModifyList.Name = "cmdModifyList";
            this.cmdModifyList.Size = new System.Drawing.Size(73, 23);
            this.cmdModifyList.TabIndex = 4;
            this.cmdModifyList.Text = "Gérer liste";
            this.cmdModifyList.UseVisualStyleBackColor = true;
            this.cmdModifyList.Click += new System.EventHandler(this.cmdModifyList_Click);
            // 
            // grpPayement
            // 
            this.grpPayement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPayement.Controls.Add(this.lblListAmount);
            this.grpPayement.Controls.Add(this.lblIbanFormat);
            this.grpPayement.Controls.Add(this.updPayAmount);
            this.grpPayement.Controls.Add(this.lblEmailReceiver);
            this.grpPayement.Controls.Add(this.cmdModifyList);
            this.grpPayement.Controls.Add(this.lblPayReason);
            this.grpPayement.Controls.Add(this.txtPayReason);
            this.grpPayement.Controls.Add(this.lblPayAmount);
            this.grpPayement.Controls.Add(this.cboPayList);
            this.grpPayement.Controls.Add(this.lblPayIban);
            this.grpPayement.Controls.Add(this.cmdPay);
            this.grpPayement.Controls.Add(this.txtPayIban);
            this.grpPayement.Location = new System.Drawing.Point(599, 170);
            this.grpPayement.Name = "grpPayement";
            this.grpPayement.Size = new System.Drawing.Size(287, 375);
            this.grpPayement.TabIndex = 5;
            this.grpPayement.TabStop = false;
            this.grpPayement.Text = "Payement";
            // 
            // lblListAmount
            // 
            this.lblListAmount.AutoSize = true;
            this.lblListAmount.Location = new System.Drawing.Point(12, 133);
            this.lblListAmount.Name = "lblListAmount";
            this.lblListAmount.Size = new System.Drawing.Size(0, 13);
            this.lblListAmount.TabIndex = 19;
            // 
            // lblIbanFormat
            // 
            this.lblIbanFormat.AutoSize = true;
            this.lblIbanFormat.Location = new System.Drawing.Point(110, 19);
            this.lblIbanFormat.Name = "lblIbanFormat";
            this.lblIbanFormat.Size = new System.Drawing.Size(96, 13);
            this.lblIbanFormat.TabIndex = 18;
            this.lblIbanFormat.Text = "Format : CH00 000";
            // 
            // updPayAmount
            // 
            this.updPayAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updPayAmount.DecimalPlaces = 2;
            this.updPayAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updPayAmount.Location = new System.Drawing.Point(13, 174);
            this.updPayAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.updPayAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updPayAmount.Name = "updPayAmount";
            this.updPayAmount.Size = new System.Drawing.Size(268, 20);
            this.updPayAmount.TabIndex = 5;
            this.updPayAmount.ThousandsSeparator = true;
            this.updPayAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updPayAmount.ValueChanged += new System.EventHandler(this.updPayAmount_ValueChanged);
            // 
            // lblEmailReceiver
            // 
            this.lblEmailReceiver.Location = new System.Drawing.Point(15, 68);
            this.lblEmailReceiver.Name = "lblEmailReceiver";
            this.lblEmailReceiver.Size = new System.Drawing.Size(268, 27);
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
            this.lblIban.Location = new System.Drawing.Point(734, 42);
            this.lblIban.Name = "lblIban";
            this.lblIban.Size = new System.Drawing.Size(38, 13);
            this.lblIban.TabIndex = 12;
            this.lblIban.Text = "lblIban";
            // 
            // cmdProfil
            // 
            this.cmdProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdProfil.Location = new System.Drawing.Point(720, 62);
            this.cmdProfil.Name = "cmdProfil";
            this.cmdProfil.Size = new System.Drawing.Size(73, 23);
            this.cmdProfil.TabIndex = 1;
            this.cmdProfil.Text = "Votre profil";
            this.cmdProfil.UseVisualStyleBackColor = true;
            this.cmdProfil.Click += new System.EventHandler(this.cmdProfil_Click);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(12, 161);
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
            this.datHistory.Size = new System.Drawing.Size(555, 430);
            this.datHistory.TabIndex = 14;
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
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 628);
            this.Controls.Add(this.datHistory);
            this.Controls.Add(this.lblHistory);
            this.Controls.Add(this.cmdProfil);
            this.Controls.Add(this.lblIban);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.grpPayement);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblEmail);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(914, 622);
            this.Name = "FrmHome";
            this.Text = "Accueil";
            this.Load += new System.EventHandler(this.Home_Load);
            this.SizeChanged += new System.EventHandler(this.FrmHome_SizeChanged);
            this.grpPayement.ResumeLayout(false);
            this.grpPayement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updPayAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPayIban;
        private System.Windows.Forms.Button cmdPay;
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
        private System.Windows.Forms.NumericUpDown updPayAmount;
        private System.Windows.Forms.Label lblIbanFormat;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColNameReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn datColDate;
        private System.Windows.Forms.Label lblListAmount;
    }
}