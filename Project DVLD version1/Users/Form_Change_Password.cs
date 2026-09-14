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
    public partial class Form_Change_Password : Form
    {
        private int _ID;
        private int iduser;
        public Form_Change_Password(int idperson)
        {
            InitializeComponent();
            _ID = idperson;
            iduser = clsUserBess.GetUserByPerson(idperson).ID;
            ctrl_info_user1.Datareceve(iduser);
            ctrl_show_Info_Person1.ReceiveData(_ID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close ();
        }

        private void Form_Change_Password_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Must Enter Value");
                e.Cancel = true;
            }

            if (clsUserBess.GetUser(iduser).Password != textBox1.Text)
            {
                errorProvider1.SetError(textBox1, "Password Current Incorrct");
                e.Cancel = true;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Must Enter Value");
                e.Cancel = true;
            }
            if (textBox3.Text != textBox2.Text)
            {
                errorProvider1.SetError(textBox3, "Not Confirmation Password New");
                e.Cancel = true;
            }
            
           
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Must Enter Value");
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsUserBess _cls = clsUserBess.GetUser(iduser);
            _cls.Password = textBox2.Text;
            if (_cls.Save())
            {
                MessageBox.Show("Done Save in DB");
            }
            else
            {
                MessageBox.Show("Not Save in DB");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
