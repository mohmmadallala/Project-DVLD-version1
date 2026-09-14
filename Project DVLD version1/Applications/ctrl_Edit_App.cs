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
using static Project_DVLD_version1.Form_Edit_App;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_DVLD_version1
{
    public partial class ctrl_Edit_App : UserControl
    {

        private int _ID;
        public ctrl_Edit_App()
        {
            InitializeComponent();
            _ID = -1;
        }
        public ctrl_Edit_App(int id)
        {
            InitializeComponent();
            _ID=id;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private clsTypeAppBess _cls;
        public void ReceiveData(int id)
        {
            _ID = id;
        }
        private void ctrl_Edit_App_Load(object sender, EventArgs e)
        {
            if (_ID == -1)
            {
                return;
            }
            else
            {
                _cls = clsTypeAppBess.GetApp(_ID);
                if (_cls != null)
                {
                    textBox1.Text = _cls.Title;
                    textBox2.Text = _cls.Fees.ToString();
                    label7.Text = _cls.ID.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _cls.Title = textBox1.Text;
            _cls.Fees = Convert.ToDouble(textBox2.Text);
            if (_cls.Save())
            {
                MessageBox.Show("Done Update App Successfully");
            }
            else
            {
                MessageBox.Show("Not Update App Successfully");
            }

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Must Enter Value");
                e.Cancel = true;
                return;
            }
            if(!int.TryParse(textBox2.Text,out _))
            {
                    errorProvider1.SetError(textBox2, "Must enter only numbers");
                    e.Cancel = true;
                    return;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Must Enter Value");
                e.Cancel = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this?.FindForm().Close();
        }
    }
}
