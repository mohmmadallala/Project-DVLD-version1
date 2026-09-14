namespace Project_DVLD_version1
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.licensesLocallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacementForLostORDamageLicensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageLocalLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageInternationalLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseLicenseDetainedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peopleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showInfoCurrentUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyMyPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem,
            this.peopleToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.settingAccountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 43);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.manageTestToolStripMenuItem});
            this.applicationToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.document__1_;
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(162, 39);
            this.applicationToolStripMenuItem.Text = "Application";
            this.applicationToolStripMenuItem.Click += new System.EventHandler(this.applicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licensesLocallyToolStripMenuItem,
            this.renewDrivingLicensToolStripMenuItem,
            this.replacementForLostORDamageLicensToolStripMenuItem,
            this.releaseDetainLicenseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.toolStripMenuItem1.Image = global::Project_DVLD_version1.Properties.Resources.card;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(344, 42);
            this.toolStripMenuItem1.Text = "Driving Licenses Services";
            // 
            // licensesLocallyToolStripMenuItem
            // 
            this.licensesLocallyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.internationalLicenseToolStripMenuItem});
            this.licensesLocallyToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensesLocallyToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.card_design_add;
            this.licensesLocallyToolStripMenuItem.Name = "licensesLocallyToolStripMenuItem";
            this.licensesLocallyToolStripMenuItem.Size = new System.Drawing.Size(388, 42);
            this.licensesLocallyToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localLicenseToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.card;
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.localLicenseToolStripMenuItem.Text = "Local License";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // internationalLicenseToolStripMenuItem
            // 
            this.internationalLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.internationalLicenseToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.web_mail;
            this.internationalLicenseToolStripMenuItem.Name = "internationalLicenseToolStripMenuItem";
            this.internationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(209, 26);
            this.internationalLicenseToolStripMenuItem.Text = "international License";
            this.internationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicensToolStripMenuItem
            // 
            this.renewDrivingLicensToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renewDrivingLicensToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.card_design_reload;
            this.renewDrivingLicensToolStripMenuItem.Name = "renewDrivingLicensToolStripMenuItem";
            this.renewDrivingLicensToolStripMenuItem.Size = new System.Drawing.Size(388, 42);
            this.renewDrivingLicensToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicensToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicensToolStripMenuItem_Click);
            // 
            // replacementForLostORDamageLicensToolStripMenuItem
            // 
            this.replacementForLostORDamageLicensToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replacementForLostORDamageLicensToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.card_design_close;
            this.replacementForLostORDamageLicensToolStripMenuItem.Name = "replacementForLostORDamageLicensToolStripMenuItem";
            this.replacementForLostORDamageLicensToolStripMenuItem.Size = new System.Drawing.Size(388, 42);
            this.replacementForLostORDamageLicensToolStripMenuItem.Text = "Replacement for Lost OR Damage License";
            this.replacementForLostORDamageLicensToolStripMenuItem.Click += new System.EventHandler(this.replacementForLostORDamageLicensToolStripMenuItem_Click);
            // 
            // releaseDetainLicenseToolStripMenuItem
            // 
            this.releaseDetainLicenseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.releaseDetainLicenseToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.file;
            this.releaseDetainLicenseToolStripMenuItem.Name = "releaseDetainLicenseToolStripMenuItem";
            this.releaseDetainLicenseToolStripMenuItem.Size = new System.Drawing.Size(388, 42);
            this.releaseDetainLicenseToolStripMenuItem.Text = "Release Detain License";
            this.releaseDetainLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainLicenseToolStripMenuItem_Click);
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retakeTestToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.file_refresh;
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(388, 42);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            this.retakeTestToolStripMenuItem.Click += new System.EventHandler(this.retakeTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageLocalLicensesToolStripMenuItem,
            this.manageInternationalLicensesToolStripMenuItem});
            this.toolStripMenuItem2.Image = global::Project_DVLD_version1.Properties.Resources.documents__2_;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(344, 42);
            this.toolStripMenuItem2.Text = "Manage Application";
            // 
            // manageLocalLicensesToolStripMenuItem
            // 
            this.manageLocalLicensesToolStripMenuItem.Name = "manageLocalLicensesToolStripMenuItem";
            this.manageLocalLicensesToolStripMenuItem.Size = new System.Drawing.Size(360, 32);
            this.manageLocalLicensesToolStripMenuItem.Text = "Manage Local Licenses";
            this.manageLocalLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageLocalLicensesToolStripMenuItem_Click);
            // 
            // manageInternationalLicensesToolStripMenuItem
            // 
            this.manageInternationalLicensesToolStripMenuItem.Name = "manageInternationalLicensesToolStripMenuItem";
            this.manageInternationalLicensesToolStripMenuItem.Size = new System.Drawing.Size(360, 32);
            this.manageInternationalLicensesToolStripMenuItem.Text = "Manage International Licenses";
            this.manageInternationalLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageInternationalLicensesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseLicenseDetainedToolStripMenuItem});
            this.toolStripMenuItem3.Image = global::Project_DVLD_version1.Properties.Resources.hand;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(344, 42);
            this.toolStripMenuItem3.Text = "Datein Licenses";
            // 
            // manageDetainToolStripMenuItem
            // 
            this.manageDetainToolStripMenuItem.Name = "manageDetainToolStripMenuItem";
            this.manageDetainToolStripMenuItem.Size = new System.Drawing.Size(328, 32);
            this.manageDetainToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainToolStripMenuItem.Click += new System.EventHandler(this.manageDetainToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(328, 32);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseLicenseDetainedToolStripMenuItem
            // 
            this.releaseLicenseDetainedToolStripMenuItem.Name = "releaseLicenseDetainedToolStripMenuItem";
            this.releaseLicenseDetainedToolStripMenuItem.Size = new System.Drawing.Size(328, 32);
            this.releaseLicenseDetainedToolStripMenuItem.Text = "Release License Detained";
            this.releaseLicenseDetainedToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseDetainedToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Image = global::Project_DVLD_version1.Properties.Resources.contract_config2;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(344, 42);
            this.toolStripMenuItem4.Text = "Manage Application Types";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // manageTestToolStripMenuItem
            // 
            this.manageTestToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.list21;
            this.manageTestToolStripMenuItem.Name = "manageTestToolStripMenuItem";
            this.manageTestToolStripMenuItem.Size = new System.Drawing.Size(344, 42);
            this.manageTestToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestToolStripMenuItem.Click += new System.EventHandler(this.manageTestToolStripMenuItem_Click);
            // 
            // peopleToolStripMenuItem
            // 
            this.peopleToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.focus_group;
            this.peopleToolStripMenuItem.Name = "peopleToolStripMenuItem";
            this.peopleToolStripMenuItem.Size = new System.Drawing.Size(120, 39);
            this.peopleToolStripMenuItem.Text = "People";
            this.peopleToolStripMenuItem.Click += new System.EventHandler(this.peopleToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.users;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(108, 39);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.driver;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(122, 39);
            this.driversToolStripMenuItem.Text = "Drivers";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // settingAccountToolStripMenuItem
            // 
            this.settingAccountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showInfoCurrentUserToolStripMenuItem1,
            this.modifyMyPasswordToolStripMenuItem,
            this.logoutToolStripMenuItem1});
            this.settingAccountToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.gear;
            this.settingAccountToolStripMenuItem.Name = "settingAccountToolStripMenuItem";
            this.settingAccountToolStripMenuItem.Size = new System.Drawing.Size(198, 39);
            this.settingAccountToolStripMenuItem.Text = "setting Account";
            this.settingAccountToolStripMenuItem.Click += new System.EventHandler(this.settingAccountToolStripMenuItem_Click);
            // 
            // showInfoCurrentUserToolStripMenuItem1
            // 
            this.showInfoCurrentUserToolStripMenuItem1.Image = global::Project_DVLD_version1.Properties.Resources.list2;
            this.showInfoCurrentUserToolStripMenuItem1.Name = "showInfoCurrentUserToolStripMenuItem1";
            this.showInfoCurrentUserToolStripMenuItem1.Size = new System.Drawing.Size(314, 42);
            this.showInfoCurrentUserToolStripMenuItem1.Text = "Show Info Current User";
            this.showInfoCurrentUserToolStripMenuItem1.Click += new System.EventHandler(this.showInfoCurrentUserToolStripMenuItem1_Click);
            // 
            // modifyMyPasswordToolStripMenuItem
            // 
            this.modifyMyPasswordToolStripMenuItem.Image = global::Project_DVLD_version1.Properties.Resources.lock_closed__1_2;
            this.modifyMyPasswordToolStripMenuItem.Name = "modifyMyPasswordToolStripMenuItem";
            this.modifyMyPasswordToolStripMenuItem.Size = new System.Drawing.Size(314, 42);
            this.modifyMyPasswordToolStripMenuItem.Text = "Modify My Password";
            this.modifyMyPasswordToolStripMenuItem.Click += new System.EventHandler(this.modifyMyPasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem1
            // 
            this.logoutToolStripMenuItem1.Image = global::Project_DVLD_version1.Properties.Resources.door1;
            this.logoutToolStripMenuItem1.Name = "logoutToolStripMenuItem1";
            this.logoutToolStripMenuItem1.Size = new System.Drawing.Size(314, 42);
            this.logoutToolStripMenuItem1.Text = "Logout";
            this.logoutToolStripMenuItem1.Click += new System.EventHandler(this.logoutToolStripMenuItem1_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 444);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peopleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showInfoCurrentUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modifyMyPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem manageTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licensesLocallyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacementForLostORDamageLicensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageLocalLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageInternationalLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseDetainedToolStripMenuItem;
    }
}

