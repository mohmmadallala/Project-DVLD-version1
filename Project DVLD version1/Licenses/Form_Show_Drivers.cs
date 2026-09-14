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
    public partial class Form_Show_Drivers : Form
    {
        public Form_Show_Drivers()
        {
            InitializeComponent();
        }
        private DataTable dt;
        private void FullList()
        {
            comboBox1.Items.Add("DriverID");
            comboBox1.Items.Add("PersonID");
            comboBox1.Items.Add("NationalNO");
            comboBox1.Items.Add("FullName");
        }
        private void Form_Show_Drivers_Load(object sender, EventArgs e)
        {
            FullList();
            dt = clsDriverBess.GetAllDrivers();
            dataGridView1.DataSource = dt;
            

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            string columnName = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(columnName))
                return;

            dt.DefaultView.Sort = $"[{columnName}] ASC";

            if (string.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                dt.DefaultView.RowFilter = "";
            }
            else if (columnName.Contains("ID"))
            {
                if (int.TryParse(maskedTextBox1.Text, out int id))
                {
                    dt.DefaultView.RowFilter = $"[{columnName}] = {id}";
                }
                else
                {
                    dt.DefaultView.RowFilter = "1 = 0"; // لا تعرض شيئاً إذا كانت القيمة غير رقمية
                }
            }
            else
            {
                dt.DefaultView.RowFilter = $"[{columnName}] LIKE '%{maskedTextBox1.Text}%'";
            }

            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
