using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace Student_Etude_And_Course_Registration_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection sqlConnection = new SqlConnection(Properties.Settings.Default.ConnectionString);
        OpenFileDialog openFileDialog = new OpenFileDialog();
        public void CourseList()
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Courses", sqlConnection);
            sqlDataAdapter.Fill(dataTable);
            CbxCourses.ValueMember = "Id";
            CbxCourses.DisplayMember = "CourseName";
            CbxCourses.DataSource=dataTable;

            CbxCourseName.ValueMember = "Id";
            CbxCourseName.DisplayMember = "CourseName";
            CbxCourseName.DataSource = dataTable;
        }

        public void EtudeList()
        {
            //DataTable dataTable = new DataTable();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Etudes.Id,CourseName,(Teachers.Name +' '+Teachers.Surname) AS 'Teacher',(Students.Name +' '+Students.Surname) AS 'Student' FROM Etudes INNER JOIN Courses ON Etudes.CourseId=Course.Id INNER JOIN Teachers ON Etudes.TeacherId=Teachers.Id INNER JOIN Courses ON Etudes.StudentId=Students.Id"
            //    , sqlConnection);
            //sqlDataAdapter.Fill(dataTable);

            //DgvEtudes.DataSource = dataTable;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CbxCourses.Items.Clear();
            CbxTeachers.Items.Clear();
            CourseList();
            EtudeList();
        }

        private void CbxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT Name+' '+Surname AS Teacher FROM Teachers WHERE CourseId = " + CbxCourses.SelectedValue, sqlConnection);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);

            CbxTeachers.ValueMember = "Id";
            CbxTeachers.DisplayMember = "Teacher";
            CbxTeachers.DataSource = dt;

            sqlConnection.Close();
        }

        private void BtCreateEtude_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Etudes (CourseId,TeacherId,Date,Hour) VALUES (@p1,@p2,@p3,@p4)", sqlConnection);
            //int a = Convert.ToInt16(CbxTeachers.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@p1", Convert.ToInt16(CbxCourses.SelectedValue));
            sqlCommand.Parameters.AddWithValue("@p2", CbxTeachers.SelectedValue);
            sqlCommand.Parameters.AddWithValue("@p3", MTbxDate.Text.ToString());
            sqlCommand.Parameters.AddWithValue("@p4", MTbxHour.Text.ToString());
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Etude Has Been Added.","Create Etude",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtEtudeWrite_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Etudes SET StudentId=@p1,state=@p2 WHERE Id=@p3", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", TbxStudent.Text);
            sqlCommand.Parameters.AddWithValue("@p2", "True");
            sqlCommand.Parameters.AddWithValue("@p3", TbxEtudeId.Text);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Etude Has Been Updated.", "Update Etude", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DgvEtudes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int chosen = DgvEtudes.SelectedCells[0].RowIndex;
            TbxEtudeId.Text = DgvEtudes.Rows[chosen].Cells[0].Value.ToString();
        }

        private void BtTeacherAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Teachers (Name,Surname,CourseId) VALUES (@p1,@p2,@p3)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", TbxTeacherName.Text);
            sqlCommand.Parameters.AddWithValue("@p2", TbxTeacherSurname.Text);
            sqlCommand.Parameters.AddWithValue("@p3", CbxCourseName.SelectedValue);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Teacher Has Been Added.", "Create Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtStudentAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = System.IO.Path.GetFileName(openFileDialog.FileName);
                if (filename == null)
                {
                    MessageBox.Show("Please select a valid image.");
                }
                else
                {
                    //we already define our connection globaly. We are just calling the object of connection.
                    //SqlCommand cmd = new SqlCommand("insert into wallpaper (image)values('\\Image\\" + filename + "')", con);
                    

                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Students (Name,Surname,Photo,Class,Phone,Mail) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@p1", TbxStudentName.Text);
                    sqlCommand.Parameters.AddWithValue("@p2", TbxStudentSurname.Text);
                    sqlCommand.Parameters.AddWithValue("@p3", "\\Image\\" + filename);
                    sqlCommand.Parameters.AddWithValue("@p4", TbxClass.Text);
                    sqlCommand.Parameters.AddWithValue("@p5", MTbxPhone.Text);
                    sqlCommand.Parameters.AddWithValue("@p6", TbxMail.Text);
                    string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                    System.IO.File.Copy(openFileDialog.FileName, path + "\\Image\\" + filename);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Student Has Been Added.", "Create Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "File Already exits");
            }
        }

        private void BtCourseAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Courses (CourseName) VALUES (@p1)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@p1", TbxCourseName.Text);

            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();

            MessageBox.Show("Course Has Been Added.", "Create Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtUploadPhoto_Click(object sender, EventArgs e)
        {
            
            openFileDialog.InitialDirectory = "C://Desktop";
            openFileDialog.Title = "Select image to be upload.";
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            openFileDialog.FilterIndex = 1;
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog.CheckFileExists)
                    {
                        string path = System.IO.Path.GetFullPath(openFileDialog.FileName);
                        label1.Text = path;
                        PbxPhoto.Image = new Bitmap(openFileDialog.FileName);
                        PbxPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    MessageBox.Show("Please Upload image.");
                }
            }
            catch (Exception ex)
            {
                //it will give if file is already exits..
                MessageBox.Show(ex.Message);
            }

        }
    }
}
