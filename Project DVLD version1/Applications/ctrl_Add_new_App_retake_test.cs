using BussinassLayer;
using System;
using System.Windows.Forms;

namespace Project_DVLD_version1
{
    public partial class ctrl_Add_new_App_retake_test : UserControl
    {
        private clsApplicationBess _application;

        private double _feesAppLocal;
        public double FeesApplocal
        {
            get { return _feesAppLocal; }
            set { _feesAppLocal = value; }
        }

        private int _id = -1;
        public int ID
        {
            get { return _id; }
            set
            {
                _id = value;

                if (_id != -1 && !DesignMode)
                    LoadData();
            }
        }

        public ctrl_Add_new_App_retake_test()
        {
            InitializeComponent();
            ID = -1;
        }

        public ctrl_Add_new_App_retake_test(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void ctrl_Add_new_App_retake_test_Load(object sender, EventArgs e)
        {
           
                LoadData();
        }

        public void LoadData()
        {
            if (ID == -1)
            {
                label3.Text = clsTypeAppBess.GetApp(1010).Fees.ToString();
                label4.Text = "???";
                label6.Text = Convert.ToDouble(clsTypeAppBess.GetApp(1010).Fees + FeesApplocal).ToString();
                return;
            }

            _application = clsApplicationBess.GetApplication(ID);

            if (_application == null)
            {
                MessageBox.Show("Application not found.");
                return;
            }
            label3.Text = _application.Fees.ToString();
            label4.Text = _application.AppID.ToString();
            label6.Text = Convert.ToDouble(_application.Fees + FeesApplocal).ToString();

           
        }
    }
}