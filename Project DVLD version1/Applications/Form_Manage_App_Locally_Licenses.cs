using BussinassLayer;
using Project_DVLD_version1.Licenses;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_DVLD_version1
{
    public partial class Form_Manage_App_Locally_Licenses : Form
    {
        public Form_Manage_App_Locally_Licenses()
        {
            InitializeComponent();
        }
        private DataTable dt;
        private void Form_Manage_App_Locally_Licenses_Load(object sender, EventArgs e)
        {
            FullCom2();
            dt = clsQueryMultiBess.GetQueryCombosation1();
            dt.Columns["LocalDrivingLicenseApplicationID"].ColumnName = "L.D.L App ID";
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            foreach (DataColumn i in dt.Columns)
            {
                if (i.ColumnName.ToString().Contains("FullName") || i.ColumnName.ToString().Contains("ID") || i.ColumnName.ToString().Contains("No")
                    || i.ColumnName.ToString().Contains("Status"))
                {
                    comboBox1.Items.Add(i.ColumnName);
                }
            }
            comboBox1.SelectedIndex = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void modifyInfoApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_Show_Info_App_local(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value),false);
            f.ShowDialog();
        }
        private void FullCom2()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("All");
            comboBox2.Items.Add("New");
            comboBox2.Items.Add("Canceled");
            comboBox2.Items.Add("Completed");
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columnName = comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedItem.ToString().Contains("Status"))
            {

                
                if (comboBox2.SelectedIndex==0)
                {
                    dt.DefaultView.Sort = columnName + " ASC";
                    dt.DefaultView.RowFilter = columnName ="";
                }
                else if (comboBox2.SelectedIndex==1)
                {
                    dt.DefaultView.Sort = columnName + " ASC";
                    dt.DefaultView.RowFilter = columnName + " = 'New'";
                }
                else if (comboBox2.SelectedIndex==2)
                {
                    dt.DefaultView.Sort = columnName + " ASC";
                    dt.DefaultView.RowFilter = columnName + " = 'Canceled'";
                }
                else
                {
                    dt.DefaultView.Sort = columnName + " ASC";
                    dt.DefaultView.RowFilter = columnName + " = 'Completed'";
                }

                dataGridView1.DataSource = dt.DefaultView;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columnName = comboBox1.SelectedItem.ToString();
            if (comboBox1.SelectedItem.ToString().Contains("ID"))
            {
                maskedTextBox1.Visible = true;
                comboBox2.Visible = false;
               
            }
            else if (comboBox1.SelectedItem.ToString().Contains("Status"))
            {
                comboBox2.Visible = true;
                maskedTextBox1.Visible= false;
                FullCom2();
               
            }
            else
            {
                maskedTextBox1.Visible = true;
                comboBox2.Visible = false;
                
            }
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            string columnName = comboBox1.SelectedItem?.ToString();

            if (columnName == null)
                return;

            if (columnName.Contains("ID"))
            {
                if (string.IsNullOrEmpty(maskedTextBox1.Text))
                {
                    maskedTextBox1.Text = null;
                    dt = clsQueryMultiBess.GetQueryCombosation1();
                    dt.Columns["LocalDrivingLicenseApplicationID"].ColumnName = "L.D.L App ID";
                    dt.DefaultView.Sort = comboBox1.SelectedItem.ToString();
                }
                else
                {
                    dt.DefaultView.Sort = columnName + " ASC";
                    dt.DefaultView.RowFilter = $"[{columnName}]" + " = " + Convert.ToInt16(maskedTextBox1.Text);

                }
            }
            else if (columnName.Contains("Status"))
            {
                // لاحقاً حسب الحالة
            }
            else
            {
                dt.DefaultView.Sort = columnName + " ASC";
                dt.DefaultView.RowFilter = columnName + " LIKE '%" + maskedTextBox1.Text + "%'";
            }

            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Form_Add_New_License_locally(-1);
            f.ShowDialog(this);
            dt = clsQueryMultiBess.GetQueryCombosation1();
            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void estoricalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (clsTestAppointmentBess.IsExistByLocalId(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)))
            {
                if (MessageBox.Show("Are you sure you want to delete this test appointment?",
                    "Confirm",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    clsTestAppointmentBess.DeleteAppByLocalId(
                        Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    int applicationID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    int passedTests = clsTestApplicationBess.PassedTestsCount(applicationID);

                    bool cancel = true;

                    // إذا كان هناك اختبارات ناجحة اطلب تأكيد المستخدم
                    if (passedTests > 0)
                    {
                        cancel = MessageBox.Show(
                            $"This Local Application contains {passedTests} passed test(s).\n\nAre you sure you want to cancel it?",
                            "Confirm",
                            MessageBoxButtons.OKCancel,
                            MessageBoxIcon.Question) == DialogResult.OK;
                    }

                    if (!cancel)
                    {
                        MessageBox.Show("Operation cancelled.");

                    }

                    // تنفيذ الإلغاء مرة واحدة فقط
                    if (clsQueryMultiBess.ChangeStatusApplication(applicationID, 2))
                    {
                        MessageBox.Show($"Application #{applicationID} was cancelled successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel the application.");
                    }


                    dataGridView1.DataSource = clsQueryMultiBess.GetQueryCombosation1();

                }
                else
                {
                    MessageBox.Show("Not Operation delete Appointment");
                }
            }
            else
            {
                int applicationID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                int passedTests = clsTestApplicationBess.PassedTestsCount(applicationID);

                bool cancel = true;

                // إذا كان هناك اختبارات ناجحة اطلب تأكيد المستخدم
                if (passedTests > 0)
                {
                    cancel = MessageBox.Show(
                        $"This Local Application contains {passedTests} passed test(s).\n\nAre you sure you want to cancel it?",
                        "Confirm",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question) == DialogResult.OK;
                }

                if (!cancel)
                {
                    MessageBox.Show("Operation cancelled.");

                }

                // تنفيذ الإلغاء مرة واحدة فقط
                if (clsQueryMultiBess.ChangeStatusApplication(applicationID, 2))
                {
                    MessageBox.Show($"Application #{applicationID} was cancelled successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to cancel the application.");
                }


                dataGridView1.DataSource = clsQueryMultiBess.GetQueryCombosation1();
            }
            
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (clsQueryMultiBess.DeleteApplicationLocalLicense(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)))
            {
                MessageBox.Show("Successfully Delete Local Licens Application");
            }
            else
            {
                if (clsTestAppointmentBess.IsExistByLocalId(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)))
                {
                    if (clsTestApplicationBess.DeleteAllTrstsBylocalID(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("Successfully Delete All Tests");
                        if (clsTestAppointmentBess.DeleteAppByLocalId((Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value))))
                        {
                            MessageBox.Show("Successfully Delete Appointment Realted with Application local");
                            if (clsQueryMultiBess.DeleteApplicationLocalLicense(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)))
                            {
                                MessageBox.Show("Successfully Delete Local Licens Application");
                            }
                            else
                            {
                                MessageBox.Show("Not Successfully Delete Local Application License because ; " +
                        "\n {Order Completed or New} this is current Status" + $"{dataGridView1.CurrentRow.Cells[6].Value} and ID : {dataGridView1.CurrentRow.Cells[0].Value}" +
                        $"");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Not Successfuly Delete Appointment realted with Application locla");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not Successfully Delete All Tests");

                    }
                   
                }
                else
                {
                    if (clsQueryMultiBess.DeleteApplicationLocalLicense(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)))
                    {
                        MessageBox.Show("Successfully Delete Local Licens Application");
                    }
                    else
                    {
                        MessageBox.Show("Not Successfully Delete Local Application License because ; " +
                "\n {Order Completed or New} this is current Status" + $"{dataGridView1.CurrentRow.Cells[6].Value} and ID : {dataGridView1.CurrentRow.Cells[0].Value}" +
                $"");
                    }
                }
                
            }
            dataGridView1.DataSource = clsQueryMultiBess.GetQueryCombosation1();

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextMenuStrip1.Items[3].Enabled = true;
            contextMenuStrip1.Items[2].Enabled = true;
            contextMenuStrip1.Items[0].Enabled = true;
            contextMenuStrip1.Items[1].Enabled = true;
            contextMenuStrip1.Items[4].Enabled = true;
            contextMenuStrip1.Items[5].Enabled = true;
            contextMenuStrip1.Items[6].Enabled = true;
            ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[0].Enabled = true;
            ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[1].Enabled = true;
            ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[2].Enabled = true;

            if (clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)).IDApp).AppState == clsApplicationBess.EnState.Cancel)
            {
                contextMenuStrip1.Items[4].Enabled = false;
                contextMenuStrip1.Items[6].Enabled = false;
                contextMenuStrip1.Items[5].Enabled = false;
            }

            else {
                if (clsTestApplicationBess.PassedTestsCount(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)) == 3)
                {
                    contextMenuStrip1.Items[4].Enabled = false;
                    contextMenuStrip1.Items[6].Enabled = false;
                    contextMenuStrip1.Items[5].Enabled = true;
                }
                else
                {
                    contextMenuStrip1.Items[6].Enabled = false;
                    contextMenuStrip1.Items[5].Enabled = false;
                    if (clsQueryMultiBess.IsSuccessInFirstTest(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value), 1))
                    {
                        ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[0].Enabled = false;
                        
                        if (clsQueryMultiBess.IsSuccessInFirstTest(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value), 2))
                        {

                            ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[1].Enabled = false;
                            if (clsQueryMultiBess.IsSuccessInFirstTest(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value), 3))
                            {
                                ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[2].Enabled = false;
                            }
                            else
                            {
                                ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[2].Enabled = true;
                            }
                        }
                        else
                        {
                            ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[1].Enabled = true;
                            ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[2].Enabled = false;
                        }

                    }
                    else
                    {
                        ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[0].Enabled = true;
                        ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[1].Enabled = false;
                        ((ToolStripMenuItem)contextMenuStrip1.Items[4]).DropDownItems[2].Enabled = false;
                        contextMenuStrip1.Items[6].Enabled =false;
                        contextMenuStrip1.Items[5].Enabled = false;
                    }
                  
                }
            }
           
            if (clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)).IDApp).AppState == clsApplicationBess.EnState.Complated)
            {
                int LocalLicenseID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                clsAppLicensesLocalBess localLicense = clsAppLicensesLocalBess.GetLicenseLocal(LocalLicenseID);

                clsApplicationBess application = clsApplicationBess.GetApplication(localLicense.IDApp);

                clsDriverBess driver = clsDriverBess.GetDriverByPersonID(application.PersonID);

                bool HasLicense = clsLincsesBess.IsHaveLicense(driver.ID,localLicense.IDClass);
                if (HasLicense)
                {
                    contextMenuStrip1.Items[5].Enabled=false;
                    contextMenuStrip1.Items[6].Enabled = true;
                }
                contextMenuStrip1.Items[3].Enabled = false;
                contextMenuStrip1.Items[2].Enabled = false;          
                contextMenuStrip1.Items[0].Enabled = true;
                contextMenuStrip1.Items[1].Enabled = false;
                contextMenuStrip1.Items[4].Enabled = false;
           
            }
            
            
        }

        private void scheduleVesionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_Show_Info_App_local(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value),true);
            f.ShowDialog();
        }

        private void scheduleTestsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_Show_Info_App_local(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value), true);
            f.ShowDialog();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_Show_Info_App_local(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value), true);
            f.ShowDialog();
        }

        private void showPersonLicenseHToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int idperson = clsPersonBess.GetPersonByNationalNo(dataGridView1.CurrentRow.Cells[2].Value.ToString()).ID;
            if (clsDriverBess.IsDriver(clsDriverBess.GetDriverByPersonID(idperson).ID))
            {
                Form f = new FormShowLincese(idperson);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Not Driver");
            }
           
        }

        private void showLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int number = -1;
            clsAppLicensesLocalBess cls = clsAppLicensesLocalBess.GetLicenseLocal(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)) ;
            clsApplicationBess clsApplicationBess = clsApplicationBess.GetApplication(cls.IDApp);
            number = clsApplicationBess.AppID;
            number=clsLincsesBess.GetLinceseByApplicationID(number).LicenseID;
            MessageBox.Show($"{number}");
            Form f = new FormShowLicenseInfo(number);
            f.ShowDialog(); 
        }
       
        private void issueDrivingLicenesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)).IDApp).AppState == clsApplicationBess.EnState.New &&
                clsTestApplicationBess.PassedTestsCount(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)) ==3 )
            {
                int idperosn= clsPersonBess.GetPersonByNationalNo(Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value)).ID;
                if (clsDriverBess.IsDriverByPersonId(idperosn))
                {
                    MessageBox.Show("The Person Already Driver");

                    Form f = new FormShowLicenseToDriver(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    f.ShowDialog();

                   
                    return;
                }
                clsDriverBess cls = new clsDriverBess();
                cls.CreateDate = DateTime.Now;
                cls.UserId = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                cls.IdPerson = idperosn;
                if (cls.Save())
                {
                    MessageBox.Show("Successfully Insert New Driver");
                    Form f = new FormShowLicenseToDriver(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                    f.ShowDialog();
                    return;
                }
                else
                {
                    MessageBox.Show("Not Successfully insert to Drivers");
                }
            }
            {

            }
        }
    }
}
