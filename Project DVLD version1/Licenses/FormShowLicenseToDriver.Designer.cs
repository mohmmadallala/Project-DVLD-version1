namespace Project_DVLD_version1
{
    partial class FormShowLicenseToDriver
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
            this.ctrl_show_info_Application1 = new Project_DVLD_version1.ctrl_show_info_Application();
            this.ctrl_show_Infi_LocalApp1 = new Project_DVLD_version1.ctrl_show_Infi_LocalApp();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrl_show_info_Application1
            // 
            this.ctrl_show_info_Application1.ID = -1;
            this.ctrl_show_info_Application1.Location = new System.Drawing.Point(12, 151);
            this.ctrl_show_info_Application1.Name = "ctrl_show_info_Application1";
            this.ctrl_show_info_Application1.Size = new System.Drawing.Size(780, 282);
            this.ctrl_show_info_Application1.TabIndex = 0;
            // 
            // ctrl_show_Infi_LocalApp1
            // 
            this.ctrl_show_Infi_LocalApp1.ID = -1;
            this.ctrl_show_Infi_LocalApp1.Location = new System.Drawing.Point(1, -19);
            this.ctrl_show_Infi_LocalApp1.Name = "ctrl_show_Infi_LocalApp1";
            this.ctrl_show_Infi_LocalApp1.Size = new System.Drawing.Size(780, 203);
            this.ctrl_show_Infi_LocalApp1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 502);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(568, 112);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 505);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notes :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(625, 686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(765, 686);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Issue";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormShowLicenseToDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 780);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ctrl_show_Infi_LocalApp1);
            this.Controls.Add(this.ctrl_show_info_Application1);
            this.Name = "FormShowLicenseToDriver";
            this.Text = "FormShowLicenseToDriver";
            this.Load += new System.EventHandler(this.FormShowLicenseToDriver_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrl_show_info_Application ctrl_show_info_Application1;
        private ctrl_show_Infi_LocalApp ctrl_show_Infi_LocalApp1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}