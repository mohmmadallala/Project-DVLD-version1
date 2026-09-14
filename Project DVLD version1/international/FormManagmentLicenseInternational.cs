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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_DVLD_version1.international
{
    public partial class FormManagmentLicenseInternational : Form
    {
        public FormManagmentLicenseInternational()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                maskedTextBox1.Visible=false;
                comboBox2.Visible = true;
            }
            else
            {
                maskedTextBox1.Visible=true;
                comboBox2.Visible = false;
            }
        }

        private void FormManagmentLicenseInternational_Load(object sender, EventArgs e)
        {
            comboBox2.Visible=false;
            maskedTextBox1.Visible = false;

            dataGridView1.DataSource=clsLicenseInternationalBess.GetAllLicenseInternational();

        }
   
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           


        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = clsLicenseInternationalBess.GetAllLicenseInternational();
            int value = 0;
            if (comboBox2.SelectedIndex == 0)
            {
                value= 1;
            }
            else
            {
                value = 0;
            }
           
            string columnName = comboBox1.SelectedItem.ToString();
           
            dt.DefaultView.RowFilter = $"{columnName} = {value}";

            dataGridView1.DataSource = dt.DefaultView;
         
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {

            int value = 0;


           
            DataTable dt = clsLicenseInternationalBess.GetAllLicenseInternational();

            string columnName = comboBox1.SelectedItem.ToString();

            if (maskedTextBox1.Text == "")
            {
                value = 0;
                dataGridView1.DataSource = clsLicenseInternationalBess.GetAllLicenseInternational();
                return;
            }
            else
            {
                value = Convert.ToInt32(maskedTextBox1.Text);
            }
            dt.DefaultView.RowFilter = $"{columnName} = {value}";

            dataGridView1.DataSource = dt.DefaultView;
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {

           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new FormInsertLicenseNewInternational(-1, true, true);
            f.ShowDialog();
        }

        private void showInfoDetailsPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idperson = clsDriverBess.GetDriver(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value)).IdPerson;
            Form f = new Form_Show_Info_Person(idperson);
            f.ShowDialog();
            dataGridView1.DataSource = clsLicenseInternationalBess.GetAllLicenseInternational();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormshowinfoInterLicense(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            f.ShowDialog();
        }

        private void showHistoryLicnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idperson = clsDriverBess.GetDriver(Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value)).IdPerson;
            Form f = new FormShowLincese(idperson);
            f.ShowDialog();
        }
    }
}




