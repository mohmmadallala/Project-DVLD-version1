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
    public partial class FormReleaseLicense : Form
    {
        private int _ID;
        private bool IsShow;
        public FormReleaseLicense()
        {
            InitializeComponent();
            _ID = -1;
            IsShow = false;
        }
        public FormReleaseLicense(int id,bool isshow)
        {
            InitializeComponent();
            _ID = id;
            IsShow = isshow;
        }
        private void FormReleaseLicense_Load(object sender, EventArgs e)
        {
            if (_ID == -1)
            {
                return;
            }
            ctrlReleaseLicense1.LoadDate(_ID,-1,IsShow);
        }
    }
}
