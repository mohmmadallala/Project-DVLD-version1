using BussinassLayer;
using Project_DVLD_version1.Application_Renew;
using Project_DVLD_version1.Damage_and_Replecment;
using Project_DVLD_version1.Detain_License;
using Project_DVLD_version1.international;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1
{
    public partial class FormMain : Form
    {
        private int _ID;
        public FormMain(int id)
        {
            InitializeComponent();
            _ID=id;
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f=new FormshowPeople();
            f.ShowDialog();
        }

        private void settingAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void applicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f=new FormShowUsers();
            f.ShowDialog();  
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
           
            Form f = new Form_login();
            f.ShowDialog();
        }

        private void showInfoCurrentUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f=new Form_show_info_user(_ID);
            f.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void modifyMyPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f =new Form_Change_Password(_ID);
            f.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form f= new Form_Manage_App_types();
            f.ShowDialog();
        }

        private void manageTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form F =new Form_Manage_Test_Types();
            F.ShowDialog();
        }

        private void manageLocalLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form F = new Form_Manage_App_Locally_Licenses();
            F.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_Add_New_License_locally(-1);
            f.ShowDialog(this);
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormAddNewAppRetaketest();
            f.ShowDialog();
            
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f=new Form_Show_Drivers();
            f.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormInsertLicenseNewInternational(-1, true, true);
            f.ShowDialog();
        }

        private void manageInternationalLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f=new FormManagmentLicenseInternational();
            f.ShowDialog();
        }

        private void renewDrivingLicensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormApplicationRenewLicense(-1);
            f.ShowDialog();
        }

        private void replacementForLostORDamageLicensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormAppReplacement(-1);
            f.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormAppDetainLicense(-1);
            f.ShowDialog();
        }

        private void releaseLicenseDetainedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormReleaseLicense();
            f.ShowDialog();
        }

        private void manageDetainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormManageDetainLicense();
            f.ShowDialog();
        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormReleaseLicense();
            f.ShowDialog();
        }
    }
}
