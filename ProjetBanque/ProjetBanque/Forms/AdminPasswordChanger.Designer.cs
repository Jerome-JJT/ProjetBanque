namespace ProjetBanque
{
    partial class FrmAdminPasswordChanger
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
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordVerify = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewPasswordVerify = new System.Windows.Forms.Label();
            this.cmdChangePassword = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(53, 121);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(312, 20);
            this.txtUserEmail.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(53, 167);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(312, 20);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPasswordVerify
            // 
            this.txtNewPasswordVerify.Location = new System.Drawing.Point(53, 213);
            this.txtNewPasswordVerify.Name = "txtNewPasswordVerify";
            this.txtNewPasswordVerify.Size = new System.Drawing.Size(312, 20);
            this.txtNewPasswordVerify.TabIndex = 4;
            this.txtNewPasswordVerify.UseSystemPasswordChar = true;
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(53, 102);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(243, 13);
            this.lblUserEmail.TabIndex = 5;
            this.lblUserEmail.Text = "Email de l\'utilisateur à qui changer le mot de passe";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(53, 151);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(117, 13);
            this.lblNewPassword.TabIndex = 6;
            this.lblNewPassword.Text = "Nouveau mot de passe";
            // 
            // lblNewPasswordVerify
            // 
            this.lblNewPasswordVerify.AutoSize = true;
            this.lblNewPasswordVerify.Location = new System.Drawing.Point(53, 197);
            this.lblNewPasswordVerify.Name = "lblNewPasswordVerify";
            this.lblNewPasswordVerify.Size = new System.Drawing.Size(185, 13);
            this.lblNewPasswordVerify.TabIndex = 7;
            this.lblNewPasswordVerify.Text = "Vérification du nouveau mot de passe";
            // 
            // cmdChangePassword
            // 
            this.cmdChangePassword.Location = new System.Drawing.Point(53, 272);
            this.cmdChangePassword.Name = "cmdChangePassword";
            this.cmdChangePassword.Size = new System.Drawing.Size(312, 23);
            this.cmdChangePassword.TabIndex = 9;
            this.cmdChangePassword.Text = "Modifier le mot de passe";
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
            this.lblTitle.Text = "Modifier le mot de passe d\'un utilisateur";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(53, 236);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(58, 13);
            this.lblError.TabIndex = 14;
            this.lblError.Text = "                 ";
            // 
            // FrmAdminPasswordChanger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 345);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmdChangePassword);
            this.Controls.Add(this.lblNewPasswordVerify);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.txtNewPasswordVerify);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtUserEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminPasswordChanger";
            this.Text = "Profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPasswordVerify;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblNewPasswordVerify;
        private System.Windows.Forms.Button cmdChangePassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError;
    }
}