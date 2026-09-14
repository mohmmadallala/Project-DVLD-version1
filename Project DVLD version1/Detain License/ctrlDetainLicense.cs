using BussinassLayer;
using Project_DVLD_version1.class_Helper;
using Project_DVLD_version1.Licenses;
using Project_DVLD_version1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1.Detain_License
{
    public partial class ctrlDetainLicense : UserControl
    {
        private int _ID;
        public ctrlDetainLicense()
        {
            InitializeComponent();
            _ID = -1;
        }
        public ctrlDetainLicense(int id) {
            InitializeComponent();
            _ID=id;
        
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int.TryParse(maskedTextBox1.Text, out int id);
                loadData(id);
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                linkLabel1.Enabled= false;
                linkLabel2.Enabled= false;
                button2.Enabled= false;
                ResetValues();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                return;
            }
            int.TryParse(maskedTextBox1.Text, out int id);
            loadData(id);
            
        }
        public void loadData(int id,int licdetain=-1)
        {
            _ID = id;
            if (_ID == -1) {
                return;
            }
            clsLincsesBess cls = clsLincsesBess.GetLincese(_ID);
            if (cls == null)
            {
                return;
            }
            clsPersonBess person = clsPersonBess.GetPersonById(clsDriverBess.GetDriver(cls.DriverID).IdPerson);
            if (person == null)
            {
                return;
            }
            lbname.Text = person.FullName();
            lbNationall.Text = person.NationNo;
            lbGender.Text = person.Gendor == 0 ? "Male" : "Female";
            lbbirth.Text=person.BirthOfDate.Date.ToShortDateString();

            if (string.IsNullOrEmpty(person.ImagePath))
            {
                pictureBox1.Image = Resources.person_boy1;

            }
            else
            {
                pictureBox1.ImageLocation = person.ImagePath;
            }

            lblicenseid.Text = cls.LicenseID.ToString();
            lbLicenseDetainId.Text= cls.LicenseID.ToString();
            lbclassLicense.Text = clsLicensesClassesBess.GetClassById(cls.LicenseClass).Name.ToString();
            lbissuedate.Text=cls.IssueDate.Date.ToShortDateString();
            lbExpiration.Text=cls.ExpirationDate.Date.ToShortDateString();
            lbIssueReason.Text = clsFunsHelper.GetReasonById(cls.IssueReason);
            lbNotes.Text= cls.Notes.ToString();
            lbUserid.Text = clsGlobalUser.UserName;
          
            lbDriverid.Text= cls.DriverID.ToString();
            lbActive.Text = cls.IsActive ? "Yes" : "No";
            lbIsdetained.Text = clsDetainLicense.IsLicenseDetained(cls.LicenseID) ? "Yes" : "No";

            lbDateDetain.Text=DateTime.Now.Date.ToShortDateString();
            linkLabel1.Enabled = true;
         
            button2.Enabled= true;
            if (licdetain != -1)
            {
               lbDetainId.Text=licdetain.ToString();

            }


        }
        private void ResetValues()
        {
            lbActive.Text = "[???]";
            lbDateDetain.Text = "[???]";
            lbbirth.Text = "[???]";

            lbclassLicense.Text = "[???]";
            lbDetainId.Text = "[???]";
            lbDetainId.Text = "[???]";
            lbDriverid.Text = "[???]";
            lbExpiration.Text = "[???]";
            maskedTextBox2.Text = "";
            lbGender.Text = "[???]";
            lbIsdetained.Text = "[???]";
            lbissuedate.Text = "[???]";
            lbIssueReason.Text = "[???]";
           
            lblicenseid.Text = "[???]";
            lbname.Text = "[???]";
            lbNationall.Text = "[???]";
            lbNotes.Text = "[???]";
            lbLicenseDetainId.Text = "[???]";
            
            lbUserid.Text = "[???]";
            pictureBox1.Image = Resources.person_boy1;

        }
        private void ctrlDetainLicense_Load(object sender, EventArgs e)
        {
            linkLabel1.Enabled= false;
            linkLabel2.Enabled= false;
            button2.Enabled= false;
            loadData(_ID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox2.Text))
            {
                MessageBox.Show("Enter value Fine Fees");
                return;
            }
            clsLincsesBess cls = clsLincsesBess.GetLincese(_ID);
            if (clsDetainLicense.IsLicenseDetained(_ID))
            {

                MessageBox.Show($"this is License already Detain {_ID}");
                return;
               
            }
            else
            {
                clsDetainLicense detain=new clsDetainLicense();
                detain.ReleaseApplicationID = null;
                detain.ReleaseDate= null;
                detain.IsReleased = false;
                detain.ReleasedByUserID = null;
                detain.FineFees = Convert.ToDecimal(maskedTextBox2.Text);
                detain.DetainDate = DateTime.Now;
                detain.CreatedByUserID = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                detain.LicenseID= cls.LicenseID;

                if (detain.Save())
                {
                    loadData(_ID, detain.DetainID);
                    MessageBox.Show("Successfully Detain License");
                }

                linkLabel2.Enabled = true;
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_ID <= 0)
            {
                MessageBox.Show("License ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form frm = new FormShowLicenseInfo(_ID);
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int personid = clsPersonBess.GetPersonById(clsDriverBess.GetDriver(clsLincsesBess.GetLincese(_ID).DriverID).IdPerson).ID;

            Form f = new FormShowLincese(personid);
            f.ShowDialog();
        }

        private void maskedTextBox2_Validating(object sender, CancelEventArgs e)
        {
            int.TryParse(maskedTextBox2.Text, out int val);
            if (val > 300 || val < 10)
            {
                e.Cancel=true;

            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
