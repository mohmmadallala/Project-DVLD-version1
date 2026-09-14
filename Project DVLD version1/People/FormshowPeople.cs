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
namespace Project_DVLD_version1
{
    public partial class FormshowPeople : Form
    {
        public FormshowPeople()
        {
            InitializeComponent();
           
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void FormshowPeople_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void ctrl_fillter_People1_EnvetSendID(int obj)
        {
            Form_Show_Info_Person f = new Form_Show_Info_Person(obj);
            
            f.ShowDialog();
        }

        private void ctrl_fillter_People1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
