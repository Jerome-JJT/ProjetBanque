namespace ProjetBanque
{
    partial class ListManagement
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
            this.lblNameListChangement = new System.Windows.Forms.Label();
            this.txtNameList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(17, 152);
            this.lstList.Name = "lstList";
            this.lstList.Size = new System.Drawing.Size(389, 277);
            this.lstList.TabIndex = 1;
            // 
            // cmdListToDelete
            // 
            this.cmdListToDelete.Location = new System.Drawing.Point(12, 552);
            this.cmdListToDelete.Name = "cmdListToDelete";
            this.cmdListToDelete.Size = new System.Drawing.Size(389, 31);
            this.cmdListToDelete.TabIndex = 2;
            this.cmdListToDelete.Text = "Supprimer de la liste la personne selectionnée";
            this.cmdListToDelete.UseVisualStyleBackColor = true;
            this.cmdListToDelete.Click += new System.EventHandler(this.cmdListToDelete_Click);
            // 
            // cmdAddToList
            // 
            this.cmdAddToList.Location = new System.Drawing.Point(12, 512);
            this.cmdAddToList.Name = "cmdAddToList";
            this.cmdAddToList.Size = new System.Drawing.Size(389, 25);
            this.cmdAddToList.TabIndex = 4;
            this.cmdAddToList.Text = "Ajouter a la liste";
            this.cmdAddToList.UseVisualStyleBackColor = true;
            this.cmdAddToList.Click += new System.EventHandler(this.cmdAddToList_Click);
            // 
            // lblNameList
            // 
            this.lblNameList.AutoSize = true;
            this.lblNameList.Location = new System.Drawing.Point(14, 49);
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
            this.txtIban.TabIndex = 7;
            this.txtIban.TextChanged += new System.EventHandler(this.txtIban_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 432);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "IBAN de la personne à ajoutez";
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Location = new System.Drawing.Point(15, 480);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(35, 13);
            this.lblNameUser.TabIndex = 9;
            this.lblNameUser.Text = "label2";
            // 
            // cboList
            // 
            this.cboList.FormattingEnabled = true;
            this.cboList.Location = new System.Drawing.Point(12, 65);
            this.cboList.Name = "cboList";
            this.cboList.Size = new System.Drawing.Size(389, 21);
            this.cboList.TabIndex = 10;
            // 
            // cmdAddList
            // 
            this.cmdAddList.Location = new System.Drawing.Point(12, 12);
            this.cmdAddList.Name = "cmdAddList";
            this.cmdAddList.Size = new System.Drawing.Size(147, 23);
            this.cmdAddList.TabIndex = 11;
            this.cmdAddList.Text = "Ajouter une nouvelle liste";
            this.cmdAddList.UseVisualStyleBackColor = true;
            this.cmdAddList.Click += new System.EventHandler(this.cmdAddList_Click);
            // 
            // cmdDeleteList
            // 
            this.cmdDeleteList.Location = new System.Drawing.Point(229, 12);
            this.cmdDeleteList.Name = "cmdDeleteList";
            this.cmdDeleteList.Size = new System.Drawing.Size(172, 23);
            this.cmdDeleteList.TabIndex = 12;
            this.cmdDeleteList.Text = "Supprimez la liste selectionéee";
            this.cmdDeleteList.UseVisualStyleBackColor = true;
            this.cmdDeleteList.Click += new System.EventHandler(this.cmdDeleteList_Click);
            // 
            // lblNameListChangement
            // 
            this.lblNameListChangement.AutoSize = true;
            this.lblNameListChangement.Location = new System.Drawing.Point(12, 93);
            this.lblNameListChangement.Name = "lblNameListChangement";
            this.lblNameListChangement.Size = new System.Drawing.Size(76, 13);
            this.lblNameListChangement.TabIndex = 13;
            this.lblNameListChangement.Text = "Nom de la liste";
            // 
            // txtNameList
            // 
            this.txtNameList.Location = new System.Drawing.Point(12, 109);
            this.txtNameList.Name = "txtNameList";
            this.txtNameList.Size = new System.Drawing.Size(389, 20);
            this.txtNameList.TabIndex = 14;
            // 
            // ListManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 599);
            this.Controls.Add(this.txtNameList);
            this.Controls.Add(this.lblNameListChangement);
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
            this.Name = "ListManagement";
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
        private System.Windows.Forms.Label lblNameListChangement;
        private System.Windows.Forms.TextBox txtNameList;
    }
}