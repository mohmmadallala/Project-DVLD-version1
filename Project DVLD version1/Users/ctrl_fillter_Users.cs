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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_DVLD_version1
{
    public partial class ctrl_fillter_Users : UserControl
    {
        public ctrl_fillter_Users()
        {
            InitializeComponent();
        }
        private DataTable dt;

        private void FullName()
        {
             dt = clsUserBess.GetAllUsers();
            DataTable dp = clsPersonBess.GetAllPerson();

            if (!dt.Columns.Contains("FullName"))
            {
                dt.Columns.Add("FullName");
            }

            foreach (DataRow userRow in dt.Rows)
            {
                int PersonID = Convert.ToInt32(userRow["PersonID"]);

                foreach (DataRow personRow in dp.Rows)
                {
                    if (Convert.ToInt32(personRow["PersonID"]) == PersonID)
                    {
                        string FullName =
                            personRow["FirstName"].ToString() + " " +
                            personRow["SecondName"].ToString() + " " +
                            personRow["ThirdName"].ToString() + " " +
                            personRow["LastName"].ToString();

                        userRow["FullName"] = FullName;

                        break;
                    }
                }

            }
            dt.Columns.Remove("Password");
         
            lbcount.Text = dt.Rows.Count.ToString();

            dataGridView1.DataSource = dt.DefaultView;
            dataGridView1.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        private void FullList()
        {
            
            foreach (DataColumn i in dt.Columns)
            {
                if (!(i.ToString().Contains("Date")||i.ToString().Contains("Password")))
                    comboBox1.Items.Add(i.ColumnName);
            }
        }
        private void ctrl_fillter_Users_Load(object sender, EventArgs e)
        {
            FullName();
            FullList();
            comboBox1.SelectedIndex = 0;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            FullName();
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string columnName = comboBox1.SelectedItem.ToString();

            if (columnName.Contains("ID"))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    textBox1.Text = null;
                    dt = clsUserBess.GetAllUsers();
                    dt.DefaultView.Sort = comboBox1.SelectedItem.ToString();
                }
                else
                {
                    if(int.TryParse(textBox1.Text,out int i))
                    {
                        dt.DefaultView.Sort = columnName + " ASC";
                        dt.DefaultView.RowFilter = columnName + "=" + i;
                    }
                    else
                    {
                        textBox1.Text = null;

                    }
                  
                }
            }
            else
            {
                dt.DefaultView.Sort = columnName + " ASC";
                dt.DefaultView.RowFilter = columnName + " LIKE '%" + textBox1.Text + "%'";
            }
            dataGridView1.DataSource = dt.DefaultView;
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
            Form f =new Form_show_info_user(Convert.ToInt16(dataGridView1.CurrentRow.Cells[1].Value));
            f.ShowDialog();
       }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_Add_New_user(-1);
            f.ShowDialog();
            ctrl_fillter_Users_Load(sender, e);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f=new Form_Add_New_user();
            f.ShowDialog();
            ctrl_fillter_Users_Load(sender, e);
        }

        private void FullCombo2()
        {
            comboBox2.Items.Clear();
            comboBox2.Items.Add("All");
            comboBox2.Items.Add("Yes");
            comboBox2.Items.Add("No");
           
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString().Contains("Active"))
            {

                textBox1.Visible = false;
                comboBox2.Visible = true;
                FullCombo2();
            }
            else
            {
                textBox1.Visible = true;
                comboBox2.Visible = false;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string columnName = comboBox1.SelectedItem.ToString();
            if (comboBox2.SelectedIndex == 0)
            {
                dt.DefaultView.Sort = columnName + " ASC";
                dt.DefaultView.RowFilter = columnName + " = 1 OR " + columnName + " = 0";
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                dt.DefaultView.Sort = columnName + " ASC";
                dt.DefaultView.RowFilter = columnName + "=" + 1;
            }
            else
            {
                dt.DefaultView.Sort = columnName + " ASC";
                dt.DefaultView.RowFilter = columnName + " =" + 0;
            }
            dataGridView1.DataSource = dt.DefaultView;
        }

        private void editInfoPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_Add_New_user(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value),true);
            f.ShowDialog();
            //ctrl_fillter_Users_Load(sender, e);
        }

        private void deletePersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Do you Delete User number {Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value)}?", "Delete User",
                 MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
               bool i= clsUserBess.DeleteUser(Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value));
                if (i)
                {
                    MessageBox.Show("Done Delete User");
                    ctrl_fillter_Users_Load(sender,e);
                }
                else
                {
                    MessageBox.Show("Not delete user , because reachable with transactions");
                }
            }
            else
            {
                MessageBox.Show("Not delete User");
            }

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new Form_Change_Password(Convert.ToInt16(dataGridView1.CurrentRow.Cells[1].Value));
            f.ShowDialog();
        }
    }
}
