using BussinassLayer;
using System;
using System.Windows.Forms;

namespace Project_DVLD_version1
{
    public partial class FormAddNewAppRetaketest : Form
    {
        public delegate void valuenumberlist(int i);
        valuenumberlist myvaluenumberlist;

        public bool Isavli = true;

        public clsUserBess _cls;

        public int _ID = -1;
        public int IDUser;

        public string national = string.Empty;

        private bool illegi;

        public FormAddNewAppRetaketest(int id = -1, bool b = false)
        {
            InitializeComponent();

            IDUser = id;
            illegi = b;

            myvaluenumberlist = ctrl_Multi_fillter1.changeNumberList;

            ctrl_Multi_fillter1.Mynumberuser += FunSendnumberuser;
            ctrl_Multi_fillter1.sendstringuser += FunSendStringuser;

            if (b)
            {
                ctrl_Multi_fillter1.EnableFillter = false;
                ctrl_Multi_fillter1.EnableMaskText = false;
                ctrl_Multi_fillter1.Enablebuttun = false;

                Isavli = false;
            }
        }

        private void FormAddNewAppRetaketest_Load(object sender, EventArgs e)
        {
            if (IDUser == -1)
                _cls = new clsUserBess();
            ctrl_Multi_fillter1.changeNumberList(1);
            ctrl_Multi_fillter1.FocusMask();
        }

        private void FunSendnumberuser(int id)
        {
            _ID = id;
            national = string.Empty;

            ctrl_show_Info_Person1.ReceiveData(id);
        }

        private void FunSendStringuser(string nationalNo)
        {
            national = nationalNo;
            _ID = -1;

            ctrl_show_Info_Person1.ReceiveData(nationalNo);
        }

        private void ctrl_show_Info_Person1_Load(object sender, EventArgs e)
        {
            ctrl_show_Info_Person1.showLinkEditPicture = true;

            if (illegi)
            {
                clsUserBess user = clsUserBess.GetUser(IDUser);

                if (user != null)
                {
                    ctrl_show_Info_Person1.ReceiveData(user.PersonID);
                }
            }
        }

        private void ctrl_Multi_fillter1_Load(object sender, EventArgs e)
        {
            ctrl_Multi_fillter1.FocusMask();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsPersonBess person = null;

            if (_ID != -1)
            {
                person = clsPersonBess.GetPersonById(_ID);
            }
            else if (!string.IsNullOrWhiteSpace(national))
            {
                person = clsPersonBess.GetPersonByNationalNo(national);
            }
            else
            {
                MessageBox.Show("Please select a person first.",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (person == null)
            {
                MessageBox.Show("Person not found.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            if (!illegi && clsUserBess.IsUser(person.ID))
            {
                person.ImagePath = ctrl_show_Info_Person1.PathImage;
                person.Save();

                MessageBox.Show("This person is already a user.",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            person.ImagePath = ctrl_show_Info_Person1.PathImage;

            if (person.Save())
            {
                Isavli = false;

                MessageBox.Show("Data saved successfully.",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Save failed.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (clsApplicationBess.GetApplicationRetakeTest(_ID).AppState==clsApplicationBess.EnState.New)
            {
                MessageBox.Show("The Person Have Application Retake test State New");
            }
            else
            {
               
                clsApplicationBess cls = new clsApplicationBess();
                cls.AppState = clsApplicationBess.EnState.New;
                cls.AppDate = DateTime.Now;
                cls.Fees = clsTypeAppBess.GetApp(1010).Fees;
                cls.AppLastStateUpdateDate = DateTime.Now;
                cls.AppTypeID = 1010;
                cls.PersonID = _ID;
                cls.UserID = clsUserBess.GetUserByUserName(clsGlobalUser.UserName).ID;
                if (cls.Save())
                {
                    MessageBox.Show($"Successfully Insert New Application retake test Number ID {cls.AppID}");
                }
                else
                {
                    MessageBox.Show($"Not Successfully Insert New Application retake test");

                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}