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
    public partial class ctrl_show_info_Application : UserControl
    {
        public clsApplicationBess cls;
        private int _ID = -1;

        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;

                if (_ID != -1)
                    LoadData();
            }
        }
        public void LoadData()
        {
            if (ID == -1)
            {
                return; ;
            }
            else
            {
                cls = clsApplicationBess.GetApplication(ID);
                lbID.Text = cls.AppID.ToString();
                lbState.Text=cls.AppState.ToString();
                lbfees.Text = cls.Fees.ToString();
                lbtype.Text = cls.AppTypeID.ToString();
                lbApplicant.Text = clsPersonBess.GetPersonById(cls.PersonID).FullName();
                lbdate.Text=cls.AppDate.ToString();
                lblastdate.Text=cls.AppLastStateUpdateDate.ToString();
                lbuser.Text = clsUserBess.GetUser(cls.UserID).UserName.ToString();
                
            }

            // تحميل البيانات من قاعدة البيانات
        }
        public ctrl_show_info_Application()
        {
            InitializeComponent();
            ID= -1;
        }
        public ctrl_show_info_Application(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void ctrl_show_info_Application_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form f = new Form_Show_Info_Person(cls.PersonID);
            f.ShowDialog();
        }
    }
}
