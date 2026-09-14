namespace Project_DVLD_version1
{
    partial class FormshowPeople
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
            this.ctrl_fillter_People1 = new Project_DVLD_version1.ctrl_fillter_People();
            this.SuspendLayout();
            // 
            // ctrl_fillter_People1
            // 
            this.ctrl_fillter_People1.Location = new System.Drawing.Point(2, 1);
            this.ctrl_fillter_People1.Name = "ctrl_fillter_People1";
            this.ctrl_fillter_People1.Size = new System.Drawing.Size(1344, 590);
            this.ctrl_fillter_People1.TabIndex = 0;
            this.ctrl_fillter_People1.EnvetSendID += new System.Action<int>(this.ctrl_fillter_People1_EnvetSendID);
            this.ctrl_fillter_People1.Load += new System.EventHandler(this.ctrl_fillter_People1_Load);
            // 
            // FormshowPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 685);
            this.Controls.Add(this.ctrl_fillter_People1);
            this.Name = "FormshowPeople";
            this.Text = "FormshowPeople";
            this.Load += new System.EventHandler(this.FormshowPeople_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrl_fillter_People ctrl_fillter_People1;
    }
}