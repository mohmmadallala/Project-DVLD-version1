using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1.Application_Renew
{
    public partial class FormApplicationRenewLicense : Form
    {

        private int _ID;
        public FormApplicationRenewLicense(int id=-1)
        {
            InitializeComponent();
            _ID = id;

        }

        private void FormApplicationRenewLicense_Load(object sender, EventArgs e)
        {
            if (_ID == -1)
            {
                return;
            }
            ctrlApplicationRenewLicense1.Loaddata(_ID);
        }
    }
}
