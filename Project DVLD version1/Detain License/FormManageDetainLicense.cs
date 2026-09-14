using BussinassLayer;
using Project_DVLD_version1.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1.Detain_License
{
    public partial class FormManageDetainLicense : Form
    {
        public FormManageDetainLicense()
        {
            InitializeComponent();
        }

        private void Refreash()
        {
            dataGridView1.DataSource = clsDetainLicense.GetAllLicensesDetainAndDataDetails();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form f=new FormAppDetainLicense();
            f.ShowDialog();
            Refreash();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new FormReleaseLicense();
            f.ShowDialog();
            Refreash();
        }

        private void FormManageDetainLicense_Load(object sender, EventArgs e)
        {
            comboBox2.Visible= false;
            Refreash();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Visible = false;
                comboBox2.Visible = true;

               
            }
            else
            {
                textBox1.Visible = true;
                comboBox2.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = clsDetainLicense.GetAllLicensesDetainAndDataDetails();

            bool val = comboBox2.SelectedIndex == 0;

            dt.DefaultView.RowFilter = $"IsReleased = {val}";
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            DataTable dt = clsDetainLicense.GetAllLicensesDetainAndDataDetails();

          
            if (comboBox1.SelectedIndex == 3)
            {
                dt.DefaultView.RowFilter = $"{comboBox1.SelectedItem} LIKE '%{textBox1.Text}%'";
                dataGridView1.DataSource = dt.DefaultView;
            }
            else
            {
                if(int.TryParse(textBox1.Text,out int id))
                {

                    dt.DefaultView.RowFilter = $"{comboBox1.SelectedItem} = {id}";
                    dataGridView1.DataSource = dt.DefaultView;
                }
                else
                {
                    return;
                }
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                dataGridView1.DataSource = clsDetainLicense.GetAllLicensesDetainAndDataDetails();
            }
            DataTable dt = clsDetainLicense.GetAllLicensesDetainAndDataDetails();
            string ColumnName = comboBox1.SelectedItem.ToString();

            if (comboBox1.SelectedIndex == 3||comboBox1.SelectedIndex==2)
            {
                dt.DefaultView.RowFilter = $"{ColumnName} LIKE '%{textBox1.Text}%'";
                dataGridView1.DataSource = dt.DefaultView;
            }
            else
            {
                if (int.TryParse(textBox1.Text, out int id))
                {

                    dt.DefaultView.RowFilter = $"{ColumnName} = {id}";
                    dataGridView1.DataSource = dt.DefaultView;
                }
                else
                {
                    return;
                }
            }
        }

        private void showDetailsPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            object value = dataGridView1.CurrentRow.Cells[6].Value;

            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return;

            clsPersonBess person =
                clsPersonBess.GetPersonByNationalNo(value.ToString());

            if (person == null)
                return;

            Form f = new Form_Show_Info_Person(person.ID);
            f.ShowDialog();
        }

        private void showDetailsLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormShowLicenseInfo(Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value));
            f.ShowDialog();
        }

        private void showHistoryLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
                return;

            object value = dataGridView1.CurrentRow.Cells[6].Value;

            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return;

            clsPersonBess person =
                clsPersonBess.GetPersonByNationalNo(value.ToString());

            if (person == null)
                return;

            Form f = new FormShowLincese(person.ID);
            f.ShowDialog(); 
            
        }

        private void releaseDetainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value);
            if (!clsDetainLicense.IsLicenseDetained(num))
            {
                MessageBox.Show("This Is License Not Detained");
                return; 
            }
            Form f = new FormReleaseLicense(num,true);
            f.ShowDialog();
        }
    }
}
