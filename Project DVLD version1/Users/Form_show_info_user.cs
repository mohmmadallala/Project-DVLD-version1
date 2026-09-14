using BussinassLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1
{
    public partial class Form_show_info_user : Form
    {
        public int _IDuser;
        public int _ID;
        public Form_show_info_user(int id)
        {
            InitializeComponent();
            _ID=id;
        }

        private void Form_show_info_user_Load(object sender, EventArgs e)
        {
            if (_ID == -1)
            {
                MessageBox.Show("Not Found -1");
            }
            else
            {
                _IDuser=clsUserBess.GetUserByPerson(_ID).ID;
                ctrl_show_Info_Person1.ReceiveData(_ID);
                ctrl_info_user1.Datareceve(_IDuser);
            }

        }

        private void ctrl_show_Info_Person1_Load(object sender, EventArgs e)
        {

        }
    }
}
