using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1
{
    public partial class Form_Show_Info_Person : Form
    {
        private int _ID;
        public Form_Show_Info_Person(int id)
        {  
            _ID = id;
            InitializeComponent();
            ctrl_show_Info_Person1._ID = _ID;
        }
       
        private void ctrl_show_Info_Person1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form_Show_Info_Person_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
