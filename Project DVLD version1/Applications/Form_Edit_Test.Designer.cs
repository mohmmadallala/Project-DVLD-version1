namespace Project_DVLD_version1
{
    partial class Form_Edit_Test
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
            this.ctrl_Edit_tests1 = new Project_DVLD_version1.ctrl_Edit_tests();
            this.SuspendLayout();
            // 
            // ctrl_Edit_tests1
            // 
            this.ctrl_Edit_tests1.Location = new System.Drawing.Point(12, 12);
            this.ctrl_Edit_tests1.Name = "ctrl_Edit_tests1";
            this.ctrl_Edit_tests1.Size = new System.Drawing.Size(782, 450);
            this.ctrl_Edit_tests1.TabIndex = 0;
            // 
            // Form_Edit_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 534);
            this.Controls.Add(this.ctrl_Edit_tests1);
            this.Name = "Form_Edit_Test";
            this.Text = "Form_Edit_Test";
            this.Load += new System.EventHandler(this.Form_Edit_Test_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrl_Edit_tests ctrl_Edit_tests1;
    }
}