using BussinassLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1
{
    public partial class Form_show_Info_Appointment : Form
    {
        public int ID {  get; set; }
        clsTestAppointmentBess _cls;
        public Form_show_Info_Appointment()
        {
            InitializeComponent();
            ID = -1;
        }
        public Form_show_Info_Appointment(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form_show_Info_Appointment_Load(object sender, EventArgs e)
        {
            if (ID == -1)
            {
                return;
            }
            else
            {
                _cls = clsTestAppointmentBess.GetApp(ID);
                ctrl_show_Infi_LocalApp1.ID = _cls.LocalAppID;
                ctrl_show_Infi_LocalApp1.LoadData(_cls.LocalAppID);
                ctrl_show_info_Application1.ID = clsApplicationBess.GetApplication(clsAppLicensesLocalBess.GetLicenseLocal(_cls.LocalAppID).IDApp).AppID;
                ctrl_show_info_Application1.LoadData();
                lbId.Text = _cls.ID.ToString();
                lbtest.Text=_cls.TypeTest.ToString();
                lblocal.Text=_cls.LocalAppID.ToString();
                lbdate.Text=_cls.DateAppointment.ToString();
                lbfees.Text=_cls.Feeds.ToString();
                lbuser.Text=_cls.userId.ToString();
                if (_cls.IsLocked)
                {
                    lbstate.Text = "Locked";
                }
                else
                {
                    lbstate.Text = "Not use";
                }
            }


        }
    }
}
