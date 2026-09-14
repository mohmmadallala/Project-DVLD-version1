namespace Project_DVLD_version1
{
    partial class FormShowUsers
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
            this.ctrl_fillter_Users1 = new Project_DVLD_version1.ctrl_fillter_Users();
            this.SuspendLayout();
            // 
            // ctrl_fillter_Users1
            // 
            this.ctrl_fillter_Users1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrl_fillter_Users1.Location = new System.Drawing.Point(0, 0);
            this.ctrl_fillter_Users1.Name = "ctrl_fillter_Users1";
            this.ctrl_fillter_Users1.Size = new System.Drawing.Size(1513, 595);
            this.ctrl_fillter_Users1.TabIndex = 0;
            this.ctrl_fillter_Users1.Load += new System.EventHandler(this.ctrl_fillter_Users1_Load);
            // 
            // FormShowUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 595);
            this.Controls.Add(this.ctrl_fillter_Users1);
            this.Name = "FormShowUsers";
            this.Text = "FormShowUsers";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrl_fillter_Users ctrl_fillter_Users1;
    }
}