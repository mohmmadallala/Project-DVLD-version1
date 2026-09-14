using BussinassLayer;
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

namespace Project_DVLD_version1.international
{
    public partial class ctrlShowInternationalLicense : UserControl
    {
        private bool IsIssue;
        public event Action<int> OnLicenseIDChanged;
        private int personid;
        private int _ID;
        private bool IsfilterShow;
        private clsLicenseInternationalBess clsLicenseInternationalBess;

        // ✅ المُنشئ الافتراضي (بدون معاملات) - ضروري للـ Designer
        public ctrlShowInternationalLicense()
        {
            InitializeComponent();
            _ID = -1;
            IsfilterShow = false;
            IsIssue = false;
        }

        // المُنشئ مع المعاملات
        public ctrlShowInternationalLicense(int id = -1, bool isFilterShow = false, bool IsIssue = false)
        {
            InitializeComponent();
            _ID = id;
            IsfilterShow = isFilterShow;
            this.IsIssue = IsIssue;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        public void LoadData(int id, bool isFilterShow = false, bool ISIssue = false)
        {
            _ID = id;
            IsfilterShow = isFilterShow;
            this.IsIssue = ISIssue;

            if (IsfilterShow)
            {
                textBox1.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                groupBox2.Visible = true;
                linkLabel2.Visible = true;
                linkLabel1.Visible = true;
                foreach (Control control in groupBox3.Controls)
                {
                    control.Visible = true;
                }
                groupBox3.Visible = true;
            }
            else
            {
                foreach (Control control in groupBox3.Controls)
                {
                    control.Visible = false;
                }
                groupBox3.Visible = false;
                textBox1.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                groupBox2.Visible = false;
                linkLabel2.Visible = false;
                linkLabel1.Visible = false;
            }

            if (id == -1)
            {
                return;
            }

            clsLincsesBess license = clsLincsesBess.GetLincese(id);

            if (license == null)
            {
                return;
            }
            if (!license.IsActive)
            {
                button2.Enabled= false;
            }
            else
            {
                button2.Enabled = true;
            }
            clsDriverBess driver = clsDriverBess.GetDriver(license.DriverID);

            if (driver == null)
            {
                return;
            }

            clsPersonBess person = clsPersonBess.GetPersonById(driver.IdPerson);
            if (person == null)
            {
                return;
            }

            OnLicenseIDChanged?.Invoke(_ID);
            personid = person.ID;
            lbclass.Text = clsLicensesClassesBess.GetClassById(Convert.ToInt16(license.LicenseClass)).Name;
            lbName.Text = person.FullName();
            lbNational.Text = person.NationNo;
            lblicID.Text = license.LicenseID.ToString();
            lbnotes.Text = license.Notes;
            lbreasion.Text = license.IssueReason.ToString();
            lbIssuedate.Text = license.IssueDate.ToShortDateString();
            lbexpiration.Text = license.ExpirationDate.ToShortDateString();
            lbgender.Text = person.Gendor == 0 ? "Male" : "Female";
            lbactive.Text = license.IsActive ? "Yes" : "No";
            lbbearthdate.Text = person.BirthOfDate.ToShortDateString();
            lbDriverid.Text = driver.ID.ToString();
            lbdetained.Text = "in future";

            if (!string.IsNullOrEmpty(person.ImagePath))
            {
                pictureBox2.ImageLocation = person.ImagePath;
            }
            else
            {
                pictureBox2.ImageLocation = null;
            }

            lbName.ForeColor = Color.Red;
            lbUser.Text = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID.ToString();
            lbIssue.Text = DateTime.Now.Date.ToString();
            lbExpirationDate.Text = DateTime.Now.AddYears(clsLicensesClassesBess.GetClassById(license.LicenseClass).LengthDefault).Date.ToString();
            lbAppdate.Text = DateTime.Now.Date.ToString();
            lbFees.Text = clsTypeAppBess.GetApp(6).Fees.ToString();
            lblocalID.Text = license.LicenseID.ToString();

            if (IsIssue && IsfilterShow)
            {
                clsApplicationBess clsapp = clsApplicationBess.GetApplicationByinternational(person.ID, 6, 1);
                if (clsapp != null)
                {
                    lbILApp.Text = clsapp.AppID.ToString();
                    clsLicenseInternationalBess clsinternational = clsLicenseInternationalBess.FindByApplicationID(clsapp.AppID);
                    if (clsinternational != null)
                    {
                        lbILLicenseId.Text = clsinternational.InternationalLicenseID.ToString();
                    }
                }
            }
        }

        private void ctrlShowLicense_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int id))
            {
                if (clsLincsesBess.IsExsit(id))
                {
                    clsLincsesBess cls = clsLincsesBess.GetLincese(id);
                    if (cls.LicenseClass == 3)
                    {
                        errorProvider1.SetError(textBox1, "");
                        LoadData(id, IsfilterShow, IsIssue);
                        linkLabel2.Enabled = true;
                        linkLabel1.Enabled = true;
                        e.Cancel = false;
                    }
                    else
                    {
                        errorProvider1.SetError(textBox1, "Not Have License class 3 OR not Active Or Expiration Date");
                        LoadData(id, IsfilterShow);
                        e.Cancel = true;
                    }
                }
                else
                {
                    errorProvider1.SetError(textBox1, "License ID does not exist.");
                    e.Cancel = true;
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Please enter a valid numeric ID.");
                e.Cancel = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1_Validating(sender, new CancelEventArgs());
            }
        }

        private void ctrlShowInternationalLicense_Load(object sender, EventArgs e)
        {
            linkLabel2.Enabled = false;
            linkLabel1.Enabled = false;
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsLincsesBess license = clsLincsesBess.GetLincese(_ID);
           
            clsLicenseInternationalBess inter = clsLicenseInternationalBess.FindByLocalLicense(license.LicenseID);
            if (inter != null)
            {
                if (inter.IsActive )
                {
                    MessageBox.Show("This license has Active License.");
                    return;
                }
                if(inter.ExpirationDate > DateTime.Now.Date)
                {
                    MessageBox.Show("This license has Not Expiration Date");
                    return;
                }
                
            }
            if (clsLicenseInternationalBess.IsExistByDriverIdAndIsActive(license.DriverID))
            {
                MessageBox.Show($"the Driver Have Already License International");
                return;
            }

            if (license != null)
            {
                
                if (clsLicenseInternationalBess.IsExistByDriverIdAndIsActive(license.DriverID))
                {
                    clsLincsesBess localid = clsLincsesBess.GetLincese(_ID);
                    if (localid == null)
                    {
                        MessageBox.Show("Selected license not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }



                    clsLicenseInternationalBess intlinces = clsLicenseInternationalBess.FindByApplicationID(localid.LicenseID);
                    MessageBox.Show($"the Driver Have International License Reachable With Local License {intlinces.IssuedUsingLocalLicenseID} \n " +
                        $"OR Disactive License OR Expiration Date License");
                    return;
                }
                if (license.IsActive && license.ExpirationDate > DateTime.Now)
                {
                    clsApplicationBess app = new clsApplicationBess();
                    app.AppState = clsApplicationBess.EnState.New;
                    app.AppLastStateUpdateDate = DateTime.Now;
                    app.AppDate = DateTime.Now;
                    app.Fees = clsTypeAppBess.GetApp(6).Fees;
                    app.AppTypeID = 6;
                    personid = clsDriverBess.GetDriver(license.DriverID).IdPerson;
                    app.PersonID = personid;
                    app.UserID = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;

                    if (app.Save())
                    {
                        MessageBox.Show("Application saved successfully.");
                        clsLicenseInternationalBess = new clsLicenseInternationalBess();
                        clsLicenseInternationalBess.ApplicationID = app.AppID;
                        clsLicenseInternationalBess.CreatedByUserID = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                        clsLicenseInternationalBess.DriverID = license.DriverID;
                        clsLicenseInternationalBess.IssueDate = DateTime.Now.Date;
                        clsLicenseInternationalBess.ExpirationDate = clsLicenseInternationalBess.IssueDate.AddYears(1);
                        clsLicenseInternationalBess.IsActive = true;
                        clsLicenseInternationalBess.IssuedUsingLocalLicenseID = license.LicenseID;

                        if (clsLicenseInternationalBess.Save())
                        {
                            MessageBox.Show("International license saved successfully.");
                            app.AppState = clsApplicationBess.EnState.Complated;
                            app.Mode = clsApplicationBess.EnMode.Update;
                            app.Save();
                            lbILApp.Text = app.AppID.ToString();
                            lbILLicenseId.Text = clsLicenseInternationalBess.InternationalLicenseID.ToString();
                        }
                        else
                        {
                            MessageBox.Show("Failed to save international license.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Failed to save application.");
                    }
                }
                else
                {
                    MessageBox.Show("The selected license is not active OR has expired Date.");
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (personid <= 0)
            {
                MessageBox.Show("Person ID is invalid.");
                return;
            }

            Form f = new FormShowLincese(personid);
            f.ShowDialog();
        }

        // ✅ الكود المعدل هنا
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lbILLicenseId.Text.Contains("???"))
            {
                if (_ID <= 0)
                {
                    MessageBox.Show("License ID is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✅ فتح النموذج مباشرة
                clsLincsesBess localid = clsLincsesBess.GetLincese(_ID);
                if (localid == null)
                {
                    MessageBox.Show("Selected license not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                clsLicenseInternationalBess intlinces = clsLicenseInternationalBess.FindByLocalLicense(localid.LicenseID);
                if (intlinces == null)
                {
                    MessageBox.Show("International license not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                lbILLicenseId.Tag = intlinces.InternationalLicenseID;
            }
            else
            {
                lbILLicenseId.Tag = lbILLicenseId.Text;
            }

           
            Form frm = new FormshowinfoInterLicense(Convert.ToInt32(lbILLicenseId.Tag));
            frm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form f = new Form_Add_New_License_locally(-1);
            f.ShowDialog(this);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                lbILApp.Text = "???";
                lbILLicenseId.Text = "???";
                linkLabel1.Enabled = false;
                linkLabel2.Enabled = false;
                lbclass.Text = "???";
                lbName.Text = "???";
                lbNational.Text = "???";
                lblicID.Text = "???";
                lbnotes.Text = "???";
                lbreasion.Text = "???";
                lbIssuedate.Text = "???";
                lbexpiration.Text = "???";
                lbgender.Text = "???";
                lbactive.Text = "???";
                lbbearthdate.Text = "???";
                lbDriverid.Text = "???";
                lbdetained.Text = "???";
                pictureBox2.Image = Resources.person_boy1;



                lbUser.Text = "???";
                lbIssue.Text = "???";
                lbExpirationDate.Text = "???";
                lbAppdate.Text = "???";
                lbFees.Text = "???";
                lblocalID.Text = "???";

            }
        }
    }
}