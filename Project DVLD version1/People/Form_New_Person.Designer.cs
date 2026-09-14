namespace Project_DVLD_version1
{
    partial class Form_New_Person
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

           
          
            this.ctrl_New_Person2 = new ctrl_New_Person(this.ID);
            
            
            this.SuspendLayout();

            // ctrl_New_Person2
            this.ctrl_New_Person2.Location = new System.Drawing.Point(12, 12);
            this.ctrl_New_Person2.Name = "ctrl_New_Person2";
            this.ctrl_New_Person2.Size = new System.Drawing.Size(1279, 552);
            this.ctrl_New_Person2.TabIndex = 0;
            this.ctrl_New_Person2.Load += new System.EventHandler(this.ctrl_New_Person2_Load);

            // Form_New_Person
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 623);
            this.Controls.Add(this.ctrl_New_Person2);
            this.Name = "Form_New_Person";
            this.Text = "Form_New_Person";
            this.Load += new System.EventHandler(this.Form_New_Person_Load);

            this.ResumeLayout(false);
        }

        #endregion

      //  private ctrl_New_Person ctrl_New_Person1;
        private ctrl_New_Person ctrl_New_Person2;
    }
}