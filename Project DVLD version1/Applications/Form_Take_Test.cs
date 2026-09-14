using BussinassLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design.Serialization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1
{
    public partial class Form_Take_Test : Form
    {
        public int IdRetake {  get; set; }
        public Form_Take_Test()
        {
            InitializeComponent();
            ID = -1;
            IdAppoint = -1;
            IdRetake = -1;
        }
        public Form_Take_Test(int id,int local,int testid,int idretake)
        {
            InitializeComponent();
            ID = id;
            IdAppoint = local;
            this.testid = testid;
            this.IdRetake = idretake;

        }
        public int testid { get; set; }
        public int ID { get; set; }
        public int IdAppoint { get; set; }
        clsTestApplicationBess cls;
        clsTestAppointmentBess clsAppoint;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form_Take_Test_Load(object sender, EventArgs e)
        {
            if (testid == 1)
            {
                lbtestid.Text = "Test Vesion";
                
            }
            else if(testid==2) {
                lbtestid.Text = "Test write";
            }
            else
            {
                lbtestid.Text = "Test Street";
            }
            lbtestid.Font = new Font(lbtestid.Font.FontFamily, 14);
            lbtestid.ForeColor = Color.Red;
            if (ID == -1)
            {
                clsAppoint = clsTestAppointmentBess.GetApp(IdAppoint);
                int idlocal = clsTestAppointmentBess.GetApp(IdAppoint).LocalAppID;
                LbID.Text = clsAppoint.LocalAppID.ToString();
                lbClass.Text = clsLicensesClassesBess.GetClassById(clsAppLicensesLocalBess.GetLicenseLocal(clsAppoint.LocalAppID).IDClass).Name;
                lbtrail.Text = clsTestApplicationBess.FailedTestsCount(idlocal, clsTestApplicationBess.PassedTestsCount(idlocal) + 1).ToString();
                lbdate.Text = clsAppoint.DateAppointment.ToShortDateString();
                lbFees.Text = clsAppoint.Feeds.ToString();
                lbname.Text = clsPersonBess.GetPersonById(clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(clsAppoint.LocalAppID).IDApp).PersonID).FullName();
               
            }
            else
            {
                cls = clsTestApplicationBess.Find(ID);
                clsAppoint = clsTestAppointmentBess.GetApp(IdAppoint);
                lbtest.Text = cls.TestId.ToString();
                LbID.Text = clsAppoint.LocalAppID.ToString();
                lbClass.Text = clsLicensesClassesBess.GetClassById(clsAppLicensesLocalBess.GetLicenseLocal(clsAppoint.LocalAppID).IDClass).Name;
                lbtrail.Text = clsTestApplicationBess.FailedTestsCount(clsAppoint.LocalAppID, clsTestApplicationBess.PassedTestsCount(clsAppoint.LocalAppID)).ToString();
                lbdate.Text = clsTestAppointmentBess.GetApp(cls.TestAppointment).DateAppointment.ToShortTimeString();
                lbFees.Text = clsTestAppointmentBess.GetApp(cls.TestAppointment).Feeds.ToString();
                lbname.Text = clsPersonBess.GetPersonById(clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(clsAppoint.LocalAppID).IDApp).PersonID).FullName();
                textBox1.Text = cls.Nots.ToString();
                if (radioButton1.Checked)
                {
                    cls.ResultTest = true;
                }
                else
                {
                    cls.ResultTest= false;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (ID == -1)
            {
                cls = new clsTestApplicationBess();
                cls.ResultTest = radioButton1.Checked;
                cls.Nots = textBox1.Text;
                cls.UserId = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                cls.TestAppointment = clsAppoint.ID;
            }
            else
            {
                cls = clsTestApplicationBess.Find(ID);

                if (cls == null)
                {
                    return;
                }
                else
                {
                    cls.ResultTest = radioButton1.Checked;
                    cls.Nots = textBox1.Text;
                    cls.UserId = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                    cls.TestAppointment = clsAppoint.ID;
                }
            }
            if (cls.Save())
            {
                // قفل الموعد بعد إدخال النتيجة
                clsAppoint.IsLocked = true;
                clsAppoint.Save();
               

                MessageBox.Show(
                    "Test saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                lbtest.Text = cls.TestId.ToString();
                //if (testid == 3 && radioButton1.Checked)
                //{
                //    int id = clsAppLicensesLocalBess.GetLicenseLocal(clsTestAppointmentBess.GetApp(IdAppoint).LocalAppID).IDLicense;
                    
                //    clsApplicationBess clsApp= clsApplicationBess.GetApplication(id);
                    
                //    clsQueryMultiBess.ChangeStatusApplication(id, 3);
                   
                //    // must After Add on to list Drivers
                  
                //}
                clsApplicationBess clsretaketest;
                if (IdRetake == -1)
                {
                    clsretaketest = new clsApplicationBess();
                   
                }
                else
                {
                    clsretaketest = clsApplicationBess.GetApplication(IdRetake);
                    clsretaketest.Mode = clsApplicationBess.EnMode.Update;
               
                    
                    if (radioButton2.Checked)
                    {

                        clsretaketest.AppState = clsApplicationBess.EnState.Cancel;
                       
                    }
                    else
                    {
                        
                        clsretaketest.AppState = clsApplicationBess.EnState.Complated;
                        
                    }
                    clsretaketest.Save();
                }
               
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Failed to save the test.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}
