namespace ProjetBanque
{
    partial class FrmListManagement
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
            this.lstList = new System.Windows.Forms.ListBox();
            this.cmdListToDelete = new System.Windows.Forms.Button();
            this.cmdAddToList = new System.Windows.Forms.Button();
            this.lblNameList = new System.Windows.Forms.Label();
            this.txtIban = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.cboList = new System.Windows.Forms.ComboBox();
            this.cmdAddList = new System.Windows.Forms.Button();
            this.cmdDeleteList = new System.Windows.Forms.Button();
            this.lblNameNewList = new System.Windows.Forms.Label();
            this.txtNameList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(12, 143);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(389, 277);
            this.lstList.TabIndex = 5;
            this.lstList.SelectedIndexChanged += new System.EventHandler(this.lstList_SelectedIndexChanged);
            // 
            // cmdListToDelete
            // 
            this.cmdListToDelete.Location = new System.Drawing.Point(12, 552);
            this.cmdListToDelete.Name = "cmdListToDelete";
            this.cmdListToDelete.Size = new System.Drawing.Size(389, 31);
            this.cmdListToDelete.TabIndex = 8;
            this.cmdListToDelete.Text = "Supprimer de la liste la personne selectionnée";
            this.cmdListToDelete.UseVisualStyleBackColor = true;
            this.cmdListToDelete.Click += new System.EventHandler(this.cmdListToDelete_Click);
            // 
            // cmdAddToList
            // 
            this.cmdAddToList.Location = new System.Drawing.Point(12, 512);
            this.cmdAddToList.Name = "cmdAddToList";
            this.cmdAddToList.Size = new System.Drawing.Size(389, 25);
            this.cmdAddToList.TabIndex = 7;
            this.cmdAddToList.Text = "Ajouter a la liste";
            this.cmdAddToList.UseVisualStyleBackColor = true;
            this.cmdAddToList.Click += new System.EventHandler(this.cmdAddToList_Click);
            // 
            // lblNameList
            // 
            this.lblNameList.AutoSize = true;
            this.lblNameList.Location = new System.Drawing.Point(12, 69);
            this.lblNameList.Name = "lblNameList";
            this.lblNameList.Size = new System.Drawing.Size(34, 13);
            this.lblNameList.TabIndex = 5;
            this.lblNameList.Text = "Listes";
            // 
            // txtIban
            // 
            this.txtIban.Location = new System.Drawing.Point(12, 453);
            this.txtIban.Name = "txtIban";
            this.txtIban.Size = new System.Drawing.Size(389, 20);
            this.txtIban.TabIndex = 6;
            this.txtIban.TextChanged += new System.EventHandler(this.txtIban_TextChanged);
            this.txtIban.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIban_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IBAN de la personne à ajouter";
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Location = new System.Drawing.Point(15, 480);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(0, 13);
            this.lblNameUser.TabIndex = 9;
            // 
            // cboList
            // 
            this.cboList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboList.FormattingEnabled = true;
            this.cboList.Location = new System.Drawing.Point(12, 85);
            this.cboList.Name = "cboList";
            this.cboList.Size = new System.Drawing.Size(389, 21);
            this.cboList.TabIndex = 3;
            this.cboList.SelectedIndexChanged += new System.EventHandler(this.cboList_SelectedIndexChanged);
            // 
            // cmdAddList
            // 
            this.cmdAddList.Location = new System.Drawing.Point(254, 49);
            this.cmdAddList.Name = "cmdAddList";
            this.cmdAddList.Size = new System.Drawing.Size(147, 23);
            this.cmdAddList.TabIndex = 2;
            this.cmdAddList.Text = "Ajouter une nouvelle liste";
            this.cmdAddList.UseVisualStyleBackColor = true;
            this.cmdAddList.Click += new System.EventHandler(this.cmdAddList_Click);
            // 
            // cmdDeleteList
            // 
            this.cmdDeleteList.Location = new System.Drawing.Point(229, 114);
            this.cmdDeleteList.Name = "cmdDeleteList";
            this.cmdDeleteList.Size = new System.Drawing.Size(172, 23);
            this.cmdDeleteList.TabIndex = 4;
            this.cmdDeleteList.Text = "Supprimez la liste selectionéee";
            this.cmdDeleteList.UseVisualStyleBackColor = true;
            this.cmdDeleteList.Click += new System.EventHandler(this.cmdDeleteList_Click);
            // 
            // lblNameNewList
            // 
            this.lblNameNewList.AutoSize = true;
            this.lblNameNewList.Location = new System.Drawing.Point(12, 7);
            this.lblNameNewList.Name = "lblNameNewList";
            this.lblNameNewList.Size = new System.Drawing.Size(119, 13);
            this.lblNameNewList.TabIndex = 13;
            this.lblNameNewList.Text = "Nom de la nouvelle liste";
            // 
            // txtNameList
            // 
            this.txtNameList.Location = new System.Drawing.Point(12, 23);
            this.txtNameList.Name = "txtNameList";
            this.txtNameList.Size = new System.Drawing.Size(389, 20);
            this.txtNameList.TabIndex = 1;
            this.txtNameList.TextChanged += new System.EventHandler(this.txtNameList_TextChanged);
            // 
            // FrmListManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 599);
            this.Controls.Add(this.txtNameList);
            this.Controls.Add(this.lblNameNewList);
            this.Controls.Add(this.cmdDeleteList);
            this.Controls.Add(this.cmdAddList);
            this.Controls.Add(this.cboList);
            this.Controls.Add(this.lblNameUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIban);
            this.Controls.Add(this.lblNameList);
            this.Controls.Add(this.cmdAddToList);
            this.Controls.Add(this.cmdListToDelete);
            this.Controls.Add(this.lstList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmListManagement";
            this.Text = "Gestion de liste";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.Button cmdListToDelete;
        private System.Windows.Forms.Button cmdAddToList;
        private System.Windows.Forms.Label lblNameList;
        private System.Windows.Forms.TextBox txtIban;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.ComboBox cboList;
        private System.Windows.Forms.Button cmdAddList;
        private System.Windows.Forms.Button cmdDeleteList;
        private System.Windows.Forms.Label lblNameNewList;
        private System.Windows.Forms.TextBox txtNameList;
    }
}