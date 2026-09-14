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
    public partial class ctrlReleaseLicense : UserControl
    {
        private int _ID;
        public ctrlReleaseLicense()
        {
            InitializeComponent();
            _ID = -1;
        }
        public  ctrlReleaseLicense(int id)
        {
            InitializeComponent();
            _ID = id;
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                LoadDate(Convert.ToInt32(maskedTextBox1.Text));
            }
        }

        public void LoadDate(int id,int IdRelease=-1,bool IsShow=false)
        {
            _ID = id;
            if (_ID == -1)
            {
                return;
            }
            if (IsShow)
            {
                groupBox1.Enabled = false;
                    
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
            lbbirth.Text = person.BirthOfDate.Date.ToShortDateString();

            if (string.IsNullOrEmpty(person.ImagePath))
            {
                pictureBox1.Image = Resources.person_boy1;

            }
            else
            {
                pictureBox1.ImageLocation = person.ImagePath;
            }

            lblicenseid.Text = cls.LicenseID.ToString();
           
            lbclassLicense.Text = clsLicensesClassesBess.GetClassById(cls.LicenseClass).Name.ToString();
            lbissuedate.Text = cls.IssueDate.Date.ToShortDateString();
            lbExpiration.Text = cls.ExpirationDate.Date.ToShortDateString();
            lbIssueReason.Text = clsFunsHelper.GetReasonById(cls.IssueReason);
            lbNotes.Text = cls.Notes.ToString();
          

            lbDriverid.Text = cls.DriverID.ToString();
            lbActive.Text = cls.IsActive ? "Yes" : "No";
            lbIsdetained.Text = clsDetainLicense.IsLicenseDetained(cls.LicenseID) ? "Yes" : "No";
            linkLabel1.Enabled = true;

            if (IdRelease == -1)
            {
                //MessageBox.Show($"Not Application {IdRelease}");
            }
            else
            {
                lbReleaseApp.Text = IdRelease.ToString();
                linkLabel2.Enabled = true;
                button2.Enabled = false;

            }
            clsDetainLicense detain = clsDetainLicense.FindbyLicenseId(cls.LicenseID);
            if (detain == null)
            {
                return;
            }
            decimal feesApp = Convert.ToDecimal(clsTypeAppBess.GetApp(11).Fees);
            lbDetaindate.Text = detain.DetainDate.ToShortDateString();
            lbDetainId.Text=detain.DetainID.ToString();
            lbLicDetain.Text=detain.LicenseID.ToString();
            lbfinefees.Text = detain.FineFees.ToString();
            lbAppfees.Text = feesApp.ToString();
            lbtotalfees.Text = (feesApp + detain.FineFees).ToString();
            lbuser.Text = detain.CreatedByUserID.ToString();

         


            linkLabel1.Enabled = true;
            button2.Enabled = true;
           


        }
        private void ResetValues()
        {
            lbActive.Text = "[???]";
            lbAppfees.Text = "[???]";
            lbbirth.Text = "[???]";
            
            lbclassLicense.Text = "[???]";
            lbDetaindate.Text = "[???]";
            lbDetainId.Text = "[???]";
            lbDriverid.Text = "[???]";
            lbExpiration.Text = "[???]";
            lbfinefees.Text = "[???]";
            lbGender.Text = "[???]";
            lbIsdetained.Text = "[???]";
            lbissuedate.Text = "[???]";
            lbIssueReason.Text = "[???]";
            lbLicDetain.Text = "[???]";
            lblicenseid.Text = "[???]";
            lbname.Text = "[???]";
            lbNationall.Text = "[???]";
            lbNotes.Text = "[???]";
            lbReleaseApp.Text = "[???]";
            lbtotalfees.Text = "[???]";
            lbuser.Text = "[???]";
            pictureBox1.Image = Resources.person_boy1;
            
        }
        private void ctrlReleaseLicense_Load(object sender, EventArgs e)
        {
            linkLabel1.Enabled = false;
            linkLabel2.Enabled = false;
            button2.Enabled = false;
            ResetValues();
            LoadDate(_ID);
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

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                button2.Enabled = false;
                linkLabel1.Enabled = false;
                linkLabel2.Enabled = false;
                ResetValues();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (clsDetainLicense.IsLicenseDetained(_ID))
            {
                clsApplicationBess App=new clsApplicationBess();
                App.AppState = clsApplicationBess.EnState.New;
                App.AppDate = DateTime.Now;
                App.Fees = clsTypeAppBess.GetApp(11).Fees;
                App.AppLastStateUpdateDate = DateTime.Now;
                App.AppTypeID = 11;
                App.PersonID = clsPersonBess.GetPersonByNationalNo(lbNationall.Text).ID;
                App.UserID = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                
                if (App.Save())
                {
                    clsDetainLicense detain = clsDetainLicense.FindbyLicenseId(_ID);
                   
                    if (detain == null)
                    {
                        return;
                    }
                    detain.IsReleased =true;
                    detain.ReleaseDate = DateTime.Now;
                    detain.ReleaseApplicationID = App.AppID;
                    detain.ReleasedByUserID=App.UserID;
                    detain.Save();
                    App.AppState=clsApplicationBess.EnState.Complated;
                    App.Mode = clsApplicationBess.EnMode.Update;
                   
                    MessageBox.Show("Successfully Release License");
                    LoadDate(_ID,App.AppID);
                    MessageBox.Show($"{App.AppID}");
                    linkLabel2.Enabled = true;
                    App.Save();
                }
            }
            else
            {
                MessageBox.Show($"Not Found License Detained have number {_ID}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                return;
            }
            LoadDate(Convert.ToInt32(maskedTextBox1.Text));

        }

        private void lbclass_Click(object sender, EventArgs e)
        {

        }
    }
}
