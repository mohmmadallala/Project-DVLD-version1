namespace Project_DVLD_version1
{
    partial class Form_Show_Info_App_local
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAppointmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reasonFailedTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrl_show_info_Application1 = new Project_DVLD_version1.ctrl_show_info_Application();
            this.ctrl_show_Infi_LocalApp1 = new Project_DVLD_version1.ctrl_show_Infi_LocalApp();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(59, 599);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 254);
            this.dataGridView1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAppointmentToolStripMenuItem,
            this.editAppointmentToolStripMenuItem1,
            this.takeTestToolStripMenuItem,
            this.reasonFailedTestToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(241, 136);
            // 
            // editAppointmentToolStripMenuItem
            // 
            this.editAppointmentToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.list4;
            this.editAppointmentToolStripMenuItem.Name = "editAppointmentToolStripMenuItem";
            this.editAppointmentToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.editAppointmentToolStripMenuItem.Text = "Show info Appointment";
            this.editAppointmentToolStripMenuItem.Click += new System.EventHandler(this.showAppointmentToolStripMenuItem_Click);
            // 
            // editAppointmentToolStripMenuItem1
            // 
            this.editAppointmentToolStripMenuItem1.Image = global::Project_DVLD_version1.Properties.Resources.edit1;
            this.editAppointmentToolStripMenuItem1.Name = "editAppointmentToolStripMenuItem1";
            this.editAppointmentToolStripMenuItem1.Size = new System.Drawing.Size(240, 26);
            this.editAppointmentToolStripMenuItem1.Text = "Edit Appointment";
            this.editAppointmentToolStripMenuItem1.Click += new System.EventHandler(this.editAppointmentToolStripMenuItem1_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.test2;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // reasonFailedTestToolStripMenuItem
            // 
            this.reasonFailedTestToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.question_mark_96;
            this.reasonFailedTestToolStripMenuItem.Name = "reasonFailedTestToolStripMenuItem";
            this.reasonFailedTestToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.reasonFailedTestToolStripMenuItem.Text = "Reason Failed Test";
            this.reasonFailedTestToolStripMenuItem.Click += new System.EventHandler(this.reasonFailedTestToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 566);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Appointments :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(52, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Form Show Info Application Local ";
            // 
            // button1
            // 
            this.button1.Image = global::Project_DVLD_version1.Properties.Resources.add_small_1_1;
            this.button1.Location = new System.Drawing.Point(690, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "      ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctrl_show_info_Application1
            // 
            this.ctrl_show_info_Application1.ID = -1;
            this.ctrl_show_info_Application1.Location = new System.Drawing.Point(25, 278);
            this.ctrl_show_info_Application1.Name = "ctrl_show_info_Application1";
            this.ctrl_show_info_Application1.Size = new System.Drawing.Size(767, 293);
            this.ctrl_show_info_Application1.TabIndex = 1;
            this.ctrl_show_info_Application1.Load += new System.EventHandler(this.ctrl_show_info_Application1_Load);
            // 
            // ctrl_show_Infi_LocalApp1
            // 
            this.ctrl_show_Infi_LocalApp1.ID = -1;
            this.ctrl_show_Infi_LocalApp1.Location = new System.Drawing.Point(12, 98);
            this.ctrl_show_Infi_LocalApp1.Name = "ctrl_show_Infi_LocalApp1";
            this.ctrl_show_Infi_LocalApp1.Size = new System.Drawing.Size(786, 192);
            this.ctrl_show_Infi_LocalApp1.TabIndex = 0;
            // 
            // Form_Show_Info_App_local
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 1055);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ctrl_show_info_Application1);
            this.Controls.Add(this.ctrl_show_Infi_LocalApp1);
            this.Name = "Form_Show_Info_App_local";
            this.Text = "Form_Show_Info_App_local";
            this.Load += new System.EventHandler(this.Form_Show_Info_App_local_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrl_show_Infi_LocalApp ctrl_show_Infi_LocalApp1;
        private ctrl_show_info_Application ctrl_show_info_Application1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAppointmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reasonFailedTestToolStripMenuItem;
    }
}