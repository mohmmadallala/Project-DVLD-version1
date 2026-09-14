using BussinassLayer;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project_DVLD_version1
{
    public partial class Form_Add_New_License_locally : Form
    {
        public delegate void valuenumberlist(int i);
        valuenumberlist myvaluenumberlist;
        public int _IDLocal;
        public int _ID;
        public string National;
        public clsAppLicensesLocalBess _cls; 
        public Form_Add_New_License_locally(int id=-1)
        {
            InitializeComponent();
            _IDLocal = id;
            myvaluenumberlist = ctrl_Multi_fillter1.changeNumberList;
            ctrl_Multi_fillter1.Mynumberuser += FunSendnumberuser;
            ctrl_Multi_fillter1.sendstringuser += FunSendStringuser;
            
        }
        private void fullCom1() 
        {
           DataTable dt=clsLicensesClassesBess.GetAllApplications();
            foreach(DataRow i in dt.Rows)
            {
                comboBox1.Items.Add(i[1].ToString());
            }
            comboBox1.SelectedIndex = 2;
        }
        private void Form_Add_New_License_locally_Load(object sender, EventArgs e)
        {
            fullCom1 ();
            button3.Enabled = false;
            button2.Enabled = false;
            if (_IDLocal == -1)
            {
                _cls = new clsAppLicensesLocalBess();
            }
            else
            {
                _cls = clsAppLicensesLocalBess.GetLicenseLocal(_IDLocal);
            }

           // ctrl_show_Info_Person1.ReceiveData(_ID);
            ctrl_Multi_fillter1.Focus();
            myvaluenumberlist?.Invoke(1);

            if (_cls != null)
            {
                var app = clsApplicationBess.GetApplication(_cls.IDApp);

                if (app != null)
                {
                    ctrl_show_Info_Person1._ID = app.PersonID;
                }
            }
        }
        private void FunSendnumberuser(int i)
        {
            _ID = i;
            ctrl_show_Info_Person1.ReceiveData(_ID);
            National = "?";
        }
        private void FunSendStringuser(string i)
        {
            National= i;
            ctrl_show_Info_Person1.ReceiveData(i);
            _ID = -1;
        }

        private void ctrl_Multi_fillter1_Load(object sender, EventArgs e)
        {

        }
        private bool next = true;
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && next)
            {
                
                tabControl1.SelectedIndex = 0;
                MessageBox.Show("Not Avliable Tab now");
            }
            else
            {
                lbDate.Text=DateTime.Now.ToShortDateString();
                lbfees.Text = clsTypeAppBess.GetApp(1).Fees.ToString();
                lbuser.Text = clsGlobalUser.UserName.ToString();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsPersonBess _cls;
            if (_ID != -1 && National == "?")
            {
                 _cls = clsPersonBess.GetPersonById(_ID);
            }
            else
            {
                _cls = clsPersonBess.GetPersonByNationalNo(National);
            }
            if (_cls == null)
            {
                MessageBox.Show("Plase select Person lead to User");
                return;
            }

            
                next = false;
                _cls.ImagePath = ctrl_show_Info_Person1.PathImage;
                _cls.Save();
                tabControl1.SelectedIndex = 1;
            button3.Enabled = true;
            button2.Enabled = true;

            _ID = _cls.ID;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            clsApplicationBess clsapp = new clsApplicationBess();
            clsapp.PersonID = _ID;
            clsapp.AppDate = DateTime.Now;
            clsapp.AppTypeID = 1;
            clsapp.AppState = clsApplicationBess.EnState.New;
            clsapp.AppLastStateUpdateDate = DateTime.Now;
            clsapp.Fees = clsTypeAppBess.GetApp(1).Fees;
            clsapp.UserID = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
            if (clsLincsesBess.IsHaveLicense(clsDriverBess.GetDriverByPersonID(clsapp.PersonID).ID, (comboBox1.SelectedIndex + 1)))
            {
                MessageBox.Show($"The Person have License {comboBox1.SelectedItem}");
                return;
            }
            if (clsAppLicensesLocalBess.IsHaveLicenseLocal(clsapp.PersonID, comboBox1.SelectedIndex + 1))
            {
                MessageBox.Show("The person is Have Licnse Local Same class Licnse local Order Current");
                return;
            }
            
            if (clsAppLicensesLocalBess.IsExitByIdpersonAndIdclassAppOpen(clsapp.PersonID, comboBox1.SelectedIndex + 1))
            {
                MessageBox.Show("The person is Open Application that same Class License\nsolution Completed Or Cancleed");
                return;
            }

            else
            {
                if (clsapp.Save())
                {
                    MessageBox.Show($"Successfully Insert Application New To {clsPersonBess.GetPersonById(clsapp.PersonID)}");
                    _cls.IDApp = clsapp.AppID;
                    _cls.IDClass = comboBox1.SelectedIndex + 1;
                    if (_cls.Save())
                    {
                        MessageBox.Show("Successfully Insert License Local Apllication New");
                        label16.Text = _cls.IDLicense.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Not Successfully Insert License Local Apllication New");
                    }


                }
                else
                {
                    MessageBox.Show("Not Successfully insert Application To Person");
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
