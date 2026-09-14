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
    public partial class ctrl_info_user : UserControl
    {
        public int ID;
        public ctrl_info_user()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        public void Datareceve(int i)
        {
            ID = i;
            LoadUser();
        }

        private void ctrl_info_user_Load(object sender, EventArgs e)
        {
            LoadUser();  
        }
        private void LoadUser()
        {
            clsUserBess _cls = clsUserBess.GetUser(ID);
            if (_cls != null)
            {
                label2.Text = _cls.ID.ToString();
                label4.Text = _cls.UserName.ToString();
                if (_cls.Active == 1)
                {
                    label6.Text = "Yes";
                }
                else
                {
                    label6.Text = "No";
                }

            }
            else
            {
                //MessageBox.Show("Not Found ID User");
            }
        }
    }
}
