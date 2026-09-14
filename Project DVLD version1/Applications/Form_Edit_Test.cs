using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1
{
    public partial class Form_Edit_Test : Form
    {
        public int _ID;
        public delegate void DataBack(int id);
        public DataBack databack;
        public Form_Edit_Test(int iD)
        {
            InitializeComponent(); 
            _ID = iD;
            databack += ctrl_Edit_tests1.ReceiveData;
            databack?.Invoke(_ID);
        }

        private void Form_Edit_Test_Load(object sender, EventArgs e)
        {
            databack?.Invoke(_ID);
        }
    }
}
