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
using System.IO;
namespace Project_DVLD_version1
{
    public partial class Form_login : Form
    {
        private string username, password;

        public Form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user=textBox1.Text, pass=textBox2.Text;
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
            {
                return;
            }
            user = textBox1.Text.Trim();
            pass = textBox2.Text.Trim();
            if (clsUserBess.LoginUser(user, pass))
            {
                if (clsUserBess.IsActive(user))
                {
                    this.Hide();
                    int Id = clsUserBess.GetUserByUserName(user).PersonID;
                    clsGlobalUser.UserName= user;
                    Form f = new FormMain(Id);
                    f.WindowState = FormWindowState.Maximized;

                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Account Is Disactive");
                }
            }
            else
            {
                MessageBox.Show("incorrect username/password");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool Islegament = false;
        private void Form_login_Load(object sender, EventArgs e)
        {
           
            checkBox1.Checked = false;
            Islegament = false;
            textBox1.Clear();
            textBox2.Clear();
            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar=='*')
            {
                textBox2.PasswordChar = '\0';
               
            }
            else
            {
                textBox2.PasswordChar = '*';
               
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (username != textBox1.Text && checkBox1.Checked && Islegament)
            {
                File.WriteAllText(path, "");
                checkBox1_CheckedChanged(sender, e);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (password != textBox2.Text && checkBox1.Checked && Islegament)
            {
                File.WriteAllText(path, "");
                checkBox1_CheckedChanged(sender, e);
            }
        }
        public string path = @"C:\Users\user\source\repos\Project DVLD version1\Project DVLD version1\login_remember.txt";
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            
            // عند التفعيل
            if (checkBox1.Checked)
            {
                // إذا الملف موجود -> اقرأ البيانات
                if (File.Exists(path))
                {
                    string data = File.ReadAllText(path);
                   
                    string[] arr = data.Split('&');

                    if (arr.Length >= 2)
                    {
                        textBox1.Text = arr[0];
                        textBox2.Text = arr[1];
                        username = textBox1.Text;
                        password = textBox2.Text;

                    }
                    else
                    {
                        string info = textBox1.Text.Trim() + "&" + textBox2.Text.Trim();

                        File.WriteAllText(path, info);

                        MessageBox.Show("Information Saved");
                    }
                }
                else
                {
                    // إذا لا يوجد ملف -> احفظ البيانات الحالية
                    string info = textBox1.Text.Trim() + "&" + textBox2.Text.Trim();

                    File.WriteAllText(path, info);

                    MessageBox.Show("Information Saved");
                }
            }
            else
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
            Islegament = true;

        }
    }
}
