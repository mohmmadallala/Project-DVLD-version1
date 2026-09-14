using BussinassLayer;
using Project_DVLD_version1.class_Helper;
using Project_DVLD_version1.Licenses;
using Project_DVLD_version1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_DVLD_version1.Damage_and_Replecment
{
    public partial class ctrlAppDamageAndReplcement : UserControl
    {

        private int NewlicnseID=-1;
        private int _ID;
        public ctrlAppDamageAndReplcement()
        {
            InitializeComponent();
            _ID = -1;
        }
        public ctrlAppDamageAndReplcement(int id)
        {
            InitializeComponent();
            _ID = id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                return;
            }
            clsLincsesBess license = clsLincsesBess.GetLincese(_ID);
            if (license == null)
            {
                return;
            }
            if (license.IsActive)
            {
                clsApplicationBess App=new clsApplicationBess();
                App.AppState = clsApplicationBess.EnState.New;
                App.AppLastStateUpdateDate= DateTime.Now;
                App.AppDate = DateTime.Now;
                App.Fees = Convert.ToDouble(lbFeesApp.Text);
                if (radioButton1.Checked)
                {
                    App.AppTypeID = 4;
                }
                else
                {
                    App.AppTypeID = 3;
                }
                App.PersonID = clsDriverBess.GetDriver(license.DriverID).IdPerson;
                App.UserID = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                App.Mode = clsApplicationBess.EnMode.Add;
                if (App.Save())
                {
                    MessageBox.Show("Successful Insert New Application");
                    clsLincsesBess NewLic=new clsLincsesBess();
                    NewLic.DriverID = license.DriverID;
                    NewLic.CreatedByUserID= clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                    NewLic.ApplicationID = App.AppID;
                    NewLic.IssueDate = DateTime.Now.Date; ;
                    NewLic.ExpirationDate=DateTime.Now.Date.AddYears(clsLicensesClassesBess.GetClassById(license.LicenseClass).LengthDefault);
                    NewLic.IsActive = true;
                    NewLic.Notes = "Not Notes";
                    NewLic.PaidFees = license.PaidFees;
                    NewLic.LicenseClass = license.LicenseClass;
                    NewLic.IssueReason=App.AppTypeID;

                    if (NewLic.Save())
                    {
                        MessageBox.Show($"Done Insert New License To Driver {NewLic.LicenseID}");
                        App.AppState = clsApplicationBess.EnState.Complated;
                        App.Save();
                        license.IsActive = false;
                        license.Save();
                        Loaddata(license.LicenseID, App.AppID, NewLic.LicenseID);
                        radioButton1.Enabled = false;
                        radioButton1.Enabled = false;
                        linkLabel2.Enabled = true;
                        linkLabel1.Enabled= true;
                        button3.Enabled= false;
                        NewlicnseID = NewLic.LicenseID;
                    }
                
                }
                else
                {
                    radioButton1.Enabled = true;
                    radioButton1.Enabled = true; ;
                }
            }
            else
            {
                MessageBox.Show($"this is License DisActive");
                return;
            }
        }

        private void ChangeTitle()
        {
            if (radioButton1.Checked)
            {
                lbTitel.Text = "Replacement for Damage License";
            }
            else
            {
                lbTitel.Text = "Replacement for Lost License";
            }
        }
        public void Loaddata(int id,int appid=-1,int licNew=-1)
        {
            _ID = id;
            if (_ID == -1)
            {

                return;
            }
            clsLincsesBess clsLicense = clsLincsesBess.GetLincese(_ID);
            if (clsLicense == null)
            {
                return;
            }


            clsPersonBess person = clsPersonBess.GetPersonById(clsDriverBess.GetDriver(clsLicense.DriverID).IdPerson);
            if (person == null)
            {
                return;
            }
            lbname.Text = person.FullName();
            lbNationall.Text = person.NationNo;
            lbbirth.Text = person.BirthOfDate.ToShortDateString();
            lbGender.Text = person.Gendor == 0 ? "Male" : "Female";
            if (string.IsNullOrEmpty(person.ImagePath))
            {
                pictureBox1.Image = Resources.person_boy1;

            }
            else
            {
                pictureBox1.ImageLocation = person.ImagePath;
            }

            lbclassLicense.Text = clsLicensesClassesBess.GetClassById(clsLicense.LicenseClass).Name;
            lbDriverid.Text = clsLicense.DriverID.ToString();
            lblicenseid.Text = clsLicense.LicenseID.ToString();

            lbActive.Text = clsLicense.IsActive ? "Yes" : "No";
            lbissuedate.Text = clsLicense.IssueDate.ToShortDateString();
            lbIsdetained.Text = clsDetainLicense.IsLicenseDetained(clsLicense.LicenseID) ? "Yes" : "No";
            lbIssueReason.Text = clsFunsHelper.GetReasonById(clsLicense.IssueReason);
            lbNotes.Text = clsLicense.Notes;
            lbExpiration.Text = clsLicense.ExpirationDate.ToShortDateString();

            lbLicenseOld.Text = clsLicense.LicenseID.ToString();
            lbdateApp.Text=DateTime.Now.Date.ToShortDateString();
            lbuser.Text = clsGlobalUser.UserName;
            if (radioButton1.Checked){
                lbFeesApp.Text = clsTypeAppBess.GetApp(4).Fees.ToString();
            }
            else
            {
                lbFeesApp.Text = clsTypeAppBess.GetApp(3).Fees.ToString();
            }
            if (appid != -1 && licNew != -1)
            {
                lbLicenseNew.Text = licNew.ToString();
                lbAppReplace.Text= appid.ToString();
            }


        }
        private void ctrlAppDamageAndReplcement_Load(object sender, EventArgs e)
        {
            
            linkLabel2.Enabled=false;
            linkLabel1.Enabled=false;
            button3.Enabled=false;
            radioButton1.Checked= true;
            radioButton2.Checked = false;
            ChangeTitle();
            Loaddata(_ID);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton1.Checked)
                return;

            ChangeTitle();
            lbFeesApp.Text = clsTypeAppBess.GetApp(4).Fees.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!radioButton2.Checked)
                return;

            ChangeTitle();
            lbFeesApp.Text = clsTypeAppBess.GetApp(3).Fees.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int personid = clsPersonBess.GetPersonById(clsDriverBess.GetDriver(clsLincsesBess.GetLincese(_ID).DriverID).IdPerson).ID;

            Form f = new FormShowLincese(personid);
            f.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (NewlicnseID == -1)
            {
                MessageBox.Show($"Not Created New License");
                return;
            }
            Form frm = new FormShowLicenseInfo(NewlicnseID);
            frm.ShowDialog();
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                errorProvider1.SetError(maskedTextBox1, "Please Enter Value Numrical");
                return;
            }
            if (e.KeyCode == Keys.Enter)
            {
                errorProvider1.SetError(maskedTextBox1, "");
                int.TryParse(maskedTextBox1.Text, out int id);
                _ID = id;
                Loaddata(_ID);
                linkLabel1.Enabled= true;
                radioButton1.Enabled= true;
                radioButton2.Enabled= true;
                button3.Enabled= true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                return;
            }
            else
            {
                errorProvider1.SetError(maskedTextBox1, "");
                int.TryParse(maskedTextBox1.Text, out int id);
                _ID = id;
                Loaddata(_ID);
                linkLabel1.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                button3.Enabled = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
        private void DumpingDataEmpty()
        {
            lbname.Text = "???";
            lbNationall.Text = "???";
            lbActive.Text = "???";
            lbbirth.Text = "???";
            lbclassLicense.Text = "???";
            lbDriverid.Text = "???";
            lbExpiration.Text = "???";
            lbissuedate.Text = "???";
            lbIsdetained.Text = "???";
            lbGender.Text = "???";
            lbIssueReason.Text = "???";
            lblicenseid.Text = "???";
            lbAppReplace.Text = "???";
            lbLicenseNew.Text = "???";
            lbNotes.Text = "???";
            lbuser.Text = "???";
            lbFeesApp.Text = "???";
            lbuser.Text = "???";
            lbLicenseOld.Text = "???";
      
            pictureBox1.Image = Resources.person_boy1;

        }
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                DumpingDataEmpty();
                button3.Enabled= false;
                linkLabel1.Enabled=false;
                linkLabel2.Enabled=false;
                return;
            }
        }
    }
}
