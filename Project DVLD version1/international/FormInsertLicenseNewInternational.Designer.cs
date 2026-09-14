namespace Project_DVLD_version1.international
{
    partial class FormInsertLicenseNewInternational
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
            // ✅ استخدام المُنشئ الافتراضي
            this.ctrlShowInternationalLicense1 = new Project_DVLD_version1.international.ctrlShowInternationalLicense(-1,true,true);
            this.SuspendLayout();
            // 
            // ctrlShowInternationalLicense1
            // 
            this.ctrlShowInternationalLicense1.Location = new System.Drawing.Point(12, 12);
            this.ctrlShowInternationalLicense1.Name = "ctrlShowInternationalLicense1";
            this.ctrlShowInternationalLicense1.Size = new System.Drawing.Size(930, 820);
            this.ctrlShowInternationalLicense1.TabIndex = 0;
            // 
            // FormInsertLicenseNewInternational
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 854);
            this.Controls.Add(this.ctrlShowInternationalLicense1);
            this.Name = "FormInsertLicenseNewInternational";
            this.Text = "FormInsertLicenseNewInternational";
            this.Load += new System.EventHandler(this.FormInsertLicenseNewInternational_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowInternationalLicense ctrlShowInternationalLicense1;
    }
}