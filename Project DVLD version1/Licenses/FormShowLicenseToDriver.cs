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

namespace Project_DVLD_version1
{
    public partial class FormShowLicenseToDriver : Form
    {
        public int Idlocal {  get; set; }
        public int IDApp { get; set; }
        public FormShowLicenseToDriver(int idlocal)
        {
            InitializeComponent();
            Idlocal= idlocal;
           
        }

        private void FormShowLicenseToDriver_Load(object sender, EventArgs e)
        {
            ctrl_show_Infi_LocalApp1.ID = Idlocal;
            ctrl_show_Infi_LocalApp1.LoadData(Idlocal);
            int idApp = clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(Idlocal).IDApp).AppID;
            //MessageBox.Show(idApp.ToString());
            ctrl_show_info_Application1.ID = idApp;
            ctrl_show_info_Application1.LoadData();
            IDApp = idApp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsLincsesBess license = new clsLincsesBess();
            license.DriverID = clsDriverBess.GetDriverByPersonID(clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(Idlocal).IDApp).PersonID).ID;
            license.ApplicationID = clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(Idlocal).IDApp).AppID;
          
            license.Notes = textBox1.Text;
            license.IssueDate = DateTime.Now;
            license.LicenseClass = clsAppLicensesLocalBess.GetLicenseLocal(Idlocal).IDClass;
            license.ExpirationDate = DateTime.Now.AddYears(clsLicensesClassesBess.GetClassById(license.LicenseClass).LengthDefault);

            license.CreatedByUserID = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
            license.IssueReason = 1;
            
            license.PaidFees = clsLicensesClassesBess.GetClassById(license.LicenseClass).Fees;
            license.IsActive = true;
            license.Mode = clsLincsesBess.EnMode.Add;
            if (license.Save())
            {
                MessageBox.Show($"Successfully Add New License Type class {license.LicenseClass}\n Number License is {license.LicenseID}");
                clsQueryMultiBess.ChangeStatusApplication(Convert.ToInt16(Idlocal), 3);
                button1_Click (sender, e);
            }
            else
            {
                MessageBox.Show("Not Successfully Add New License");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
