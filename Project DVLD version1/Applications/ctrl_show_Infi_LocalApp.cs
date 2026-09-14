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

    public partial class ctrl_show_Infi_LocalApp : UserControl
    {
        private int _ID = -1;

        public int ID
        {
            get { return _ID; }
            set
            {
                _ID = value;

                if (_ID != -1) { }
                    
            }
        }
        public void LoadData(int id)
        {

            ID = id;
            if (ID == -1)
            {
                return; ;
            }
            else
            {
                cls = clsAppLicensesLocalBess.GetLicenseLocal(ID);
                lbclass.Text = clsLicensesClassesBess.GetClassById(cls.IDClass).Name.ToString();
                LdID.Text = cls.IDLicense.ToString();
                Lbnumtest.Text = clsTestApplicationBess.PassedTestsCount(cls.IDLicense).ToString()+"/3";



            }

            // تحميل البيانات من قاعدة البيانات
        }

        public clsAppLicensesLocalBess cls;
        public ctrl_show_Infi_LocalApp()
        {
            InitializeComponent();
            ID = -1;
        }
        public ctrl_show_Infi_LocalApp(int id)
        {
            InitializeComponent();
            ID=id;
        }

        private void ctrl_show_Infi_LocalApp_Load(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Lbnumtest_Click(object sender, EventArgs e)
        {

        }
    }
}
