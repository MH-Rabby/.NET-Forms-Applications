using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace StudentManagementSystem
{
    public partial class FrmShowAllTeacher : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-KU43MHN;database =StudentInfo; Trusted_Connection =True");
        public FrmShowAllTeacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTeachaerSerch.Text))
            {
                MessageBox.Show("Enter a valid TeachaerId First");
            }
            else 
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter(" select TeacherId,Name,Address,DateOfBirth,Phone_Number,Email,gendername,JoinDate,Picture from Teachers t\r\ninner join Gender g\r\non g.GenderId=t.Gender where TeacherId="+ txtTeachaerSerch.Text + "", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                datagridTeachars.DataSource = dt;
                con.Close();
                txtTeachaerSerch.Clear();
            };
        }
        

        private void FrmShowAllTeacher_Load(object sender, EventArgs e)
        {
        }

        private void btnAllstudent_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select TeacherId, Name, Address, DateOfBirth, Phone_Number, Email, gendername, JoinDate, Picture from Teachers t\r\ninner join Gender g\r\non g.GenderId = t.Gender", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datagridTeachars.DataSource = dt;
            con.Close();
        }
    }
}
