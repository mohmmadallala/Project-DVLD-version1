using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1.international
{
    public partial class FormshowinfoInterLicense : Form
    {
        private int _ID;
        public FormshowinfoInterLicense()
        {
            InitializeComponent();
            _ID = -1;
        }
        public FormshowinfoInterLicense(int id)
        {
            InitializeComponent();
            _ID = id;
        }

        private void FormshowinfoInterLicense_Load(object sender, EventArgs e)
        {
            if (_ID == -1)
            {
                return;

            }
            ctrlShowInfoLicenseInternational1.LoadData(_ID);
        }
    }
}
