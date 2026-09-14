namespace Project_DVLD_version1.Damage_and_Replecment
{
    partial class FormAppReplacement
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
            this.ctrlAppDamageAndReplcement1 = new Project_DVLD_version1.Damage_and_Replecment.ctrlAppDamageAndReplcement();
            this.SuspendLayout();
            // 
            // ctrlAppDamageAndReplcement1
            // 
            this.ctrlAppDamageAndReplcement1.Location = new System.Drawing.Point(12, 12);
            this.ctrlAppDamageAndReplcement1.Name = "ctrlAppDamageAndReplcement1";
            this.ctrlAppDamageAndReplcement1.Size = new System.Drawing.Size(1031, 737);
            this.ctrlAppDamageAndReplcement1.TabIndex = 0;
            this.ctrlAppDamageAndReplcement1.Load += new System.EventHandler(this.ctrlAppDamageAndReplcement1_Load);
            // 
            // FormAppReplacement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 854);
            this.Controls.Add(this.ctrlAppDamageAndReplcement1);
            this.Name = "FormAppReplacement";
            this.Text = "FormAppReplacement";
            this.Load += new System.EventHandler(this.FormAppReplacement_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAppDamageAndReplcement ctrlAppDamageAndReplcement1;
    }
}