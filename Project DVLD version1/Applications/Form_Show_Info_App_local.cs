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
    public partial class Form_Show_Info_App_local : Form
    {
        public bool IsTest=false;
        public int ID { get; set; } = -1;
        public Form_Show_Info_App_local()
        {
            InitializeComponent();
            ID = -1;
            IsTest = false;
        }
        public Form_Show_Info_App_local(int i,bool Istest)
        {
            InitializeComponent();
            ID = i;
            IsTest= Istest;
        }

        private void Form_Show_Info_App_local_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(ID.ToString());
            ctrl_show_Infi_LocalApp1.ID = ID;
            ctrl_show_Infi_LocalApp1.LoadData(ID);
            int idApp = clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(ID).IDApp).AppID;
            //MessageBox.Show(idApp.ToString());
            ctrl_show_info_Application1.ID = idApp;
            ctrl_show_info_Application1.LoadData();
            if (IsTest)
            {
                DataTable dt = clsTestAppointmentBess.GetAllAppointments();

                int testtype = clsTestApplicationBess.PassedTestsCount(ID) + 1;
              //  MessageBox.Show($"Counter is Test passed  {testtype}");
                dt.DefaultView.RowFilter =
                    $"LocalDrivingLicenseApplicationID = {ID} and TestTypeID={testtype}";

                dataGridView1.DataSource = dt.DefaultView;
                dataGridView1.Columns.Remove("TestTypeID");
                dataGridView1.Columns.Remove("LocalDrivingLicenseApplicationID");
                dataGridView1.Columns.Remove("CreatedByUserID");
                dataGridView1.Columns["AppointmentDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            else
            {
                dataGridView1.Visible = false;
                button1.Visible = false;
                label1.Visible = false;
            }
        }

        private void ctrl_show_info_Application1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (clsTestApplicationBess.PassedTestsCount(ID) == 3) 
            {
                MessageBox.Show("The Person is completed and Passed All Tests License Local");
                return;
            }
            if (clsTestAppointmentBess.IsExistAppointmentFailedByIdlocal(ID))
            {
                MessageBox.Show(
                    "This person already has a booked test appointment that has not been used yet.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            else
            {
                int idretake = clsApplicationBess.GetApplicationRetakeTest(clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(ID).IDApp).PersonID).AppID;
                Form f = new Form_Add_New_Appointment(-1, ID, idretake,true);
                f.ShowDialog();
            }
            DataTable dt = clsTestAppointmentBess.GetAllAppointments();
            int testtype = clsTestApplicationBess.PassedTestsCount(ID)+1;
          //  MessageBox.Show($"Counter is Test passed  {testtype}");
            dt.DefaultView.RowFilter =
                $"LocalDrivingLicenseApplicationID = {ID} and TestTypeID={testtype}";

            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.Columns.Remove("TestTypeID");
            dataGridView1.Columns.Remove("LocalDrivingLicenseApplicationID");
            dataGridView1.Columns.Remove("CreatedByUserID");
            dataGridView1.Columns["AppointmentDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            ctrl_show_Infi_LocalApp1.LoadData(ID);
        }

        private void editAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void showAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_show_Info_Appointment(Convert.ToUInt16(dataGridView1.CurrentRow.Cells[0].Value));
            f.ShowDialog();
        }

        private void editAppointmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int idtemp = -1;
            idtemp= clsApplicationBess.GetApplicationRetakeTest(clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(ID).IDApp).PersonID).AppID;
            if (idtemp == -1) {
                
                MessageBox.Show("Lead to Create Anther Application Retake test");
                if (clsTestApplicationBess.FailedTestsCount(ID, (clsTestApplicationBess.PassedTestsCount(ID) + 1)) == 0)
                {
                    Form f = new Form_Add_New_Appointment(Convert.ToUInt16(dataGridView1.CurrentRow.Cells[0].Value), ID, idtemp, false);
                    f.ShowDialog();
                }
                else
                {
                    Form f = new Form_Add_New_Appointment(Convert.ToUInt16(dataGridView1.CurrentRow.Cells[0].Value), ID, idtemp,true);
                    f.ShowDialog();
                }
            }
            else
            {
                Form f = new Form_Add_New_Appointment(Convert.ToUInt16(dataGridView1.CurrentRow.Cells[0].Value), ID,idtemp, true);
                f.ShowDialog();
            }

            
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsTestAppointmentBess.GetApp(Convert.ToUInt16(dataGridView1.CurrentRow.Cells[0].Value)).DateAppointment.Date != DateTime.Now.Date)
            {
                MessageBox.Show($"Appointment date The date of the test has not yet arrived. \n " +
                    $"{clsTestAppointmentBess.GetApp(Convert.ToUInt16(dataGridView1.CurrentRow.Cells[0].Value)).DateAppointment.Date}");
                return;
            }
            if (clsTestAppointmentBess.GetApp(Convert.ToUInt16(dataGridView1.CurrentRow.Cells[0].Value)).IsLocked)
            {
                MessageBox.Show("Not Retake Test because ; is Locked Appointment Test");
            }
            else
            {
                if (clsTestApplicationBess.FailedTestsCount(ID, clsTestApplicationBess.PassedTestsCount(ID) + 1) == 0)
                {
                    Form f = new Form_Take_Test(-1, Convert.ToUInt16(dataGridView1.CurrentRow.Cells[0].Value), clsTestApplicationBess.PassedTestsCount(ID) + 1, -1);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"{clsApplicationBess.GetApplicationRetakeTest(clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(ID).IDApp).PersonID).AppID.ToString()}");
                    Form f = new Form_Take_Test(-1, Convert.ToUInt16(dataGridView1.CurrentRow.Cells[0].Value), clsTestApplicationBess.PassedTestsCount(ID) + 1, clsApplicationBess.GetApplicationRetakeTest(clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(ID).IDApp).PersonID).AppID);
                    f.ShowDialog();
                }
                DataTable dt = clsTestAppointmentBess.GetAllAppointments();

                int testtype = clsTestApplicationBess.PassedTestsCount(ID) + 1;
               
                dt.DefaultView.RowFilter =
                    $"LocalDrivingLicenseApplicationID = {ID} and TestTypeID={testtype}";

                dataGridView1.DataSource = dt.DefaultView;
                dataGridView1.Columns.Remove("TestTypeID");
                dataGridView1.Columns.Remove("LocalDrivingLicenseApplicationID");
                dataGridView1.Columns.Remove("CreatedByUserID");
                dataGridView1.Columns["AppointmentDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
                ctrl_show_Infi_LocalApp1.LoadData(ID);
            }
        }

        private void reasonFailedTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsTestAppointmentBess.GetApp(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)).IsLocked)
            {
                MessageBox.Show($"{clsTestApplicationBess.FindByIdappointment(clsTestAppointmentBess.GetApp(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)).ID).Nots}");
            }
        }
    }
}
