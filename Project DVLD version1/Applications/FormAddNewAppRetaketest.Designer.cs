namespace Project_DVLD_version1
{
    partial class FormAddNewAppRetaketest
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
            this.ctrl_Multi_fillter1 = new Project_DVLD_version1.ctrl_Multi_fillter();
            this.ctrl_show_Info_Person1 = new Project_DVLD_version1.ctrl_show_Info_Person();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrl_Multi_fillter1
            // 
            this.ctrl_Multi_fillter1.Enablebuttun = true;
            this.ctrl_Multi_fillter1.EnableFillter = true;
            this.ctrl_Multi_fillter1.EnableMaskText = true;
            this.ctrl_Multi_fillter1.Location = new System.Drawing.Point(-7, 12);
            this.ctrl_Multi_fillter1.Mycompebox = null;
            this.ctrl_Multi_fillter1.Name = "ctrl_Multi_fillter1";
            this.ctrl_Multi_fillter1.numlist = 0;
            this.ctrl_Multi_fillter1.Size = new System.Drawing.Size(829, 148);
            this.ctrl_Multi_fillter1.TabIndex = 13;
            this.ctrl_Multi_fillter1.Load += new System.EventHandler(this.ctrl_Multi_fillter1_Load);
            // 
            // ctrl_show_Info_Person1
            // 
            this.ctrl_show_Info_Person1._ID = -1;
            this.ctrl_show_Info_Person1.Location = new System.Drawing.Point(12, 141);
            this.ctrl_show_Info_Person1.Name = "ctrl_show_Info_Person1";
            this.ctrl_show_Info_Person1.National = null;
            this.ctrl_show_Info_Person1.PathImage = null;
            this.ctrl_show_Info_Person1.showLinkEditPicture = false;
            this.ctrl_show_Info_Person1.Size = new System.Drawing.Size(1356, 404);
            this.ctrl_show_Info_Person1.TabIndex = 14;
            this.ctrl_show_Info_Person1.Load += new System.EventHandler(this.ctrl_show_Info_Person1_Load);
            // 
            // button2
            // 
            this.button2.Image = global::Project_DVLD_version1.Properties.Resources.diskette;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1027, 604);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 44);
            this.button2.TabIndex = 17;
            this.button2.Text = "          Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Project_DVLD_version1.Properties.Resources.close;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(824, 604);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 44);
            this.button3.TabIndex = 16;
            this.button3.Text = "        Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FormAddNewAppRetaketest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 716);
            this.Controls.Add(this.ctrl_Multi_fillter1);
            this.Controls.Add(this.ctrl_show_Info_Person1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Name = "FormAddNewAppRetaketest";
            this.Text = "FormAddNewAppRetaketest";
            this.Load += new System.EventHandler(this.FormAddNewAppRetaketest_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private ctrl_Multi_fillter ctrl_Multi_fillter1;
        private ctrl_show_Info_Person ctrl_show_Info_Person1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}