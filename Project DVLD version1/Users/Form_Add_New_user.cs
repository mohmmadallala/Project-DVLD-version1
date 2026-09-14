using BussinassLayer;
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
    public partial class Form_Add_New_user : Form
    {
        public delegate void valuenumberlist(int i);
        valuenumberlist myvaluenumberlist;
        public clsUserBess _cls;
        public int _ID;
        public int IDUser;
        public string national;
        private bool illegi;
        public Form_Add_New_user(int id=-1,bool b=false)
        {
            InitializeComponent();
          //  MessageBox.Show("this is ID :" + id.ToString());
            IDUser = id;
            myvaluenumberlist = ctrl_Multi_fillter1.changeNumberList;

            ctrl_Multi_fillter1.Mynumberuser += FunSendnumberuser;
            ctrl_Multi_fillter1.sendstringuser += FunSendStringuser;
            ctrl_Multi_fillter1.Focus();
            illegi = b;
            if (b)
            {
                ctrl_Multi_fillter1.EnableFillter=false;
                ctrl_Multi_fillter1.EnableMaskText=false;
                ctrl_Multi_fillter1.Enablebuttun=false;
               
                Isavli = false;
            }
        }
     
        
        private void ctrl_show_Info_Person1_Load(object sender, EventArgs e)
        {
            ctrl_show_Info_Person1.showLinkEditPicture = true;
            if (illegi)
            {
                ctrl_show_Info_Person1._ID = clsUserBess.GetUser(IDUser).PersonID;
            }
            
        }
        private void FunSendnumberuser(int i)
        {
            _ID = i;
            ctrl_show_Info_Person1.ReceiveData(_ID);
            national = "?";
        }
        private void FunSendStringuser(string i)
        {
            national = i;
            ctrl_show_Info_Person1.ReceiveData(i);
            _ID = -1;
        }

        private void Form_Add_New_user_Load(object sender, EventArgs e)
        {
            if (IDUser == -1)
            {
                _cls = new clsUserBess();
            }
            else
            {
                _cls = clsUserBess.GetUser(IDUser);
                textBox1.Text= _cls.UserName;
                textBox2.Text= _cls.Password;
                textBox3.Text = _cls.Password;
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
               
                if (_cls.Active==1) { checkBox1.Checked = true; } else {  checkBox1.Checked = false; }
                label10.Text = _cls.ID.ToString();

            }
            if (tabControl1.SelectedIndex == 0)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }

            myvaluenumberlist?.Invoke(1);
            usertemp = _cls.UserName;
            _ID = _cls.PersonID;

            ctrl_show_Info_Person1.ReceiveData(_ID);
            ctrl_Multi_fillter1.Focus();
        }
        public bool Isavli=true;
        private void button1_Click(object sender, EventArgs e)
        {
            clsPersonBess _cls;
            if (_ID != -1 || national == "?")
            {
                MessageBox.Show(_ID.ToString());
                 _cls = clsPersonBess.GetPersonById(_ID);

            }
            else
            {
                MessageBox.Show(national);
                _cls = clsPersonBess.GetPersonByNationalNo(national);
            }
            if (_cls == null&&!illegi)
            {
                MessageBox.Show("Plase select Person lead to User");
                return;
            }
          
            if (clsUserBess.IsUser(_cls.ID)&&!illegi)
            {
                _cls.ImagePath = ctrl_show_Info_Person1.PathImage;
                _cls.Save();
                MessageBox.Show("This Person already User !");
            }
            else
            {
                Isavli = false;
                _cls.ImagePath = ctrl_show_Info_Person1.PathImage;
                _cls.Save();
                tabControl1.SelectedIndex = 1;
                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Must Enter all felids");
            }
            else
            {
             
                _cls.UserName=textBox1.Text;
                _cls.Password=textBox2.Text;
                if (checkBox1.Checked)
                {
                    _cls.Active = 1;
                }
                else
                {
                    _cls.Active = 0;
                }
                _cls.PersonID = _ID;
                if (_cls.Save())
                {
                    MessageBox.Show("Data Successfully Save in DB");
                }
                else
                {
                    MessageBox.Show("Not Data Save in DB");
                }
                // _EnMode = EnMode.Update;
                if (_cls.ID != -1)
                {
                    label10.Text = _cls.ID.ToString();
                }


            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1 && Isavli)
            {
                Isavli=true;
                tabControl1.SelectedIndex = 0;
                MessageBox.Show("Not Avliable Tab now");
            }
            else
            {
               
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
           


        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }

        }
        private string usertemp;
        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Must Enter value");
                e.Cancel=true;
            }
            if (textBox3.Text != textBox2.Text)
            {
                errorProvider1.SetError(textBox3,"Must confrim Password with Password");
                e.Cancel = true;
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Must Enter value");
                e.Cancel = true;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            
            if (illegi)
            {
                
                errorProvider1.SetError(textBox1, "");
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    errorProvider1.SetError(textBox1, "Must Enter value");
                    e.Cancel = true;
                }
                if (textBox1.Text != usertemp)
                {
                    if (clsUserBess.IsExistUserNameByUserName(textBox1.Text))
                    {
                        errorProvider1.SetError(textBox1, "Username already exsiting in system");
                        e.Cancel = true;
                    }
                    else{

                    }
                }

            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    errorProvider1.SetError(textBox1, "Must Enter value");
                    e.Cancel = true;
                }
                if (clsUserBess.IsExistUserNameByUserName(textBox1.Text))
                {
                    errorProvider1.SetError(textBox1, "Username already exsiting in system");
                    e.Cancel = true;
                }
            }
           
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ctrl_Multi_fillter1_Load(object sender, EventArgs e)
        {
            ctrl_Multi_fillter1.FocusMask();
        }
    }
}
