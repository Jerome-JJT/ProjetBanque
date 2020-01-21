namespace ProjetBanque
{
    partial class FrmAdminMoneyChanger
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
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.cmdChangePassword = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.updAmount = new System.Windows.Forms.NumericUpDown();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(53, 121);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(312, 20);
            this.txtUserEmail.TabIndex = 0;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(53, 102);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(205, 13);
            this.lblUserEmail.TabIndex = 5;
            this.lblUserEmail.Text = "Email de l\'utilisateur à qui changer le solde";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(50, 149);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(79, 13);
            this.lblNewPassword.TabIndex = 6;
            this.lblNewPassword.Text = "Nouveau solde";
            // 
            // cmdChangePassword
            // 
            this.cmdChangePassword.Location = new System.Drawing.Point(53, 227);
            this.cmdChangePassword.Name = "cmdChangePassword";
            this.cmdChangePassword.Size = new System.Drawing.Size(312, 23);
            this.cmdChangePassword.TabIndex = 9;
            this.cmdChangePassword.Text = "Modifier le solde";
            this.cmdChangePassword.UseVisualStyleBackColor = true;
            this.cmdChangePassword.Click += new System.EventHandler(this.cmdChangePassword_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(69, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(274, 55);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Modifier le solde d\'un utilisateur";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // updAmount
            // 
            this.updAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.updAmount.DecimalPlaces = 2;
            this.updAmount.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.updAmount.Location = new System.Drawing.Point(53, 165);
            this.updAmount.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.updAmount.Name = "updAmount";
            this.updAmount.Size = new System.Drawing.Size(312, 20);
            this.updAmount.TabIndex = 14;
            this.updAmount.ThousandsSeparator = true;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(53, 188);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(58, 13);
            this.lblError.TabIndex = 15;
            this.lblError.Text = "                 ";
            // 
            // FrmAdminMoneyChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 297);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.updAmount);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmdChangePassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.txtUserEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminMoneyChanger";
            this.Text = "Profil";
            ((System.ComponentModel.ISupportInitialize)(this.updAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button cmdChangePassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.NumericUpDown updAmount;
        private System.Windows.Forms.Label lblError;
    }
}