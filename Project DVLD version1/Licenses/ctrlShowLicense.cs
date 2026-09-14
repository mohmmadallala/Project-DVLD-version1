using BussinassLayer;
using Project_DVLD_version1.class_Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1.Licenses
{
    public partial class ctrlShowLicense : UserControl
    {
        public event Action<int> OnLicenseIDChanged;
      
        private int _ID;
        private bool IsfilterShow;

        public string textBox1Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
       
        public ctrlShowLicense(int id=-1, bool isFilterShow=false)
        {
            InitializeComponent();
            _ID = id;
            IsfilterShow = isFilterShow;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        public void LoadData(int id,bool isFilterShow=false)
        {
            _ID= id;
            IsfilterShow=isFilterShow;

            if (IsfilterShow)
            {
                textBox1.Visible = true;
                button1.Visible = true;
                groupBox2.Visible= true;
            }
            else
            {
                textBox1.Visible = false;
                button1.Visible = false;
                groupBox2.Visible = false;
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
          
            lbclass.Text = clsLicensesClassesBess.GetClassById(Convert.ToInt16(license.LicenseClass)).Name;
            lbName.Text = person.FullName();
            lbNational.Text = person.NationNo;
            lblicID.Text = license.LicenseID.ToString();
            lbnotes.Text = license.Notes;
            lbreasion.Text = clsFunsHelper.GetReasonById(license.IssueReason);
            lbIssuedate.Text = license.IssueDate.ToShortDateString();
            lbexpiration.Text = license.ExpirationDate.ToShortDateString();
            lbgender.Text = person.Gendor == 0 ? "Male" : "Female";
            lbactive.Text = license.IsActive ? "Yes" : "No";
            lbbearthdate.Text = person.BirthOfDate.ToShortDateString();
            lbDriverid.Text = driver.ID.ToString();
            lbdetained.Text = clsDetainLicense.IsLicenseDetained(license.LicenseID) ? "Yes" : "No"; ;
            if (!string.IsNullOrEmpty(person.ImagePath))
            {
                pictureBox2.ImageLocation = person.ImagePath;
            }
            else
            {
                pictureBox2.ImageLocation = null;
            }
            lbName.ForeColor = Color.Red;
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
                  
                    clsLincsesBess cls=clsLincsesBess.GetLincese(id);
                    if (cls.LicenseClass==3 )
                    {
                        errorProvider1.SetError(textBox1, "");
                        LoadData(id, IsfilterShow);

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
                    e.Cancel= true;
                }

            }
            else
            {
                errorProvider1.SetError(textBox1,"Please enter a valid numeric ID.");
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
    }
}
