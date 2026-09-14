namespace Project_DVLD_version1
{
    partial class Form_Edit_App
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctrl_Edit_App1 = new Project_DVLD_version1.ctrl_Edit_App();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(672, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tips Important";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(675, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 60);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tip 1) Not ableblity Add New App\r\n\r\nTip 2) Not Ablebilty Drop App\r\n";
            // 
            // ctrl_Edit_App1
            // 
            this.ctrl_Edit_App1.Location = new System.Drawing.Point(12, 12);
            this.ctrl_Edit_App1.Name = "ctrl_Edit_App1";
            this.ctrl_Edit_App1.Size = new System.Drawing.Size(583, 339);
            this.ctrl_Edit_App1.TabIndex = 0;
            this.ctrl_Edit_App1.Load += new System.EventHandler(this.ctrl_Edit_App1_Load);
            // 
            // Form_Edit_App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctrl_Edit_App1);
            this.Name = "Form_Edit_App";
            this.Text = "Form_Edit_App";
            this.Load += new System.EventHandler(this.Form_Edit_App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrl_Edit_App ctrl_Edit_App1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}