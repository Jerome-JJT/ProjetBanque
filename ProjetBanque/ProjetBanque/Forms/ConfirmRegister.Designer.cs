namespace ProjetBanque
{
    partial class FrmConfirmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmRegister));
            this.cmdBackLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdBackLogin
            // 
            this.cmdBackLogin.Location = new System.Drawing.Point(164, 176);
            this.cmdBackLogin.Name = "cmdBackLogin";
            this.cmdBackLogin.Size = new System.Drawing.Size(182, 41);
            this.cmdBackLogin.TabIndex = 7;
            this.cmdBackLogin.Text = "Connectez-vous";
            this.cmdBackLogin.UseVisualStyleBackColor = true;
            this.cmdBackLogin.Click += new System.EventHandler(this.cmdBackLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enregistrement validé";
            // 
            // lblEmail
            // 
            this.lblEmail.Location = new System.Drawing.Point(0, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(528, 22);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmConfirmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 295);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdBackLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConfirmRegister";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Confirmation enregistrement";
            this.Load += new System.EventHandler(this.FrmConfirmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdBackLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEmail;
    }
}