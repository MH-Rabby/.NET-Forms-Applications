using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class frmEntryResults : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-KU43MHN;Database=StudentInfo;Trusted_connection=true");
        public frmEntryResults()
        {
            InitializeComponent();
        }

        private void frmEntryResults_Load(object sender, EventArgs e)
        {
            LoadClass();
            Loadsubject();
        }
        private void LoadClass()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *from class", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmdClass.DataSource = dt;
            cmdClass.ValueMember = "Classid";
            cmdClass.DisplayMember = "ClassName";
            cmdClass2.DataSource = dt;
            cmdClass2.ValueMember = "Classid";
            cmdClass2.DisplayMember = "ClassName";
            con.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           for(int i = 0; i < DatagridEntryResult.Rows.Count; i++)
            {
                if (  DatagridEntryResult.Rows[i].Cells["cmdsubject"].Value !=null && DatagridEntryResult.Rows[i].Cells ["txtmarks"].Value != null )
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    //Query
                    cmd.CommandText = "insert into EntryResult(StudentId,Subjectid,Marks,classid) values(@studentid,@classid,@subjectId,@marks) ";
                    //peramiter

                    cmd.Parameters.AddWithValue("@studentid", txtidentry.Text);
                    cmd.Parameters.AddWithValue("@classid", cmdClass2.SelectedValue);
                    cmd.Parameters.AddWithValue("@subjectId", DatagridEntryResult.Rows[i].Cells["cmdsubject"].Value);
                    cmd.Parameters.AddWithValue("@marks", DatagridEntryResult.Rows[i].Cells["txtmarks"].Value);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Inserted Successfully");
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please fill all fields first ");
                }
               
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdClass2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtserch2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmdClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DataGridshowresult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtsearch.Text))
            {
                MessageBox.Show("Please Enter A Valid Id");
            }
            else
            {

                con.Open();           
                string query = "select er.StudentId,Name,s.RollNo,c.className,sub.SubjectName,Marks\r\nfrom EntryResult er\r\nInner join   student s\r\non er.StudentId=s.StudentId\r\ninner join Subjects sub\r\non er.Subjectid=sub.SubjectId\r\ninner join class c\r\non er.classid=c.ClassId WHERE er.classid = @ClassId AND er.StudentId = @StudentId";          
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.Parameters.AddWithValue("@ClassId", txtsearch.Text);
                sda.SelectCommand.Parameters.AddWithValue("@StudentId", cmdClass.SelectedValue);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataGridshowresult.DataSource = dt;
                con.Close();


            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DatagridEntryResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }
      private void Loadsubject()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *FROM Subjects", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            CmdSubject.DataSource = dt;
            CmdSubject.ValueMember = "SubjectId";
            CmdSubject.DisplayMember = "SubjectName";
            con.Close();

        }
    }
}
