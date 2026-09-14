namespace Project_DVLD_version1.Application_Renew
{
    partial class FormApplicationRenewLicense
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
            this.ctrlApplicationRenewLicense1 = new Project_DVLD_version1.Application_Renew.ctrlApplicationRenewLicense();
            this.SuspendLayout();
            // 
            // ctrlApplicationRenewLicense1
            // 
            this.ctrlApplicationRenewLicense1.Location = new System.Drawing.Point(12, 12);
            this.ctrlApplicationRenewLicense1.Name = "ctrlApplicationRenewLicense1";
            this.ctrlApplicationRenewLicense1.Size = new System.Drawing.Size(1019, 815);
            this.ctrlApplicationRenewLicense1.TabIndex = 0;
            // 
            // FormApplicationRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 867);
            this.Controls.Add(this.ctrlApplicationRenewLicense1);
            this.Name = "FormApplicationRenewLicense";
            this.Text = "FormApplicationRenewLicense";
            this.Load += new System.EventHandler(this.FormApplicationRenewLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlApplicationRenewLicense ctrlApplicationRenewLicense1;
    }
}