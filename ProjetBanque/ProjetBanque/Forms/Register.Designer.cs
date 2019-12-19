namespace ProjetBanque
{
    partial class FrmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegister));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRegisterTitle = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cmdRegister = new System.Windows.Forms.Button();
            this.txtPasswordVerify = new System.Windows.Forms.TextBox();
            this.lblPasswordVerify = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tmrPassword = new System.Windows.Forms.Timer(this.components);
            this.tmrPasswordVerify = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(217, 172);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(205, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.AccessibleDescription = "";
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtEmail.Location = new System.Drawing.Point(217, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.Size = new System.Drawing.Size(205, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // lblRegisterTitle
            // 
            this.lblRegisterTitle.AutoSize = true;
            this.lblRegisterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterTitle.Location = new System.Drawing.Point(235, 49);
            this.lblRegisterTitle.Name = "lblRegisterTitle";
            this.lblRegisterTitle.Size = new System.Drawing.Size(139, 31);
            this.lblRegisterTitle.TabIndex = 9;
            this.lblRegisterTitle.Text = "Inscription";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(140, 175);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 13);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Mot de passe";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(120, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(91, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Entrez votre email";
            // 
            // cmdRegister
            // 
            this.cmdRegister.Location = new System.Drawing.Point(217, 289);
            this.cmdRegister.Name = "cmdRegister";
            this.cmdRegister.Size = new System.Drawing.Size(182, 41);
            this.cmdRegister.TabIndex = 6;
            this.cmdRegister.Text = "Valider votre inscription";
            this.cmdRegister.UseVisualStyleBackColor = true;
            this.cmdRegister.Click += new System.EventHandler(this.cmdRegister_Click);
            // 
            // txtPasswordVerify
            // 
            this.txtPasswordVerify.Location = new System.Drawing.Point(217, 226);
            this.txtPasswordVerify.Name = "txtPasswordVerify";
            this.txtPasswordVerify.ShortcutsEnabled = false;
            this.txtPasswordVerify.Size = new System.Drawing.Size(205, 20);
            this.txtPasswordVerify.TabIndex = 3;
            this.txtPasswordVerify.TextChanged += new System.EventHandler(this.txtPasswordVerify_TextChanged);
            // 
            // lblPasswordVerify
            // 
            this.lblPasswordVerify.AutoSize = true;
            this.lblPasswordVerify.Location = new System.Drawing.Point(80, 229);
            this.lblPasswordVerify.Name = "lblPasswordVerify";
            this.lblPasswordVerify.Size = new System.Drawing.Size(131, 13);
            this.lblPasswordVerify.TabIndex = 12;
            this.lblPasswordVerify.Text = "Mot de passe (vérification)";
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(604, 49);
            this.lblError.TabIndex = 14;
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrPassword
            // 
            this.tmrPassword.Interval = 1000;
            this.tmrPassword.Tick += new System.EventHandler(this.tmrPassword_Tick);
            // 
            // tmrPasswordVerify
            // 
            this.tmrPasswordVerify.Interval = 1000;
            this.tmrPasswordVerify.Tick += new System.EventHandler(this.tmrPasswordVerify_Tick);
            // 
            // FrmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 392);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtPasswordVerify);
            this.Controls.Add(this.lblPasswordVerify);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblRegisterTitle);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.cmdRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRegister";
            this.Text = "Inscription";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRegisterTitle;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button cmdRegister;
        private System.Windows.Forms.TextBox txtPasswordVerify;
        private System.Windows.Forms.Label lblPasswordVerify;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer tmrPassword;
        private System.Windows.Forms.Timer tmrPasswordVerify;
    }
}