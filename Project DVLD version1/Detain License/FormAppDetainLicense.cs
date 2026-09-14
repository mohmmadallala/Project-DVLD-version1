using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1.Detain_License
{
    public partial class FormAppDetainLicense : Form
    {
        private int _ID;
        public FormAppDetainLicense()
        {
            InitializeComponent();
            _ID = -1;
        }
        public FormAppDetainLicense(int id)
        {
            InitializeComponent();
            _ID = id;
        }

        private void FormAppDetainLicense_Load(object sender, EventArgs e)
        {
            if (_ID == -1)
            {
                return;
            }
            ctrlDetainLicense1.loadData(_ID);
        }
    }
}
