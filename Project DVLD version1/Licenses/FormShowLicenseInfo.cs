using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1.Licenses
{
    public partial class FormShowLicenseInfo : Form
    {
        private int _ID;
      
        public FormShowLicenseInfo(int id=-1)
        {
           
            InitializeComponent();
            MessageBox.Show("FormShowLicenseInfo ID: " + id.ToString());
            _ID = id;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlShowLicense1_Load(object sender, EventArgs e)
        {

        }

        private void FormShowLicenseInfo_Load(object sender, EventArgs e)
        {
            if (_ID == -1)
            {
                return;
            }
            ctrlShowLicense1.LoadData(_ID);

        }
    }
}
