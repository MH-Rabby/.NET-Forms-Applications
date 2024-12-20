using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class FrmShowAllStudents : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-KU43MHN;database =StudentInfo; Trusted_Connection =True");
        public FrmShowAllStudents()
        {
            InitializeComponent();
        }

        private void btnAllstudent_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda =new SqlDataAdapter("select StudentId,Name,RollNo,Fathers_Name, Mothers_Name,GenderName,DateOfBirth,Picture,ClassName,BirthCRNO,FatherNIDno,address from student s\r\ninner join Gender g\r\non s.Gender=g.GenderId\r\ninner join class c\r\non s.classID=c.ClassId", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1 .DataSource= dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();            
            SqlDataAdapter sda = new SqlDataAdapter(" select StudentId,Name,RollNo,Fathers_Name, Mothers_Name,GenderName,DateOfBirth,Picture,ClassName,BirthCRNO,FatherNIDno,address from student s\r\ninner join Gender g\r\non s.Gender=g.GenderId\r\ninner join class c\r\non s.classID=c.ClassId where s.classID=" + cmbClass.SelectedValue+"",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void LoadCombo()
        {
            con.Open();
            SqlDataAdapter sda =new SqlDataAdapter("select *from Class",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);          
            cmbClass.DataSource= dt;
            cmbClass.ValueMember = "ClassId";
            cmbClass.DisplayMember = "ClassName";
            con.Close();
        }

        private void FrmShowAllStudents_Load(object sender, EventArgs e)
        {
            LoadCombo();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
