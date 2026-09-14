using BussinassLayer;
using Project_DVLD_version1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1
{
    public partial class ctrl_show_Info_Person : UserControl
    {
        public string National { set; get; }
        public int _ID { get; set; }
        private clsPersonBess _cls;
        public ctrl_show_Info_Person()
        {
            InitializeComponent();
            _ID = -1;
        }
        public ctrl_show_Info_Person(int id)
        {
            InitializeComponent();
            _ID= id;
        }

        private string convertGendr(int i)
        {
            if (i == 0)
            {
                return "Male";
            }
            return "Female";
        }
        public void ReceiveData(int x)
        {
            _ID = x;
            LoadPersonData();
        }
        public void ReceiveData(string x)
        {
            National = x;
            LoadPersonData();
        }
        private void LoadPersonData()
        {
            if (_ID != -1)
            {

                _cls = clsPersonBess.GetPersonById(_ID);

                lbID.Text = _cls.ID.ToString();
                lbName.Text = _cls.FirstName + " " +
                              _cls.SecondName + " " +
                              _cls.ThirdName + " " +
                              _cls.LastName;

                lbgendor.Text = convertGendr(_cls.Gendor);
                lbemail.Text = _cls.Email;
                lbaddress.Text = _cls.Address;
                lbphone.Text = _cls.Phone;
                lbCountry.Text = clscountryBess.GetCountryById(_cls.NationID).Name;
                lbNational.Text = _cls.NationNo;
                lbbirthofdate.Text = _cls.BirthOfDate.ToString();
                label19.Text = _cls.ImagePath;

                if (_cls.ImagePath.Contains("Male"))
                {
                    pictureBox1.Image = Resources.user__1_;
                }
                else if (_cls.ImagePath.Contains("Female"))
                {
                    pictureBox1.Image = Resources.patient_female;
                }
                else if (!string.IsNullOrEmpty(_cls.ImagePath))
                {
                    pictureBox1.ImageLocation = _cls.ImagePath;

                }
            }
            else
            {
                _cls = clsPersonBess.GetPersonByNationalNo(National);

                if (_cls == null)
                {
                    return;//MessageBox.Show("Not Found");
                }
                else
                {
                    lbID.Text = _cls.ID.ToString();
                    lbName.Text = _cls.FirstName + " " +
                                  _cls.SecondName + " " +
                                  _cls.ThirdName + " " +
                                  _cls.LastName;

                    lbgendor.Text = convertGendr(_cls.Gendor);
                    lbemail.Text = _cls.Email;
                    lbaddress.Text = _cls.Address;
                    lbphone.Text = _cls.Phone;
                    lbCountry.Text = clscountryBess.GetCountryById(_cls.NationID).Name;
                    lbNational.Text = _cls.NationNo;
                    lbbirthofdate.Text = _cls.BirthOfDate.ToString();
                    label19.Text = _cls.ImagePath;

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
                       
                    }
                    
                }
            }
        }
        public bool showLinkEditPicture
        {
            get { return linkLabel1.Visible; }
            set { linkLabel1.Visible = value;}
        }

        private void ctrl_show_Info_Person_Load(object sender, EventArgs e)
        {
            linkLabel1.Visible = false;
            LoadPersonData();
            
        }
        public string PathImage { get; set; }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


            Form f = new Form_New_Person(_ID);
            f.ShowDialog ();
            LoadPersonData();
        }
    }
}
