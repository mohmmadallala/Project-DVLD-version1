namespace Project_DVLD_version1
{
    partial class Form_Show_Info_Person
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
            this.ctrl_show_Info_Person1 = new Project_DVLD_version1.ctrl_show_Info_Person();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1216, 599);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrl_show_Info_Person1
            // 
            this.ctrl_show_Info_Person1._ID = -1;
            this.ctrl_show_Info_Person1.Location = new System.Drawing.Point(0, 3);
            this.ctrl_show_Info_Person1.Name = "ctrl_show_Info_Person1";
            this.ctrl_show_Info_Person1.Size = new System.Drawing.Size(1559, 590);
            this.ctrl_show_Info_Person1.TabIndex = 0;
            this.ctrl_show_Info_Person1.Load += new System.EventHandler(this.ctrl_show_Info_Person1_Load);
            // 
            // Form_Show_Info_Person
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1597, 675);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctrl_show_Info_Person1);
            this.Name = "Form_Show_Info_Person";
            this.Text = "Form_Show_Info_Person";
            this.Load += new System.EventHandler(this.Form_Show_Info_Person_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrl_show_Info_Person ctrl_show_Info_Person1;
        private System.Windows.Forms.Button button1;
    }
}