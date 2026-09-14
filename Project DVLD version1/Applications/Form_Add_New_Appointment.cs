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
    public partial class Form_Add_New_Appointment : Form
    {
     
        public int ID;
 
        clsTestAppointmentBess _cls;
        public int IDlocal { get; set; }
        public bool Mode {  get; set; }
        clsAppLicensesLocalBess cls;
        private Form_Add_New_Appointment()
        {
            InitializeComponent();
            ID = -1;
            IdAppRetaketest = -1;
            IDlocal = -1;
            Mode=false;
        }
        public Form_Add_New_Appointment(int id, int iDlocal,int idretake, bool mode)
        {
            InitializeComponent();
            ID = id;
            IDlocal = iDlocal;
            IdAppRetaketest = idretake;
            Mode = mode;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        public int IdAppRetaketest { get; set; }
        private clsApplicationBess _clsRetake;
        private void Form_Add_New_Appointment_Load(object sender, EventArgs e)
        {
           
            if (IDlocal == -1)
            {
                return;
            }
            else
            {
                _cls = clsTestAppointmentBess.GetApp(ID);

                if (_cls != null)
                {
                    if (_cls.IsLocked)
                    {
                        button1.Enabled = false;
                        dateTimePicker1.Enabled = false;
                        label8.Visible = true;
                    }
                    else
                    {
                        button1.Enabled = true;
                        dateTimePicker1.Enabled = true;
                        label8.Visible = false;
                    }
                }
                else
                {
                    button1.Enabled = true;
                    dateTimePicker1.Enabled = true;
                    label8.Visible = false;
                }
               
                cls = clsAppLicensesLocalBess.GetLicenseLocal(IDlocal);
                if (cls == null)
                {
                    return;
                }
                else
                {
                    LbID.Text = cls.IDLicense.ToString();
                    lbClass.Text = clsLicensesClassesBess.GetClassById(cls.IDClass).Name.ToString();
                    lbname.Text = clsPersonBess.GetPersonById(clsApplicationBess.GetApplication(cls.IDApp).PersonID).FullName().ToString();
                    lbtrail.Text = clsTestApplicationBess.FailedTestsCount(IDlocal, clsTestApplicationBess.PassedTestsCount(IDlocal)+1).ToString();
                    if (ID == -1)
                    {
                        dateTimePicker1.MinDate = DateTime.Now;
                        dateTimePicker1.MaxDate = DateTime.Now.AddDays(10);
                        dateTimePicker1.Value = DateTime.Now;
                    }
                    else
                    {
                        dateTimePicker1.MinDate = clsTestAppointmentBess.GetApp(ID).DateAppointment;
                        dateTimePicker1.MaxDate = DateTime.Now.AddDays(10);
                        dateTimePicker1.Value = clsTestAppointmentBess.GetApp(ID).DateAppointment;
                    }
                    lbFees.Text = clsTestBess.GetTest(clsTestApplicationBess.PassedTestsCount(IDlocal)+1).Fees.ToString();
                    if (clsTestApplicationBess.FailedTestsCount(IDlocal, clsTestApplicationBess.PassedTestsCount(IDlocal) + 1) == 0)
                    {
                        ctrl_Add_new_App_retake_test1.Visible = false;

                    }
                    else
                    {
                        if (Mode)
                        {
                            ctrl_Add_new_App_retake_test1.Visible = true;
                            ctrl_Add_new_App_retake_test1.FeesApplocal = Convert.ToDouble(lbFees.Text);
                            int idperson = clsPersonBess.GetPersonById(clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(IDlocal).IDApp).PersonID).ID;


                            if (IdAppRetaketest == -1)
                            {
                                _clsRetake = new clsApplicationBess();
                                _clsRetake.AppState = clsApplicationBess.EnState.New;
                                _clsRetake.AppDate = DateTime.Now;
                                _clsRetake.Fees = clsTypeAppBess.GetApp(1010).Fees;
                                _clsRetake.AppLastStateUpdateDate = DateTime.Now;
                                _clsRetake.AppTypeID = 1010;
                                _clsRetake.Mode = clsApplicationBess.EnMode.Add;
                                _clsRetake.UserID = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                                _clsRetake.PersonID = idperson;
                                ctrl_Add_new_App_retake_test1.FeesApplocal = clsTestBess.GetTest(clsTestApplicationBess.PassedTestsCount(IDlocal) + 1).Fees;
                                ctrl_Add_new_App_retake_test1.ID = _clsRetake.AppID;
                                //MessageBox.Show(ctrl_Add_new_App_retake_test1.FeesApplocal.ToString());
                                ctrl_Add_new_App_retake_test1.LoadData();
                            }
                            else
                            {
                                _clsRetake = clsApplicationBess.GetApplication(IdAppRetaketest);
                                _clsRetake.Mode = clsApplicationBess.EnMode.Update;

                                _clsRetake.AppState = clsApplicationBess.EnState.New;
                                _clsRetake.AppDate = DateTime.Now;
                                _clsRetake.Fees = clsTypeAppBess.GetApp(1010).Fees;
                                _clsRetake.AppLastStateUpdateDate = DateTime.Now;
                                _clsRetake.AppTypeID = 1010;
                                _clsRetake.UserID = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                                _clsRetake.PersonID = idperson;
                                ctrl_Add_new_App_retake_test1.FeesApplocal = clsTestBess.GetTest(clsTestApplicationBess.PassedTestsCount(IDlocal) + 1).Fees;
                                ctrl_Add_new_App_retake_test1.ID = _clsRetake.AppID;
                            }


                            if (_clsRetake.Save())
                            {
                                MessageBox.Show("Done Insert into list Retake Test");
                            }
                            else
                            {
                                MessageBox.Show("Not Done Insert");
                            }

                        }
                    }
                }
            }
         

            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ID == -1)
            {
                _cls = new clsTestAppointmentBess();

                _cls.LocalAppID = IDlocal;
                _cls.DateAppointment = dateTimePicker1.Value;
                _cls.TypeTest = clsTestBess.GetTest(
                    clsTestApplicationBess.PassedTestsCount(IDlocal) + 1).ID;
             //   MessageBox.Show($"count passed Test type --> {clsTestApplicationBess.PassedTestsCount(IDlocal)}");
                _cls.Feeds = clsTestBess.GetTest(
                    clsTestApplicationBess.PassedTestsCount(IDlocal) + 1).Fees;

                _cls.userId = clsApplicationBess.GetApplication(cls.IDApp).UserID;
                _cls.IsLocked = false;

                if (_cls.Save())
                    MessageBox.Show("Appointment saved successfully.");
                else
                    MessageBox.Show("Failed to save appointment.");
            }
            else
            {
               

               

                if (_cls != null)
                {
                    _cls.DateAppointment = dateTimePicker1.Value;
                    _cls.Mode = clsTestAppointmentBess.EnMode.Update;
                   // MessageBox.Show(_cls.ID.ToString());
                    if (_cls.Save())
                    {
                        MessageBox.Show("Appointment updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the appointment.");
                    }
                }
                else
                {
                    MessageBox.Show("Appointment not found.");
                }
            }
            this.Close();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
