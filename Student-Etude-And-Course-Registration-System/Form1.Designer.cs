namespace Student_Etude_And_Course_Registration_System
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbxTeachers = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MTbxHour = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MTbxDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CbxCourses = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtEtudeWrite = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DgvEtudes = new System.Windows.Forms.DataGridView();
            this.TbxStudent = new System.Windows.Forms.TextBox();
            this.TbxEtudeId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TbxStudentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbxStudentSurname = new System.Windows.Forms.TextBox();
            this.BtStudentAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.TbxClass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TbxMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtCourseAdd = new System.Windows.Forms.Button();
            this.TbxCourseName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtCreateEtude = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BtUploadPhoto = new System.Windows.Forms.Button();
            this.PbxPhoto = new System.Windows.Forms.PictureBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.TbxTeacherName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TbxTeacherSurname = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.CbxCourseName = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BtTeacherAdd = new System.Windows.Forms.Button();
            this.MTbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvEtudes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtCreateEtude);
            this.groupBox1.Controls.Add(this.CbxTeachers);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MTbxHour);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MTbxDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CbxCourses);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(10, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // CbxTeachers
            // 
            this.CbxTeachers.FormattingEnabled = true;
            this.CbxTeachers.Location = new System.Drawing.Point(112, 59);
            this.CbxTeachers.Name = "CbxTeachers";
            this.CbxTeachers.Size = new System.Drawing.Size(121, 24);
            this.CbxTeachers.Sorted = true;
            this.CbxTeachers.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(60, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hour:";
            // 
            // MTbxHour
            // 
            this.MTbxHour.Location = new System.Drawing.Point(112, 132);
            this.MTbxHour.Mask = "90:00";
            this.MTbxHour.Name = "MTbxHour";
            this.MTbxHour.Size = new System.Drawing.Size(121, 22);
            this.MTbxHour.TabIndex = 6;
            this.MTbxHour.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date:";
            // 
            // MTbxDate
            // 
            this.MTbxDate.Location = new System.Drawing.Point(112, 92);
            this.MTbxDate.Mask = "00/00/0000";
            this.MTbxDate.Name = "MTbxDate";
            this.MTbxDate.Size = new System.Drawing.Size(121, 22);
            this.MTbxDate.TabIndex = 4;
            this.MTbxDate.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Teacher:";
            // 
            // CbxCourses
            // 
            this.CbxCourses.FormattingEnabled = true;
            this.CbxCourses.Location = new System.Drawing.Point(112, 21);
            this.CbxCourses.Name = "CbxCourses";
            this.CbxCourses.Size = new System.Drawing.Size(121, 24);
            this.CbxCourses.TabIndex = 1;
            this.CbxCourses.SelectedIndexChanged += new System.EventHandler(this.CbxCourses_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TbxEtudeId);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TbxStudent);
            this.groupBox2.Controls.Add(this.BtEtudeWrite);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(286, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // BtEtudeWrite
            // 
            this.BtEtudeWrite.Location = new System.Drawing.Point(122, 88);
            this.BtEtudeWrite.Name = "BtEtudeWrite";
            this.BtEtudeWrite.Size = new System.Drawing.Size(121, 30);
            this.BtEtudeWrite.TabIndex = 10;
            this.BtEtudeWrite.Text = "Etude Write";
            this.BtEtudeWrite.UseVisualStyleBackColor = true;
            this.BtEtudeWrite.Click += new System.EventHandler(this.BtEtudeWrite_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(46, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Student:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DgvEtudes);
            this.groupBox3.Location = new System.Drawing.Point(10, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(870, 304);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // DgvEtudes
            // 
            this.DgvEtudes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvEtudes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvEtudes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvEtudes.Location = new System.Drawing.Point(3, 19);
            this.DgvEtudes.Name = "DgvEtudes";
            this.DgvEtudes.Size = new System.Drawing.Size(864, 282);
            this.DgvEtudes.TabIndex = 0;
            this.DgvEtudes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEtudes_CellClick);
            // 
            // TbxStudent
            // 
            this.TbxStudent.Location = new System.Drawing.Point(122, 54);
            this.TbxStudent.Name = "TbxStudent";
            this.TbxStudent.Size = new System.Drawing.Size(121, 23);
            this.TbxStudent.TabIndex = 11;
            // 
            // TbxEtudeId
            // 
            this.TbxEtudeId.Location = new System.Drawing.Point(122, 25);
            this.TbxEtudeId.Name = "TbxEtudeId";
            this.TbxEtudeId.ReadOnly = true;
            this.TbxEtudeId.Size = new System.Drawing.Size(121, 23);
            this.TbxEtudeId.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(46, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Etude Id:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.TbxCourseName);
            this.groupBox4.Controls.Add(this.BtCourseAdd);
            this.groupBox4.Location = new System.Drawing.Point(286, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 69);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.MTbxPhone);
            this.groupBox5.Controls.Add(this.TbxMail);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.TbxClass);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.TbxStudentName);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.TbxStudentSurname);
            this.groupBox5.Controls.Add(this.BtStudentAdd);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(612, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(268, 206);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            // 
            // TbxStudentName
            // 
            this.TbxStudentName.Location = new System.Drawing.Point(122, 13);
            this.TbxStudentName.Name = "TbxStudentName";
            this.TbxStudentName.Size = new System.Drawing.Size(121, 23);
            this.TbxStudentName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(60, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Name:";
            // 
            // TbxStudentSurname
            // 
            this.TbxStudentSurname.Location = new System.Drawing.Point(122, 41);
            this.TbxStudentSurname.Name = "TbxStudentSurname";
            this.TbxStudentSurname.Size = new System.Drawing.Size(121, 23);
            this.TbxStudentSurname.TabIndex = 11;
            // 
            // BtStudentAdd
            // 
            this.BtStudentAdd.Location = new System.Drawing.Point(122, 153);
            this.BtStudentAdd.Name = "BtStudentAdd";
            this.BtStudentAdd.Size = new System.Drawing.Size(121, 30);
            this.BtStudentAdd.TabIndex = 10;
            this.BtStudentAdd.Text = "Student Add";
            this.BtStudentAdd.UseVisualStyleBackColor = true;
            this.BtStudentAdd.Click += new System.EventHandler(this.BtStudentAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(37, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Surname:";
            // 
            // TbxClass
            // 
            this.TbxClass.Location = new System.Drawing.Point(122, 69);
            this.TbxClass.Name = "TbxClass";
            this.TbxClass.Size = new System.Drawing.Size(121, 23);
            this.TbxClass.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(60, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Class:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(54, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Phone:";
            // 
            // TbxMail
            // 
            this.TbxMail.Location = new System.Drawing.Point(122, 125);
            this.TbxMail.Name = "TbxMail";
            this.TbxMail.Size = new System.Drawing.Size(121, 23);
            this.TbxMail.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(70, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Mail:";
            // 
            // BtCourseAdd
            // 
            this.BtCourseAdd.Location = new System.Drawing.Point(191, 23);
            this.BtCourseAdd.Name = "BtCourseAdd";
            this.BtCourseAdd.Size = new System.Drawing.Size(121, 30);
            this.BtCourseAdd.TabIndex = 13;
            this.BtCourseAdd.Text = "Course Add";
            this.BtCourseAdd.UseVisualStyleBackColor = true;
            this.BtCourseAdd.Click += new System.EventHandler(this.BtCourseAdd_Click);
            // 
            // TbxCourseName
            // 
            this.TbxCourseName.Location = new System.Drawing.Point(73, 27);
            this.TbxCourseName.Name = "TbxCourseName";
            this.TbxCourseName.Size = new System.Drawing.Size(113, 23);
            this.TbxCourseName.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 10;
            this.label12.Text = "Course:";
            // 
            // BtCreateEtude
            // 
            this.BtCreateEtude.Location = new System.Drawing.Point(112, 165);
            this.BtCreateEtude.Name = "BtCreateEtude";
            this.BtCreateEtude.Size = new System.Drawing.Size(121, 30);
            this.BtCreateEtude.TabIndex = 9;
            this.BtCreateEtude.Text = "Create Etude";
            this.BtCreateEtude.UseVisualStyleBackColor = true;
            this.BtCreateEtude.Click += new System.EventHandler(this.BtCreateEtude_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.PbxPhoto);
            this.groupBox6.Controls.Add(this.BtUploadPhoto);
            this.groupBox6.Location = new System.Drawing.Point(886, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(239, 206);
            this.groupBox6.TabIndex = 20;
            this.groupBox6.TabStop = false;
            // 
            // BtUploadPhoto
            // 
            this.BtUploadPhoto.Location = new System.Drawing.Point(6, 162);
            this.BtUploadPhoto.Name = "BtUploadPhoto";
            this.BtUploadPhoto.Size = new System.Drawing.Size(104, 30);
            this.BtUploadPhoto.TabIndex = 10;
            this.BtUploadPhoto.Text = "Upload Photo";
            this.BtUploadPhoto.UseVisualStyleBackColor = true;
            this.BtUploadPhoto.Click += new System.EventHandler(this.BtUploadPhoto_Click);
            // 
            // PbxPhoto
            // 
            this.PbxPhoto.Location = new System.Drawing.Point(58, 16);
            this.PbxPhoto.Name = "PbxPhoto";
            this.PbxPhoto.Size = new System.Drawing.Size(121, 128);
            this.PbxPhoto.TabIndex = 11;
            this.PbxPhoto.TabStop = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.BtTeacherAdd);
            this.groupBox7.Controls.Add(this.CbxCourseName);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.TbxTeacherName);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.TbxTeacherSurname);
            this.groupBox7.Location = new System.Drawing.Point(886, 218);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(239, 304);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            // 
            // TbxTeacherName
            // 
            this.TbxTeacherName.Location = new System.Drawing.Point(97, 22);
            this.TbxTeacherName.Name = "TbxTeacherName";
            this.TbxTeacherName.Size = new System.Drawing.Size(121, 23);
            this.TbxTeacherName.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(35, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Name:";
            // 
            // TbxTeacherSurname
            // 
            this.TbxTeacherSurname.Location = new System.Drawing.Point(97, 50);
            this.TbxTeacherSurname.Name = "TbxTeacherSurname";
            this.TbxTeacherSurname.Size = new System.Drawing.Size(121, 23);
            this.TbxTeacherSurname.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 53);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 16);
            this.label14.TabIndex = 20;
            this.label14.Text = "Surname:";
            // 
            // CbxCourseName
            // 
            this.CbxCourseName.FormattingEnabled = true;
            this.CbxCourseName.Location = new System.Drawing.Point(97, 79);
            this.CbxCourseName.Name = "CbxCourseName";
            this.CbxCourseName.Size = new System.Drawing.Size(121, 24);
            this.CbxCourseName.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(28, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Course:";
            // 
            // BtTeacherAdd
            // 
            this.BtTeacherAdd.Location = new System.Drawing.Point(97, 122);
            this.BtTeacherAdd.Name = "BtTeacherAdd";
            this.BtTeacherAdd.Size = new System.Drawing.Size(121, 30);
            this.BtTeacherAdd.TabIndex = 15;
            this.BtTeacherAdd.Text = "Teacher Add";
            this.BtTeacherAdd.UseVisualStyleBackColor = true;
            this.BtTeacherAdd.Click += new System.EventHandler(this.BtTeacherAdd_Click);
            // 
            // MTbxPhone
            // 
            this.MTbxPhone.Location = new System.Drawing.Point(122, 97);
            this.MTbxPhone.Mask = "(999) 000-0000";
            this.MTbxPhone.Name = "MTbxPhone";
            this.MTbxPhone.Size = new System.Drawing.Size(121, 23);
            this.MTbxPhone.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1137, 533);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Etude Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvEtudes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbxPhoto)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbxTeachers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MTbxHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MTbxDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CbxCourses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtEtudeWrite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView DgvEtudes;
        private System.Windows.Forms.TextBox TbxEtudeId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbxStudent;
        private System.Windows.Forms.Button BtCreateEtude;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TbxCourseName;
        private System.Windows.Forms.Button BtCourseAdd;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TbxMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TbxClass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbxStudentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TbxStudentSurname;
        private System.Windows.Forms.Button BtStudentAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.PictureBox PbxPhoto;
        private System.Windows.Forms.Button BtUploadPhoto;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button BtTeacherAdd;
        private System.Windows.Forms.ComboBox CbxCourseName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TbxTeacherName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbxTeacherSurname;
        private System.Windows.Forms.MaskedTextBox MTbxPhone;
    }
}

