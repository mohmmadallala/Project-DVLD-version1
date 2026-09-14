using BussinassLayer;
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
    public partial class ctrlShowInfoLicenseInternational : UserControl
    {
        private int _ID;
        public ctrlShowInfoLicenseInternational()
        {
            InitializeComponent();
            _ID = -1;
        }
        public ctrlShowInfoLicenseInternational(int id)
        {
            InitializeComponent();
            _ID = id;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        public void LoadData(int id)
        {
            _ID = id;
            if (_ID == -1)
            {
                return;
            }
            clsLicenseInternationalBess cls = clsLicenseInternationalBess.Find(_ID);
            if (cls != null)
            {
                clsPersonBess clsPerson = clsPersonBess.GetPersonById(clsDriverBess.GetDriver(cls.DriverID).IdPerson);
                if (clsPerson != null)
                {


                    lbIssuedate.Text = cls.IssueDate.ToString("dd/MM/yyyy");
                    lbExpiration.Text = cls.ExpirationDate.ToString("dd/MM/yyyy");
                    lbLicenseid.Text = cls.IssuedUsingLocalLicenseID.ToString();
                    lbactive.Text = cls.IsActive ? "Yes" : "No";
                    lbIntLicense.Text = cls.InternationalLicenseID.ToString();
                    lbdriver.Text = cls.DriverID.ToString();
                    lbAppId.Text = cls.ApplicationID.ToString();
                    lbname.Text = clsPerson.FullName();
                    lbnationNo.Text = clsPerson.NationNo;
                    lbgender.Text = clsPerson.Gendor == 0 ? "Male" : "Female";
                    lbbirth.Text = clsPerson.BirthOfDate.ToString("dd/MM/yyyy");
                    pictureBox1.ImageLocation = clsPerson.ImagePath;
                }
            }
        }
        private void ctrlShowInternationa_Lecinse_Load(object sender, EventArgs e)
        {
           
        }
    }
}
