namespace ProjetBanque
{
    partial class FrmHomeAdmin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.datHistory = new System.Windows.Forms.DataGridView();
            this.datColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColNameReceiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdProfil = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchUser = new System.Windows.Forms.Label();
            this.cmdModifyPassword = new System.Windows.Forms.Button();
            this.tabDisplay = new System.Windows.Forms.TabControl();
            this.tabUsersHistory = new System.Windows.Forms.TabPage();
            this.tabAllUsers = new System.Windows.Forms.TabPage();
            this.datAllUsers = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Iban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdModifyMonney = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datHistory)).BeginInit();
            this.tabDisplay.SuspendLayout();
            this.tabUsersHistory.SuspendLayout();
            this.tabAllUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datAllUsers)).BeginInit();
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
            this.datHistory.Location = new System.Drawing.Point(3, 3);
            this.datHistory.Name = "datHistory";
            this.datHistory.RowHeadersVisible = false;
            this.datHistory.RowTemplate.Height = 42;
            this.datHistory.RowTemplate.ReadOnly = true;
            this.datHistory.Size = new System.Drawing.Size(556, 465);
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
            // cmdProfil
            // 
            this.cmdProfil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdProfil.Location = new System.Drawing.Point(633, 45);
            this.cmdProfil.Name = "cmdProfil";
            this.cmdProfil.Size = new System.Drawing.Size(73, 23);
            this.cmdProfil.TabIndex = 16;
            this.cmdProfil.Text = "Votre profil";
            this.cmdProfil.UseVisualStyleBackColor = true;
            this.cmdProfil.Click += new System.EventHandler(this.cmdProfil_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdExit.Location = new System.Drawing.Point(685, 521);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(114, 40);
            this.cmdExit.TabIndex = 18;
            this.cmdExit.Text = "Quitter";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.Location = new System.Drawing.Point(647, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(152, 33);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "lblEmail";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(562, 20);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearchUser
            // 
            this.lblSearchUser.AutoSize = true;
            this.lblSearchUser.Location = new System.Drawing.Point(16, 29);
            this.lblSearchUser.Name = "lblSearchUser";
            this.lblSearchUser.Size = new System.Drawing.Size(244, 13);
            this.lblSearchUser.TabIndex = 24;
            this.lblSearchUser.Text = "Tapez ici pour rechercher un utilisateur ou un Iban";
            // 
            // cmdModifyPassword
            // 
            this.cmdModifyPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdModifyPassword.Location = new System.Drawing.Point(633, 93);
            this.cmdModifyPassword.Name = "cmdModifyPassword";
            this.cmdModifyPassword.Size = new System.Drawing.Size(114, 39);
            this.cmdModifyPassword.TabIndex = 25;
            this.cmdModifyPassword.Text = "Modifier mot de passe utilisateur";
            this.cmdModifyPassword.UseVisualStyleBackColor = true;
            this.cmdModifyPassword.Click += new System.EventHandler(this.cmdModifyPassword_Click);
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.tabUsersHistory);
            this.tabDisplay.Controls.Add(this.tabAllUsers);
            this.tabDisplay.Location = new System.Drawing.Point(8, 71);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.SelectedIndex = 0;
            this.tabDisplay.Size = new System.Drawing.Size(570, 490);
            this.tabDisplay.TabIndex = 26;
            // 
            // tabUsersHistory
            // 
            this.tabUsersHistory.Controls.Add(this.datHistory);
            this.tabUsersHistory.Location = new System.Drawing.Point(4, 22);
            this.tabUsersHistory.Name = "tabUsersHistory";
            this.tabUsersHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsersHistory.Size = new System.Drawing.Size(562, 464);
            this.tabUsersHistory.TabIndex = 0;
            this.tabUsersHistory.Text = "Transaction";
            this.tabUsersHistory.UseVisualStyleBackColor = true;
            // 
            // tabAllUsers
            // 
            this.tabAllUsers.Controls.Add(this.datAllUsers);
            this.tabAllUsers.Location = new System.Drawing.Point(4, 22);
            this.tabAllUsers.Name = "tabAllUsers";
            this.tabAllUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabAllUsers.Size = new System.Drawing.Size(562, 464);
            this.tabAllUsers.TabIndex = 1;
            this.tabAllUsers.Text = "Tous les utilisateurs";
            this.tabAllUsers.UseVisualStyleBackColor = true;
            // 
            // datAllUsers
            // 
            this.datAllUsers.AllowUserToAddRows = false;
            this.datAllUsers.AllowUserToDeleteRows = false;
            this.datAllUsers.AllowUserToResizeColumns = false;
            this.datAllUsers.AllowUserToResizeRows = false;
            this.datAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datAllUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Iban,
            this.colMonney});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datAllUsers.DefaultCellStyle = dataGridViewCellStyle2;
            this.datAllUsers.Location = new System.Drawing.Point(3, 0);
            this.datAllUsers.Name = "datAllUsers";
            this.datAllUsers.RowHeadersVisible = false;
            this.datAllUsers.RowTemplate.Height = 42;
            this.datAllUsers.RowTemplate.ReadOnly = true;
            this.datAllUsers.Size = new System.Drawing.Size(559, 461);
            this.datAllUsers.TabIndex = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Iban
            // 
            this.Iban.HeaderText = "Iban";
            this.Iban.Name = "Iban";
            // 
            // colMonney
            // 
            this.colMonney.HeaderText = "Argent";
            this.colMonney.Name = "colMonney";
            // 
            // cmdModifyMonney
            // 
            this.cmdModifyMonney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdModifyMonney.Location = new System.Drawing.Point(633, 161);
            this.cmdModifyMonney.Name = "cmdModifyMonney";
            this.cmdModifyMonney.Size = new System.Drawing.Size(114, 39);
            this.cmdModifyMonney.TabIndex = 27;
            this.cmdModifyMonney.Text = "Modifier argent utilisateur";
            this.cmdModifyMonney.UseVisualStyleBackColor = true;
            this.cmdModifyMonney.Click += new System.EventHandler(this.cmdModifyMonney_Click);
            // 
            // FrmHomeAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 573);
            this.Controls.Add(this.cmdModifyMonney);
            this.Controls.Add(this.tabDisplay);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearchUser);
            this.Controls.Add(this.cmdModifyPassword);
            this.Controls.Add(this.cmdProfil);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.lblEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(827, 612);
            this.MinimumSize = new System.Drawing.Size(827, 612);
            this.Name = "FrmHomeAdmin";
            this.Text = "Accueil Administrateur";
            ((System.ComponentModel.ISupportInitialize)(this.datHistory)).EndInit();
            this.tabDisplay.ResumeLayout(false);
            this.tabUsersHistory.ResumeLayout(false);
            this.tabAllUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datAllUsers)).EndInit();
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
        private System.Windows.Forms.Button cmdProfil;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearchUser;
        private System.Windows.Forms.Button cmdModifyPassword;
        private System.Windows.Forms.TabControl tabDisplay;
        private System.Windows.Forms.TabPage tabUsersHistory;
        private System.Windows.Forms.TabPage tabAllUsers;
        private System.Windows.Forms.DataGridView datAllUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Iban;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonney;
        private System.Windows.Forms.Button cmdModifyMonney;
    }
}