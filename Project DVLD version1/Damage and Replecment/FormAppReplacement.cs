using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1.Damage_and_Replecment
{
    public partial class FormAppReplacement : Form
    {
        private int _ID;
        public FormAppReplacement()
        {
            InitializeComponent();
            _ID = -1;
        }
        public FormAppReplacement(int id)
        {
            InitializeComponent();
            _ID = id;
        }
        private void ctrlAppDamageAndReplcement1_Load(object sender, EventArgs e)
        {

        }

        private void FormAppReplacement_Load(object sender, EventArgs e)
        {
            if (_ID == -1)
            {
                return;
            }
            ctrlAppDamageAndReplcement1.Loaddata(_ID);
        }
    }
}
