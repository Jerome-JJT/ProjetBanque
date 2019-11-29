﻿namespace ProjetBanque
{
    partial class formLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.cmdGoRegister = new System.Windows.Forms.Button();
            this.tmrPassword = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(216, 250);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(182, 41);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "Valider votre inscription";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(119, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(91, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Entrez votre email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(139, 181);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mot de passe";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(263, 47);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Login";
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleDescription = "";
            this.txtEmail.Location = new System.Drawing.Point(216, 123);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.Size = new System.Drawing.Size(205, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(216, 178);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(205, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(604, 47);
            this.lblError.TabIndex = 15;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdGoRegister
            // 
            this.cmdGoRegister.Location = new System.Drawing.Point(189, 311);
            this.cmdGoRegister.Name = "cmdGoRegister";
            this.cmdGoRegister.Size = new System.Drawing.Size(246, 23);
            this.cmdGoRegister.TabIndex = 7;
            this.cmdGoRegister.Text = "Vous n\'avez pas de compte? Inscrivez vous !";
            this.cmdGoRegister.UseVisualStyleBackColor = true;
            this.cmdGoRegister.Click += new System.EventHandler(this.cmdGoRegister_Click);
            // 
            // tmrPassword
            // 
            this.tmrPassword.Interval = 1000;
            this.tmrPassword.Tick += new System.EventHandler(this.tmrPassword_Tick);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 390);
            this.Controls.Add(this.cmdGoRegister);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.buttonLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button cmdGoRegister;
        private System.Windows.Forms.Timer tmrPassword;
        public System.Windows.Forms.TextBox txtPassword;
    }
}

