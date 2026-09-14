using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_DVLD_version1.Form_Edit_App;

namespace Project_DVLD_version1
{
    public partial class Form_Edit_App : Form
    {
        public delegate void DataBack(int id);
        public DataBack databack;

        public int _ID;
        public Form_Edit_App(int id)
        {
            InitializeComponent();
            _ID = id;
            databack += ctrl_Edit_App1.ReceiveData;
            databack?.Invoke(_ID);
        }

        private void Form_Edit_App_Load(object sender, EventArgs e)
        {
            databack?.Invoke(_ID);
        }

        private void ctrl_Edit_App1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
