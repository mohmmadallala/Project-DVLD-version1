namespace Project_DVLD_version1.Licenses
{
    partial class FormShowLicenseInfo
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
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlShowLicense1 = new ctrlShowLicense(-1,false);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrlShowLicense1
            // 
            this.ctrlShowLicense1.Location = new System.Drawing.Point(12, 12);
            this.ctrlShowLicense1.Name = "ctrlShowLicense1";
            this.ctrlShowLicense1.Size = new System.Drawing.Size(924, 655);
            this.ctrlShowLicense1.TabIndex = 0;
            this.ctrlShowLicense1.textBox1Text = "";
            this.ctrlShowLicense1.Load += new System.EventHandler(this.ctrlShowLicense1_Load);
            // 
            // FormShowLicenseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 722);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrlShowLicense1);
            this.Name = "FormShowLicenseInfo";
            this.Text = "FormShowLicenseInfo";
            this.Load += new System.EventHandler(this.FormShowLicenseInfo_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlShowLicense ctrlShowLicense1;
        private System.Windows.Forms.Button button1;
    }
}