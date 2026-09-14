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
    public partial class FormShowLincese : Form
    {
        public int IDperson {  get; set; }
        public FormShowLincese()
        {
            InitializeComponent();
            IDperson = -1;
        }
        public FormShowLincese(int id)
        {
            InitializeComponent();
            IDperson = id;
        }

        private void FormShowLincese_Load(object sender, EventArgs e)
        {
            if (IDperson == -1) { return; }
            else
            {
                
                ctrl_show_Info_Person1.ReceiveData(IDperson);
               ReFreachDataTable();

            }
        }

        private void ctrl_show_Info_Person1_Load(object sender, EventArgs e)
        {

        }
        private void ReFreachDataTable() {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            DataTable dt = new DataTable();
            if (tabControl1.SelectedIndex == 0)
            {
                dt = clsLincsesBess.GetAllLincesesToDriver(clsDriverBess.GetDriverByPersonID(IDperson).ID);
                dataGridView1.DataSource = dt;
            }
            else
            {
                dt = clsLicenseInternationalBess.GetAllLicenseToOneDriverByIdDriver(clsDriverBess.GetDriverByPersonID(IDperson).ID);
                dataGridView2.DataSource = dt;
            }
           

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
          
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            ReFreachDataTable();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
