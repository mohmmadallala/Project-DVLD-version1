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
    public partial class ctrl_fillter_People : UserControl
    {
        public event Action<int> EnvetSendID;
        protected virtual void funhandler(int id)
        {
            Action<int> hand = EnvetSendID;
            if (hand != null)
            {
                hand(id);
            }
        }
        public ctrl_fillter_People()
        {
            InitializeComponent();
        }
        private DataTable dt;
        
        private void FullList()
        {
            comboBox1.Items.Clear();
            dt = clsPersonBess.GetAllPerson();
            foreach (DataColumn i in dt.Columns)
            {
                if (!(i.ToString().Contains("Date")))
                    comboBox1.Items.Add(i.ColumnName);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dt = clsPersonBess.GetAllPerson();
            dt.DefaultView.Sort = comboBox1.SelectedItem.ToString();
            
            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.Columns["DateOfBirth"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2_Click(sender, e);

            if (comboBox1.SelectedItem.ToString().Contains("Gender"))
            {
                textBox1.Visible = false;
                comboBox2.Visible = true;
                comboBox2.Items.Clear();
                comboBox2.Items.Add("All");
                comboBox2.Items.Add("Male");
                comboBox2.Items.Add("Female");
               
            }
            else if(comboBox1.SelectedItem.ToString().Contains("CountryName"))
            {
                textBox1.Visible = false;
                comboBox2.Visible = true;
                dt = clsPersonBess.GetAllPerson();
                comboBox2.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    if (!comboBox2.Items.Contains(dr[10].ToString()))
                    {
                        comboBox2.Items.Add(dr[10].ToString());
                    }
                }
            }
            else
            {

                textBox1.Visible = true;
                comboBox2.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string columnName = comboBox1.SelectedItem.ToString();
            if (columnName.Contains("ID"))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.Text = null;
                    dt = clsPersonBess.GetAllPerson();
                    dt.DefaultView.Sort = comboBox1.SelectedItem.ToString();
                }
                else
                {
                    
                    dt.DefaultView.Sort = columnName + " ASC";
                    dt.DefaultView.RowFilter = columnName + "=" + textBox1.Text;
                }
            }
            else
            {

                dt.DefaultView.Sort = columnName + " ASC";
                dt.DefaultView.RowFilter = columnName + " LIKE '%" + textBox1.Text + "%'";
            }
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void ctrl_fillter_People_Load(object sender, EventArgs e)
        {
            FullList();
            dt = clsPersonBess.GetAllPerson();
            comboBox1.SelectedIndex = 0;
            lbcount.Text = dt.Rows.Count.ToString();
            dt.Columns.Remove("ImagePath");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this?.FindForm().Close();
        }

        private void showDetailsInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            if (EnvetSendID != null)
            {
                funhandler(r);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form F = new Form_New_Person(-1);
            F.ShowDialog();
            dataGridView1.DataSource=clsPersonBess.GetAllPerson();
            lbcount.Text=dataGridView1.Rows.Count.ToString();  
            ctrl_fillter_People_Load(sender, e) ;

        }

        private void editInfoPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f=new Form_New_Person(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            f.ShowDialog();
            button2_Click(sender, e);
            ctrl_fillter_People_Load (sender, e);
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsPersonBess _cls= clsPersonBess.GetPersonById(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
             if(MessageBox.Show("Do You Delete Person ?", "Delete Person", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if (clsPersonBess.DeletePerson(_cls.ID))
                {
                    MessageBox.Show($"Successfully Delete Person have ID {_cls.ID.ToString()}");
                    button2_Click(sender, e);
                    lbcount.Text = dt.Rows.Count.ToString();
                    ctrl_fillter_People_Load(sender, e);
                }
                else
                {
                    MessageBox.Show($"Not Successfully Delete Person have ID {_cls.ID.ToString()}");

                }
                  
            }
            else
            {
                MessageBox.Show("Not Delete Person");
            }
            if (!string.IsNullOrEmpty(_cls.ImagePath) && File.Exists(_cls.ImagePath))
            {
                File.Delete(_cls.ImagePath);
            }
            
        }

        private void lbcount_Click(object sender, EventArgs e)
        {

        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form F = new Form_New_Person(-1);
            F.ShowDialog();
            dataGridView1.DataSource = clsPersonBess.GetAllPerson();
            lbcount.Text = dataGridView1.Rows.Count.ToString();
            ctrl_fillter_People_Load(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string columnName = comboBox1.SelectedItem.ToString();
            if (columnName == "Gender")
            {
                if (comboBox2.SelectedItem.ToString() == "All")
                {
                    dt.DefaultView.Sort = columnName + " ASC";
                    dt.DefaultView.RowFilter = "";
                }
                else if (comboBox2.SelectedItem.ToString() == "Male")
                {
                    dt.DefaultView.Sort = columnName + " ASC";
                    dt.DefaultView.RowFilter =
                        columnName + " LIKE '%" + "M" + "%'";
                }
                else
                {
                    dt.DefaultView.Sort = columnName + " ASC";
                    dt.DefaultView.RowFilter =
                        columnName + " LIKE '%" + "F" + "%'";
                }
            }
            else
            {
                dt.DefaultView.Sort = columnName + " ASC";
                dt.DefaultView.RowFilter =
                    columnName + " LIKE '%" + comboBox2.SelectedItem.ToString() + "%'";
            }
            dataGridView1.DataSource = dt.DefaultView;
        }
    }
}
