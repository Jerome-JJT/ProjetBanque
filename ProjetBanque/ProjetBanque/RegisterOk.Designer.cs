namespace ProjetBanque
{
    partial class formRegisterOk
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
            this.buttonRegisterOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRegisterOk
            // 
            this.buttonRegisterOk.Location = new System.Drawing.Point(164, 176);
            this.buttonRegisterOk.Name = "buttonRegisterOk";
            this.buttonRegisterOk.Size = new System.Drawing.Size(182, 41);
            this.buttonRegisterOk.TabIndex = 7;
            this.buttonRegisterOk.Text = "Connectez-vous";
            this.buttonRegisterOk.UseVisualStyleBackColor = true;
            this.buttonRegisterOk.Click += new System.EventHandler(this.buttonRegisterOk_Click);
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
            // formRegisterOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 295);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRegisterOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formRegisterOk";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "RegisterOk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegisterOk;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblEmail;
    }
}