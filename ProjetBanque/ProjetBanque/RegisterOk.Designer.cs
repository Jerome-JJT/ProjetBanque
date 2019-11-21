namespace ProjetBanque
{
    partial class RegisterOk
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
            this.label1 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email, vous êtes bien incrit-e";
            // 
            // RegisterOk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 296);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRegisterOk);
            this.Name = "RegisterOk";
            this.Text = "RegisterOk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegisterOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}