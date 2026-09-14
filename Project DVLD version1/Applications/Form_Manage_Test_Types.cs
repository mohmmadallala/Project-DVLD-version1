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
    public partial class Form_Manage_Test_Types : Form
    {
        public Form_Manage_Test_Types()
        {
            InitializeComponent();
        }

        private void Form_Manage_Test_Types_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = clsTestBess.GetAllTypesApp();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void modifyInfoApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_Edit_Test(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            f.ShowDialog();
            dataGridView1.DataSource = clsTestBess.GetAllTypesApp();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
