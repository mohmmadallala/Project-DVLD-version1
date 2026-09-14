namespace Project_DVLD_version1
{
    partial class Form_show_info_user
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
            this.ctrl_info_user1 = new Project_DVLD_version1.ctrl_info_user();
            this.ctrl_show_Info_Person1 = new Project_DVLD_version1.ctrl_show_Info_Person();
            this.SuspendLayout();
            // 
            // ctrl_info_user1
            // 
            this.ctrl_info_user1.Location = new System.Drawing.Point(12, 365);
            this.ctrl_info_user1.Name = "ctrl_info_user1";
            this.ctrl_info_user1.Size = new System.Drawing.Size(756, 164);
            this.ctrl_info_user1.TabIndex = 0;
            // 
            // ctrl_show_Info_Person1
            // 
            this.ctrl_show_Info_Person1._ID = -1;
            this.ctrl_show_Info_Person1.Location = new System.Drawing.Point(12, 12);
            this.ctrl_show_Info_Person1.Name = "ctrl_show_Info_Person1";
            this.ctrl_show_Info_Person1.National = null;
            this.ctrl_show_Info_Person1.PathImage = null;
            this.ctrl_show_Info_Person1.showLinkEditPicture = false;
            this.ctrl_show_Info_Person1.Size = new System.Drawing.Size(1356, 404);
            this.ctrl_show_Info_Person1.TabIndex = 1;
            this.ctrl_show_Info_Person1.Load += new System.EventHandler(this.ctrl_show_Info_Person1_Load);
            // 
            // Form_show_info_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 593);
            this.Controls.Add(this.ctrl_show_Info_Person1);
            this.Controls.Add(this.ctrl_info_user1);
            this.Name = "Form_show_info_user";
            this.Text = "Form_show_info_user";
            this.Load += new System.EventHandler(this.Form_show_info_user_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrl_info_user ctrl_info_user1;
        private ctrl_show_Info_Person ctrl_show_Info_Person1;
    }
}