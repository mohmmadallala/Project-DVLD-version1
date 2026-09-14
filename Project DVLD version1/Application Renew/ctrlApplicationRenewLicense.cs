using BussinassLayer;
using Project_DVLD_version1.class_Helper;
using Project_DVLD_version1.international;
using Project_DVLD_version1.Licenses;
using Project_DVLD_version1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1.Application_Renew
{
    public partial class ctrlApplicationRenewLicense : UserControl
    {
        private int _ID;
        private int NewIdLicmese=-1;
        public ctrlApplicationRenewLicense()
        {
            InitializeComponent();

            _ID = -1;
        }
        public ctrlApplicationRenewLicense(int id)
        {
            InitializeComponent();
            _ID = id;
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            linkLabel1.Enabled = false;
            linkLabel2.Enabled = false;
            linkLabel3.Enabled = false;
            button2.Enabled = false;
            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                return;
            }
            int id = Convert.ToInt32(maskedTextBox1.Text);
            if (clsLincsesBess.IsExsit(id))
            {

                Loaddata(id);
            }

            else
            {
                MessageBox.Show("Not Found License ID");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
        private void DefaultView()
        {
            lbname.Text = "???";
            lbNationall.Text = "???";
            lbActive.Text = "???";
            lbAppFess.Text = "???";
            lbApplicationDate.Text = "???";
            lbbirth.Text = "???";
            lbclassLicense.Text = "???";
            lbDriverid.Text = "???";
            lbExpiration.Text = "???";
            lbissuedate.Text = "???";
            lbIsdetained.Text = "???";
            lbGender.Text = "???";
            lbIssueDateToApp.Text = "???";
            lbIssueReason.Text = "???";
            lblicenseid.Text = "???";
            lbexpirationApp.Text = "???";
            lbLicenseFess.Text = "???";
            lbNotes.Text = "???";
            lbuser.Text = "???";
            lbtotalFees.Text = "???";
            lbRLID.Text = "???";
            lbRLAppId.Text = "???";
            lbOLID.Text = "???";
            pictureBox1.Image = Resources.person_boy1;

            textBox1.Text = "";
        }
        public void Loaddata(int id,int NewId=-1,int Appid=-1)
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
            lbbirth.Text=person.BirthOfDate.ToShortDateString();
            lbGender.Text = person.Gendor==0 ? "Male" : "Female";
            if (string.IsNullOrEmpty(person.ImagePath))
            {
                pictureBox1.Image = Resources.person_boy1;

            }
            else
            {
                pictureBox1.ImageLocation = person.ImagePath;
            }

            lbclassLicense.Text = clsLicensesClassesBess.GetClassById(clsLicense.LicenseClass).Name;
            lbDriverid.Text=clsLicense.DriverID.ToString();
            lblicenseid.Text=clsLicense.LicenseID.ToString();
           
            lbActive.Text = clsLicense.IsActive ? "Yes" : "No";
            lbissuedate.Text= clsLicense.IssueDate.ToShortDateString();
            lbIsdetained.Text =clsDetainLicense.IsLicenseDetained(clsLicense.LicenseID)?"Yes":"No";
            lbIssueReason.Text = clsFunsHelper.GetReasonById(clsLicense.IssueReason);
            lbNotes.Text= clsLicense.Notes;
            lbExpiration.Text= clsLicense.ExpirationDate.ToShortDateString();



            lbIssueDateToApp.Text = DateTime.Now.Date.ToShortDateString();
            lbApplicationDate.Text = DateTime.Now.ToShortDateString();
            lbOLID.Text = clsLicense.LicenseID.ToString();
            lbuser.Text = clsGlobalUser.UserName;
            lbLicenseFess.Text = clsLicensesClassesBess.GetClassById(clsLicense.LicenseClass).Fees.ToString();
           
            lbAppFess.Text = clsTypeAppBess.GetApp(2).Fees.ToString();
            lbexpirationApp.Text = DateTime.Now.Date.AddYears(clsLicensesClassesBess.GetClassById(clsLicense.LicenseClass).LengthDefault).ToShortDateString ();
            double appFees = 0;
            double licenseFees = 0;

            double.TryParse(lbAppFess.Text, out appFees);
            double.TryParse(lbLicenseFess.Text, out licenseFees);

            lbtotalFees.Text = (appFees + licenseFees).ToString();
            linkLabel1.Enabled = true;
            linkLabel3.Enabled = true;
           
            button2.Enabled = true;
            if (NewId != -1 && Appid!=-1)
            {
                NewIdLicmese = NewId;
                lbRLAppId.Text = Appid.ToString();
                lbRLID.Text = NewId.ToString();
                linkLabel2.Enabled = true;

            }

        }
        private void ctrlApplicationRenewLicense_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Focus();
            linkLabel3.Enabled=false;
            linkLabel2.Enabled=false;
            linkLabel1.Enabled=false;
            button2.Enabled=false;
            Loaddata(_ID);

        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender,e);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsLincsesBess cls = clsLincsesBess.GetLincese(_ID);
            if (cls == null)
            {
                return;
            }
            int personid = clsPersonBess.GetPersonById(clsDriverBess.GetDriver(clsLincsesBess.GetLincese(_ID).DriverID).IdPerson).ID;
            if (!cls.IsActive) { MessageBox.Show("License Disactive");return; }
            if (cls.ExpirationDate.Date <= DateTime.Now.Date)
            {
                MessageBox.Show($"This License Expiration \n Expiration Date  {cls.ExpirationDate.ToShortDateString()}");
                clsApplicationBess app=new clsApplicationBess();
                app.AppState = clsApplicationBess.EnState.New;
                app.AppDate= DateTime.Now.Date;
                app.AppLastStateUpdateDate= DateTime.Now.Date;
                app.AppTypeID = 2;
                app.Fees = clsTypeAppBess.GetApp(2).Fees;
               
                app.PersonID = personid;
                app.UserID = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                app.Mode = clsApplicationBess.EnMode.Add;
                if (app.Save())
                {
                    MessageBox.Show($"Successfully Create New Application ReNew License");
                    app.Mode = clsApplicationBess.EnMode.Update;
                    clsAppLicensesLocalBess applocal=new clsAppLicensesLocalBess();
                    applocal.IDApp = app.AppID;
                    applocal.IDClass = cls.LicenseClass;
                    if (applocal.Save())
                    {
                        clsLincsesBess NewLicense= new clsLincsesBess();
                        NewLicense.ApplicationID = app.AppID;
                        NewLicense.Notes = textBox1.Text;
                        NewLicense.CreatedByUserID = app.UserID;
                        NewLicense.DriverID = cls.DriverID;
                        NewLicense.LicenseClass= cls.LicenseClass;
                        NewLicense.ExpirationDate = DateTime.Now.Date.AddYears(clsLicensesClassesBess.GetClassById(cls.LicenseClass).LengthDefault).Date;
                        NewLicense.IssueReason = 2;
                        NewLicense.IssueDate = DateTime.Now.Date;
                        NewLicense.IsActive = true;
                        NewLicense.PaidFees = cls.PaidFees;
                        NewLicense.Mode = clsLincsesBess.EnMode.Add;
                        if (NewLicense.Save())
                        {
                            MessageBox.Show($"Done Issue New License By application Renew License\nLicnese New Id {NewLicense.LicenseID}");
                            cls.IsActive = false;
                            app.AppState = clsApplicationBess.EnState.Complated;
                            app.Save();
                            cls.Save();

                            linkLabel3.Enabled = true;
                            linkLabel2.Enabled= true;
                            Loaddata(cls.LicenseID, NewLicense.LicenseID, app.AppID);
                        }

                    }
                }
            }
            else
            {
                MessageBox.Show($"This License Not Expiration \n Expiration Date  {cls.ExpirationDate.ToShortDateString()}");

                return;
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_ID <= 0)
            {
                MessageBox.Show("License ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (NewIdLicmese == -1)
            {
                MessageBox.Show("Not Application Renew licnese");
                return;
            }
            
            Form frm = new FormShowLicenseInfo(NewIdLicmese);
            frm.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int personid = clsPersonBess.GetPersonById(clsDriverBess.GetDriver(clsLincsesBess.GetLincese(_ID).DriverID).IdPerson).ID;

            Form f = new FormShowLincese(personid);
            f.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new FormShowLicenseInfo(_ID);
            frm.ShowDialog();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        
        }

        private void maskedTextBox1_Click(object sender, EventArgs e)
        {

            linkLabel1.Enabled = false;
            linkLabel2.Enabled = false;
            linkLabel3.Enabled = false;
            button2.Enabled = false;

            _ID = -1;
            Loaddata(_ID);
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {

                linkLabel1.Enabled = false;
                linkLabel2.Enabled = false;
                linkLabel3.Enabled = false;
                button2.Enabled = false;
                DefaultView();
            }
        }
    }
}
