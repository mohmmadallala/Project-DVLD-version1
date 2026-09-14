namespace Project_DVLD_version1.Detain_License
{
    partial class FormReleaseLicense
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
            this.ctrlReleaseLicense1 = new Project_DVLD_version1.Detain_License.ctrlReleaseLicense();
            this.SuspendLayout();
            // 
            // ctrlReleaseLicense1
            // 
            this.ctrlReleaseLicense1.Location = new System.Drawing.Point(3, 2);
            this.ctrlReleaseLicense1.Name = "ctrlReleaseLicense1";
            this.ctrlReleaseLicense1.Size = new System.Drawing.Size(966, 681);
            this.ctrlReleaseLicense1.TabIndex = 0;
            // 
            // FormReleaseLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 716);
            this.Controls.Add(this.ctrlReleaseLicense1);
            this.Name = "FormReleaseLicense";
            this.Text = "FormReleaseLicense";
            this.Load += new System.EventHandler(this.FormReleaseLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlReleaseLicense ctrlReleaseLicense1;
    }
}