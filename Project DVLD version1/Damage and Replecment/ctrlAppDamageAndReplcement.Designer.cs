namespace Project_DVLD_version1.Damage_and_Replecment
{
    partial class ctrlAppDamageAndReplcement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbTitel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbIsdetained = new System.Windows.Forms.Label();
            this.lbExpiration = new System.Windows.Forms.Label();
            this.lbDriverid = new System.Windows.Forms.Label();
            this.lbbirth = new System.Windows.Forms.Label();
            this.lbActive = new System.Windows.Forms.Label();
            this.lbNotes = new System.Windows.Forms.Label();
            this.lbIssueReason = new System.Windows.Forms.Label();
            this.lbissuedate = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbNationall = new System.Windows.Forms.Label();
            this.lblicenseid = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.lbclassLicense = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbclass = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbFeesApp = new System.Windows.Forms.Label();
            this.lbdateApp = new System.Windows.Forms.Label();
            this.lbAppReplace = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbuser = new System.Windows.Forms.Label();
            this.lbLicenseOld = new System.Windows.Forms.Label();
            this.lbLicenseNew = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitel
            // 
            this.lbTitel.AutoSize = true;
            this.lbTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitel.ForeColor = System.Drawing.Color.Red;
            this.lbTitel.Location = new System.Drawing.Point(12, 14);
            this.lbTitel.Name = "lbTitel";
            this.lbTitel.Size = new System.Drawing.Size(65, 32);
            this.lbTitel.TabIndex = 0;
            this.lbTitel.Text = "???";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "License ID : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 93);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(141, 33);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(178, 22);
            this.maskedTextBox1.TabIndex = 2;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            this.maskedTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBox1_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.lbIsdetained);
            this.groupBox3.Controls.Add(this.lbExpiration);
            this.groupBox3.Controls.Add(this.lbDriverid);
            this.groupBox3.Controls.Add(this.lbbirth);
            this.groupBox3.Controls.Add(this.lbActive);
            this.groupBox3.Controls.Add(this.lbNotes);
            this.groupBox3.Controls.Add(this.lbIssueReason);
            this.groupBox3.Controls.Add(this.lbissuedate);
            this.groupBox3.Controls.Add(this.lbGender);
            this.groupBox3.Controls.Add(this.lbNationall);
            this.groupBox3.Controls.Add(this.lblicenseid);
            this.groupBox3.Controls.Add(this.lbname);
            this.groupBox3.Controls.Add(this.lbclassLicense);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbclass);
            this.groupBox3.Location = new System.Drawing.Point(18, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(877, 278);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Driver License Info";
            // 
            // lbIsdetained
            // 
            this.lbIsdetained.AutoSize = true;
            this.lbIsdetained.Location = new System.Drawing.Point(430, 216);
            this.lbIsdetained.Name = "lbIsdetained";
            this.lbIsdetained.Size = new System.Drawing.Size(51, 16);
            this.lbIsdetained.TabIndex = 25;
            this.lbIsdetained.Text = "label24";
            // 
            // lbExpiration
            // 
            this.lbExpiration.AutoSize = true;
            this.lbExpiration.Location = new System.Drawing.Point(430, 186);
            this.lbExpiration.Name = "lbExpiration";
            this.lbExpiration.Size = new System.Drawing.Size(51, 16);
            this.lbExpiration.TabIndex = 24;
            this.lbExpiration.Text = "label25";
            // 
            // lbDriverid
            // 
            this.lbDriverid.AutoSize = true;
            this.lbDriverid.Location = new System.Drawing.Point(430, 156);
            this.lbDriverid.Name = "lbDriverid";
            this.lbDriverid.Size = new System.Drawing.Size(51, 16);
            this.lbDriverid.TabIndex = 23;
            this.lbDriverid.Text = "label26";
            // 
            // lbbirth
            // 
            this.lbbirth.AutoSize = true;
            this.lbbirth.Location = new System.Drawing.Point(430, 126);
            this.lbbirth.Name = "lbbirth";
            this.lbbirth.Size = new System.Drawing.Size(51, 16);
            this.lbbirth.TabIndex = 22;
            this.lbbirth.Text = "label27";
            // 
            // lbActive
            // 
            this.lbActive.AutoSize = true;
            this.lbActive.Location = new System.Drawing.Point(430, 96);
            this.lbActive.Name = "lbActive";
            this.lbActive.Size = new System.Drawing.Size(51, 16);
            this.lbActive.TabIndex = 21;
            this.lbActive.Text = "label28";
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Location = new System.Drawing.Point(118, 246);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(51, 16);
            this.lbNotes.TabIndex = 20;
            this.lbNotes.Text = "label15";
            // 
            // lbIssueReason
            // 
            this.lbIssueReason.AutoSize = true;
            this.lbIssueReason.Location = new System.Drawing.Point(118, 216);
            this.lbIssueReason.Name = "lbIssueReason";
            this.lbIssueReason.Size = new System.Drawing.Size(51, 16);
            this.lbIssueReason.TabIndex = 19;
            this.lbIssueReason.Text = "label17";
            // 
            // lbissuedate
            // 
            this.lbissuedate.AutoSize = true;
            this.lbissuedate.Location = new System.Drawing.Point(118, 186);
            this.lbissuedate.Name = "lbissuedate";
            this.lbissuedate.Size = new System.Drawing.Size(51, 16);
            this.lbissuedate.TabIndex = 18;
            this.lbissuedate.Text = "label18";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(118, 156);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(51, 16);
            this.lbGender.TabIndex = 17;
            this.lbGender.Text = "label19";
            // 
            // lbNationall
            // 
            this.lbNationall.AutoSize = true;
            this.lbNationall.Location = new System.Drawing.Point(118, 126);
            this.lbNationall.Name = "lbNationall";
            this.lbNationall.Size = new System.Drawing.Size(51, 16);
            this.lbNationall.TabIndex = 16;
            this.lbNationall.Text = "label20";
            // 
            // lblicenseid
            // 
            this.lblicenseid.AutoSize = true;
            this.lblicenseid.Location = new System.Drawing.Point(118, 96);
            this.lblicenseid.Name = "lblicenseid";
            this.lblicenseid.Size = new System.Drawing.Size(51, 16);
            this.lblicenseid.TabIndex = 15;
            this.lblicenseid.Text = "label21";
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.ForeColor = System.Drawing.Color.Red;
            this.lbname.Location = new System.Drawing.Point(118, 66);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(51, 16);
            this.lbname.TabIndex = 14;
            this.lbname.Text = "label22";
            // 
            // lbclassLicense
            // 
            this.lbclassLicense.AutoSize = true;
            this.lbclassLicense.Location = new System.Drawing.Point(118, 36);
            this.lbclassLicense.Name = "lbclassLicense";
            this.lbclassLicense.Size = new System.Drawing.Size(51, 16);
            this.lbclassLicense.TabIndex = 13;
            this.lbclassLicense.Text = "label23";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(340, 216);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 16);
            this.label16.TabIndex = 12;
            this.label16.Text = "Is Detained : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(317, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "Expiration Date : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(356, 156);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 16);
            this.label14.TabIndex = 10;
            this.label14.Text = "Driver ID : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(334, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "Date Of Birth : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(361, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "IsActive : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Notes : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Issuec Reason : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Issue Date : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Gender : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "National No : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "License ID : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name : ";
            // 
            // lbclass
            // 
            this.lbclass.AutoSize = true;
            this.lbclass.Location = new System.Drawing.Point(62, 36);
            this.lbclass.Name = "lbclass";
            this.lbclass.Size = new System.Drawing.Size(50, 16);
            this.lbclass.TabIndex = 0;
            this.lbclass.Text = "Class : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbuser);
            this.groupBox2.Controls.Add(this.lbLicenseOld);
            this.groupBox2.Controls.Add(this.lbLicenseNew);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.lbFeesApp);
            this.groupBox2.Controls.Add(this.lbAppReplace);
            this.groupBox2.Controls.Add(this.lbdateApp);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Location = new System.Drawing.Point(18, 461);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(876, 141);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Application Replacment Info : ";
            // 
            // lbFeesApp
            // 
            this.lbFeesApp.AutoSize = true;
            this.lbFeesApp.Location = new System.Drawing.Point(138, 98);
            this.lbFeesApp.Name = "lbFeesApp";
            this.lbFeesApp.Size = new System.Drawing.Size(51, 16);
            this.lbFeesApp.TabIndex = 32;
            this.lbFeesApp.Text = "label15";
            // 
            // lbdateApp
            // 
            this.lbdateApp.AutoSize = true;
            this.lbdateApp.Location = new System.Drawing.Point(138, 68);
            this.lbdateApp.Name = "lbdateApp";
            this.lbdateApp.Size = new System.Drawing.Size(51, 16);
            this.lbdateApp.TabIndex = 31;
            this.lbdateApp.Text = "label17";
            // 
            // lbAppReplace
            // 
            this.lbAppReplace.AutoSize = true;
            this.lbAppReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppReplace.ForeColor = System.Drawing.Color.Red;
            this.lbAppReplace.Location = new System.Drawing.Point(138, 38);
            this.lbAppReplace.Name = "lbAppReplace";
            this.lbAppReplace.Size = new System.Drawing.Size(41, 16);
            this.lbAppReplace.TabIndex = 30;
            this.lbAppReplace.Text = "[???]";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 98);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(116, 16);
            this.label17.TabIndex = 29;
            this.label17.Text = "Application Fess : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 16);
            this.label18.TabIndex = 28;
            this.label18.Text = "Application Date : ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 16);
            this.label19.TabIndex = 27;
            this.label19.Text = "L.R.Application ID : ";
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(509, 98);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(51, 16);
            this.lbuser.TabIndex = 38;
            this.lbuser.Text = "label15";
            // 
            // lbLicenseOld
            // 
            this.lbLicenseOld.AutoSize = true;
            this.lbLicenseOld.Location = new System.Drawing.Point(509, 68);
            this.lbLicenseOld.Name = "lbLicenseOld";
            this.lbLicenseOld.Size = new System.Drawing.Size(51, 16);
            this.lbLicenseOld.TabIndex = 37;
            this.lbLicenseOld.Text = "label17";
            // 
            // lbLicenseNew
            // 
            this.lbLicenseNew.AutoSize = true;
            this.lbLicenseNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseNew.ForeColor = System.Drawing.Color.Red;
            this.lbLicenseNew.Location = new System.Drawing.Point(509, 38);
            this.lbLicenseNew.Name = "lbLicenseNew";
            this.lbLicenseNew.Size = new System.Drawing.Size(41, 16);
            this.lbLicenseNew.TabIndex = 36;
            this.lbLicenseNew.Text = "[???]";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(420, 98);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(83, 16);
            this.label23.TabIndex = 35;
            this.label23.Text = "Created By : ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(400, 68);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(103, 16);
            this.label24.TabIndex = 34;
            this.label24.Text = "Old License ID : ";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(361, 38);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(142, 16);
            this.label25.TabIndex = 33;
            this.label25.Text = "License Replaced ID : ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Location = new System.Drawing.Point(537, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 92);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Replecment For : ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(15, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(163, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Damaged License";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(15, 57);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(143, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Losted License";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(721, 631);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(174, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Issue Replacmented";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 645);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(142, 16);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Show History Licenses";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(246, 645);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(183, 16);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Show New License Replaced";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_DVLD_version1.Properties.Resources.person_boy1;
            this.pictureBox1.InitialImage = global::Project_DVLD_version1.Properties.Resources.person_boy;
            this.pictureBox1.Location = new System.Drawing.Point(716, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = global::Project_DVLD_version1.Properties.Resources.zoom__1_;
            this.button1.Location = new System.Drawing.Point(364, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 41);
            this.button1.TabIndex = 3;
            this.button1.Text = "      ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrlAppDamageAndReplcement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTitel);
            this.Name = "ctrlAppDamageAndReplcement";
            this.Size = new System.Drawing.Size(1031, 737);
            this.Load += new System.EventHandler(this.ctrlAppDamageAndReplcement_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbIsdetained;
        private System.Windows.Forms.Label lbExpiration;
        private System.Windows.Forms.Label lbDriverid;
        private System.Windows.Forms.Label lbbirth;
        private System.Windows.Forms.Label lbActive;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.Label lbIssueReason;
        private System.Windows.Forms.Label lbissuedate;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbNationall;
        private System.Windows.Forms.Label lblicenseid;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label lbclassLicense;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbclass;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label lbLicenseOld;
        private System.Windows.Forms.Label lbLicenseNew;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbFeesApp;
        private System.Windows.Forms.Label lbAppReplace;
        private System.Windows.Forms.Label lbdateApp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
