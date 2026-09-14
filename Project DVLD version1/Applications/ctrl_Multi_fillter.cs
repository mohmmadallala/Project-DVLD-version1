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
    public partial class ctrl_Multi_fillter : UserControl
    {
      

        public delegate void Sendnumberuser(int i);
        public delegate void Sendstringuser(string s);
        public event Sendstringuser sendstringuser;
        public event Sendnumberuser Mynumberuser;
        public int numlist { set; get; } 
        public ctrl_Multi_fillter()
        {
            InitializeComponent();
            maskedTextBox1.Focus();
        }
        public void FocusMask()
        {
            maskedTextBox1.Focus();
        }
        public bool EnableFillter
        {
            set { comboBox1.Enabled = value;}
            get { return comboBox1.Enabled; }
        }
        public bool EnableMaskText
        {
            set { maskedTextBox1.Enabled = value; }
            get { return maskedTextBox1.Enabled; }
        }
        public bool Enablebuttun
        {
            set { button1.Enabled = value; }
            get { return button1.Enabled; }
        }
        public void changeNumberList(int i)
        {
            numlist = i;
            FullList(numlist);
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "")
            {
                return;
            }
            
                string columnName = comboBox1.SelectedItem.ToString();

                
                if (columnName.Contains("ID"))
                {
                    clsPersonBess _cls = clsPersonBess.GetPersonById(Convert.ToInt16(maskedTextBox1.Text));
                    if (_cls != null)
                    {
                        MessageBox.Show(maskedTextBox1.Text);
                        Mynumberuser?.Invoke(Convert.ToInt16(maskedTextBox1.Text));
                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }
                }
                else
                {
                    clsPersonBess _cls = clsPersonBess.GetPersonByNationalNo((maskedTextBox1.Text));
                    if (_cls != null)
                    {
                        MessageBox.Show(maskedTextBox1.Text);
                        sendstringuser?.Invoke((maskedTextBox1.Text));
                       
                    }
                    else
                    {
                        MessageBox.Show("Not Found");
                    }
                }
            
        }
        public ComboBox Mycompebox { set; get; }
        private void FullList(int n)
        {
            DataTable dt;
            switch (n)
            {
                case 1: dt = clsPersonBess.GetAllPerson();break;
                case 2: dt = clsUserBess.GetAllUsers();break;
                case 3: dt = clscountryBess.GetAllCountry();break;
                case 4: dt = clsAppBess.GetAllApp();break;
                case 5: dt = clsTypeAppBess.GetAllTypesApp();break;
                default: return;
            }
          
            foreach (DataColumn i in dt.Columns)
            {
                if ((i.ToString().Contains("ID") || i.ToString().Contains("NationalNo")))
                    comboBox1.Items.Add(i.ColumnName);
            }
            comboBox1.SelectedIndex = 0;
        }
        private void ctrl_Multi_fillter_Load(object sender, EventArgs e)
        {
            maskedTextBox1.Focus();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Contains("ID"))
            {
                maskedTextBox1.Mask = "99999999999";
                maskedTextBox1.TextAlign = HorizontalAlignment.Left;
            }
            else
            {
                maskedTextBox1.Mask = "";
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form f=new Form_New_Person(-1);
            f.ShowDialog();

        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
          
        }

        private void maskedTextBox1_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("must Enter value to find");
                e.Cancel = true;
                return;
            }
            else
            {

            }
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void maskedTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && maskedTextBox1.MaskCompleted)
            {
                e.SuppressKeyPress = true;

              button1_Click(sender, e);
            }

        }
    }
}
