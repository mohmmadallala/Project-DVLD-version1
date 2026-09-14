namespace Project_DVLD_version1.Detain_License
{
    partial class FormAppDetainLicense
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
            this.ctrlDetainLicense1 = new Project_DVLD_version1.Detain_License.ctrlDetainLicense();
            this.SuspendLayout();
            // 
            // ctrlDetainLicense1
            // 
            this.ctrlDetainLicense1.Location = new System.Drawing.Point(12, 12);
            this.ctrlDetainLicense1.Name = "ctrlDetainLicense1";
            this.ctrlDetainLicense1.Size = new System.Drawing.Size(975, 676);
            this.ctrlDetainLicense1.TabIndex = 0;
            // 
            // FormAppDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 709);
            this.Controls.Add(this.ctrlDetainLicense1);
            this.Name = "FormAppDetainLicense";
            this.Text = "FormAppDetainLicense";
            this.Load += new System.EventHandler(this.FormAppDetainLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlDetainLicense ctrlDetainLicense1;
    }
}