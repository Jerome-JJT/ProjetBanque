﻿namespace ProjetBanque
{
    partial class FrmProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProfil));
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordVerify = new System.Windows.Forms.TextBox();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblNewPasswordVerify = new System.Windows.Forms.Label();
            this.cmdChangePassword = new System.Windows.Forms.Button();
            this.lblDeleteAccount = new System.Windows.Forms.Label();
            this.cmdDeleteAccount = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Location = new System.Drawing.Point(53, 106);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(312, 20);
            this.txtOldPassword.TabIndex = 0;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(53, 152);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(312, 20);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // txtNewPasswordVerify
            // 
            this.txtNewPasswordVerify.Location = new System.Drawing.Point(53, 198);
            this.txtNewPasswordVerify.Name = "txtNewPasswordVerify";
            this.txtNewPasswordVerify.Size = new System.Drawing.Size(312, 20);
            this.txtNewPasswordVerify.TabIndex = 4;
            this.txtNewPasswordVerify.UseSystemPasswordChar = true;
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Location = new System.Drawing.Point(53, 87);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(133, 13);
            this.lblOldPassword.TabIndex = 5;
            this.lblOldPassword.Text = "Votre ancien mot de passe";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(53, 136);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(143, 13);
            this.lblNewPassword.TabIndex = 6;
            this.lblNewPassword.Text = "Votre nouveau mot de passe";
            // 
            // lblNewPasswordVerify
            // 
            this.lblNewPasswordVerify.AutoSize = true;
            this.lblNewPasswordVerify.Location = new System.Drawing.Point(53, 182);
            this.lblNewPasswordVerify.Name = "lblNewPasswordVerify";
            this.lblNewPasswordVerify.Size = new System.Drawing.Size(185, 13);
            this.lblNewPasswordVerify.TabIndex = 7;
            this.lblNewPasswordVerify.Text = "Vérification du nouveau mot de passe";
            // 
            // cmdChangePassword
            // 
            this.cmdChangePassword.Location = new System.Drawing.Point(53, 257);
            this.cmdChangePassword.Name = "cmdChangePassword";
            this.cmdChangePassword.Size = new System.Drawing.Size(312, 23);
            this.cmdChangePassword.TabIndex = 9;
            this.cmdChangePassword.Text = "Modifier mon mot de passe";
            this.cmdChangePassword.UseVisualStyleBackColor = true;
            this.cmdChangePassword.Click += new System.EventHandler(this.cmdChangePassword_Click);
            // 
            // lblDeleteAccount
            // 
            this.lblDeleteAccount.AutoSize = true;
            this.lblDeleteAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteAccount.Location = new System.Drawing.Point(88, 337);
            this.lblDeleteAccount.Name = "lblDeleteAccount";
            this.lblDeleteAccount.Size = new System.Drawing.Size(241, 26);
            this.lblDeleteAccount.TabIndex = 10;
            this.lblDeleteAccount.Text = "Suppression du compte";
            // 
            // cmdDeleteAccount
            // 
            this.cmdDeleteAccount.Location = new System.Drawing.Point(53, 382);
            this.cmdDeleteAccount.Name = "cmdDeleteAccount";
            this.cmdDeleteAccount.Size = new System.Drawing.Size(312, 23);
            this.cmdDeleteAccount.TabIndex = 12;
            this.cmdDeleteAccount.Text = "Supprimer mon compte";
            this.cmdDeleteAccount.UseVisualStyleBackColor = true;
            this.cmdDeleteAccount.Click += new System.EventHandler(this.cmdDeleteAccount_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(61, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(295, 26);
            this.lblTitle.TabIndex = 13;
            this.lblTitle.Text = "Modification du mot de passe";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(53, 221);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 14;
            // 
            // FrmProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmdDeleteAccount);
            this.Controls.Add(this.lblDeleteAccount);
            this.Controls.Add(this.cmdChangePassword);
            this.Controls.Add(this.lblNewPasswordVerify);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblOldPassword);
            this.Controls.Add(this.txtNewPasswordVerify);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(446, 489);
            this.MinimumSize = new System.Drawing.Size(446, 489);
            this.Name = "FrmProfil";
            this.Text = "Profil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPasswordVerify;
        private System.Windows.Forms.Label lblOldPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblNewPasswordVerify;
        private System.Windows.Forms.Button cmdChangePassword;
        private System.Windows.Forms.Label lblDeleteAccount;
        private System.Windows.Forms.Button cmdDeleteAccount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError;
    }
}