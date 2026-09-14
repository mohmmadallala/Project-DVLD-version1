using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinassLayer;
namespace Project_DVLD_version1
{
    public partial class Form_New_Person : Form
    {
        public int ID;
      
        public Form_New_Person()
        {
            InitializeComponent();
            ID = -1;
        }
     
        public Form_New_Person(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void Form_New_Person_Load(object sender, EventArgs e)
        {
           
        }

        private void ctrl_New_Person2_Load(object sender, EventArgs e)
        {
            ctrl_New_Person2.LoadData(ID);
        }
    }
}
