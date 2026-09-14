using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DVLD_version1.international
{
    public partial class FormInsertLicenseNewInternational : Form
    {
        private int _ID;
        private bool IsShowFilter;
        private bool IsIssue;

        // المُنشئ الافتراضي
        public FormInsertLicenseNewInternational()
        {
            InitializeComponent();
            _ID = -1;
            IsShowFilter = false;
            IsIssue = false;
        }

        // المُنشئ مع المعاملات
        public FormInsertLicenseNewInternational(int id, bool Isshowfilter = false, bool IsIssue = false)
        {
            InitializeComponent();
            _ID = id;
            this.IsShowFilter = Isshowfilter;
            this.IsIssue = IsIssue;
        }

        private void FormInsertLicenseNewInternational_Load(object sender, EventArgs e)
        {
            // التحقق من أن _ID ليس -1 قبل تحميل البيانات
            if (_ID != -1)
            {
                // تحميل البيانات في الـ UserControl
                ctrlShowInternationalLicense1.LoadData(_ID, this.IsShowFilter, this.IsIssue);
            }
        }
    }
}