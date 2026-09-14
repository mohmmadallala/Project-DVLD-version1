using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinassLayer;
using Project_DVLD_version1.Properties;
using System.IO;

namespace Project_DVLD_version1
{
    public partial class ctrl_New_Person : UserControl
    {

        public enum EnMode {Add=0,update=1};
        clsPersonBess _cls;
        private void FillCountry()
        {
            DataTable dt = clscountryBess.GetAllCountry();

            foreach (DataRow dr in dt.Rows)
            {
                comboBox2.Items.Add(dr[1].ToString());
            }

        }
        public int _ID { set; get; } 
        private EnMode _Enmode;
        public ctrl_New_Person()
        {
            InitializeComponent();

            _ID = -1;
        }
     

        public ctrl_New_Person(int ID)
        {
            InitializeComponent();

           

            _ID = ID;
           // MessageBox.Show("this is ID : "+ID.ToString());

            if (_ID == -1)
            {
                _Enmode = EnMode.Add;
                linkLabel2.Visible= false;
                lbTitle.Text = "Form To New Person In System";
            }
            else
            {
                _Enmode = EnMode.update;
                linkLabel2.Visible = true;
                lbTitle.Text = "Form To Edit Person In System";

              
            }
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void LoadData(int id)
        {
            _ID = id;
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            FillCountry();
            comboBox2.SelectedIndex = 89;
            if (_Enmode == EnMode.Add)
            {
                _cls = new clsPersonBess();
                textBox5.ReadOnly = false;
                RadMale.Checked = true;
                pictureBox1.Image = Resources.user__1_;
                return;
            }
            else
            {
                _cls = clsPersonBess.GetPersonById(_ID);
                if (_cls == null)
                {
                    //   MessageBox.Show(_ID.ToString());
                    MessageBox.Show("Not Found In Database");
                    return;
                }
                Natinoal = _cls.NationNo;
                textBox5.ReadOnly = true;
                textBox5.TabStop = false;
                lbID.Text = _cls.ID.ToString();
                textBox1.Text = _cls.FirstName.ToString();
                textBox2.Text = _cls.SecondName.ToString();
                textBox3.Text = _cls.ThirdName.ToString();
                textBox4.Text = _cls.LastName.ToString();
                textBox5.Text = _cls.NationNo.ToString();
                textEmail.Text = _cls.Email.ToString();
                textPhone.Text = _cls.Phone.ToString();
                textAddress.Text = _cls.Address.ToString();
                dateTimePicker1.Value = _cls.BirthOfDate;
                comboBox2.SelectedIndex = comboBox2.FindString(clscountryBess.GetCountryById(_cls.NationID).Name);

                if (_cls.Gendor == 0)
                {
                    RadMale.Checked = true;
                    RadFemale.Checked = false;
                }
                else
                {
                    RadFemale.Checked = true;
                    RadMale.Checked = false;
                }
                if (_cls.ImagePath == "Male")
                {
                    pictureBox1.Image = Resources.user__1_;
                }
                else if (_cls.ImagePath == "Female")
                {
                    pictureBox1.Image = Resources.patient_female;
                }
                else if (!string.IsNullOrEmpty(_cls.ImagePath))
                {
                    pictureBox1.ImageLocation = _cls.ImagePath;
                    _ImagePath = _cls.ImagePath;
                }
            }
        }

        private void ctrl_New_Person_Load(object sender, EventArgs e)
        {



            LoadData(_ID);
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;

                string folder = @"C:\PicturesDVLD";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string newName = Guid.NewGuid().ToString() + Path.GetExtension(file);

                string newPath = Path.Combine(folder, newName);

                File.Copy(file, newPath, true);

                pictureBox1.ImageLocation = newPath;

                // ✅ مهم جداً
                _ImagePath = newPath;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox4.Text)
                || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("you Must Enter All Feild Mandotory");
            }
            else
            {

                _cls.FirstName = textBox1.Text;
                _cls.SecondName = textBox2.Text;
                _cls.ThirdName = textBox3.Text;
                _cls.LastName = textBox4.Text;
                _cls.NationNo = textBox5.Text;
                _cls.Email = textEmail.Text;
                _cls.Phone = textPhone.Text;
                _cls.Address = textAddress.Text;
                _cls.BirthOfDate = dateTimePicker1.Value;
                _cls.NationID = comboBox2.SelectedIndex + 1;
                if (!string.IsNullOrEmpty(pictureBox1.ImageLocation))
                {
                    _cls.ImagePath = pictureBox1.ImageLocation;
                }
                else
                {
                    if (RadMale.Checked)
                    {
                        _cls.ImagePath = "Male";
                    }
                    else
                    {
                        _cls.ImagePath = "Female";
                    }
                }
                if (RadMale.Checked)
                {
                    _cls.Gendor = 0;
                }
                else
                {
                    _cls.Gendor = 1;
                }
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
                    lbID.Text = _cls.ID.ToString();
                }
                lbTitle.Text = "Form To Edit Person In Database";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Must Enter First Name");
                e.Cancel = true; // ✅ هذا الصحيح
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Must Enter First Name");
                e.Cancel = true; // ✅ هذا الصحيح
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider1.SetError(textBox3, "Must Enter First Name");
                e.Cancel = true; // ✅ هذا الصحيح
            }
            else
            {
                errorProvider1.SetError(textBox3, "");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider1.SetError(textBox4, "Must Enter First Name");
                e.Cancel = true; // ✅ هذا الصحيح
            }
            else
            {
                errorProvider1.SetError(textBox4, "");
            }
        }
        private string Natinoal;
        private void textBox5_Validating(object sender, CancelEventArgs e)
        {

            // حذف أي خطأ قديم
            errorProvider1.SetError(textBox5, "");

            // التحقق إذا الحقل فارغ
            if (string.IsNullOrWhiteSpace(textBox5.Text))
            {
                errorProvider1.SetError(textBox5, "Must Enter National Number");
                e.Cancel = true;
                return;
            }

            // التحقق أنه أرقام فقط
            if (!long.TryParse(textBox5.Text, out _))
            {
                errorProvider1.SetError(textBox5, "Must enter only numbers");
                e.Cancel = true;
                return;
            }

            // التحقق من الطول
            if (textBox5.Text.Length != 10)
            {
                errorProvider1.SetError(textBox5, "National Number must be 10 numbers");
                e.Cancel = true;
                return;
            }

            // التحقق إذا الرقم موجود
            if (textBox5.Text != Natinoal)
            {
                if (clsPersonBess.IsExistByNation(textBox5.Text))
                {
                    errorProvider1.SetError(textBox5, "National Number already exists");
                    e.Cancel = true;
                    return;
                }
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(dateTimePicker1.Text))
            {
                errorProvider1.SetError(dateTimePicker1, "Must Enter First Name");
                e.Cancel = true; // ✅ هذا الصحيح
            }
            else
            {
                errorProvider1.SetError(dateTimePicker1, "");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }


        private string _ImagePath = "";

        private void RadMale_CheckedChanged(object sender, EventArgs e)
        {
            if (RadMale.Checked && _ImagePath == "")
            {
                pictureBox1.Image = Resources.user__1_;
            }
        }

        private void RadFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (RadFemale.Checked && _ImagePath == "")
            {
                pictureBox1.Image = Resources.patient_female;
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(pictureBox1.ImageLocation) &&
                File.Exists(pictureBox1.ImageLocation))
            {
                File.Delete(pictureBox1.ImageLocation);
            }

            pictureBox1.ImageLocation = null;

            // ✅ مهم
            _ImagePath = "";

            // الصورة الافتراضية
            if (RadMale.Checked)
            {
                pictureBox1.Image = Resources.user__1_;
            }
            else
            {
                pictureBox1.Image = Resources.patient_female;
            }
        }

        private void textEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!string.IsNullOrEmpty(textEmail.Text))
            {
                if (!textEmail.Text.Contains("@gmail.com"))
                {
                    errorProvider1.SetError(textEmail, "must Formmat Email");
                    e.Cancel = true;
                }
            }
        }

        private void textAddress_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void textPhone_Validating(object sender, CancelEventArgs e)
        {
            errorProvider1.SetError(textPhone, "");

            // التحقق إذا الحقل فارغ
            if (string.IsNullOrWhiteSpace(textPhone.Text))
            {
                textPhone.Focus();
                errorProvider1.SetError(textPhone, "Must Enter National Number");
                e.Cancel = true;
                return;
            }

            // التحقق أنه أرقام فقط
            if (!long.TryParse(textPhone.Text, out _))
            {
                textPhone.Focus();
                errorProvider1.SetError(textPhone, "Must enter only numbers");
                e.Cancel = true;

                return;
            }

            // التحقق من الطول
            if (textPhone.Text.Length != 6)
            {

                textPhone.Focus();
                errorProvider1.SetError(textPhone, "National Number must be 10 numbers");
                e.Cancel = true;
                return;
            }
        }

        private void textAddress_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
