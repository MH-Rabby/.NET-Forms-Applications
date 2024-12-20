using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    
    public partial class frmUpdate_Delete : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-KU43MHN;database =StudentInfo; Trusted_Connection =True");
        public frmUpdate_Delete()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtsearch.Text))
            {
                MessageBox.Show("Enter valid Studern ID on SearchBar");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select *from student where  studentId =" + txtsearch.Text + "", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                datagridupdate.DataSource = dt;
                con.Close();
            }
          
        }

        private void frmUpdate_Delete_Load(object sender, EventArgs e)
        {
            LoadGender();
            LoadClass();
            LoadSection();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnPicChose_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                pictureboxUpdate.Image = img;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Image img = Image.FromFile(openFileDialog1.FileName);
            MemoryStream ms = new MemoryStream();
            img.Save(ms,ImageFormat.Bmp);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Update student set StudentId=@sid,Name=@name,RollNo=@roll,Fathers_Name=@fname,Mothers_Name=@mName,Gender =@gnder,Gerdians_Name=@gname,Gerdians_Phone=@Gphone,DateOfBirth=@dob,Picture=@pic,classID=@CiD,BirthCRNO=@BCRNO,FatherNIDno=@FNID,address=@add where studentId ="+txtsearch.Text+"";
            cmd.Parameters.AddWithValue("@sid",txtIdu.Text);
            cmd.Parameters.AddWithValue("@name",txtNameu.Text);
            cmd.Parameters.AddWithValue("@roll",txtRollU.Text);
            cmd.Parameters.AddWithValue("@fname",txtfatherNameu.Text);
            cmd.Parameters.AddWithValue("@mName",txtMotherNameU.Text);
            cmd.Parameters.AddWithValue("@gnder",cmbGenderU.SelectedValue);
            cmd.Parameters.AddWithValue("@gname",txtgerdianNameU.Text);
            cmd.Parameters.AddWithValue("@Gphone",txtGerdianPhoneU.Text);
            cmd.Parameters.AddWithValue("@dob",dateTimePicker1U.Value);
            cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value=ms.ToArray()});
            cmd.Parameters.AddWithValue("@Cid", cmbClassU.SelectedValue);
            cmd.Parameters.AddWithValue("@BCRNO", txtBrCU.Text);
            cmd.Parameters.AddWithValue("@FNID", txtFnidu.Text);
            cmd.Parameters.AddWithValue("@add", txtAddressU.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated SuccesFully");
            clearAll();
            con.Close();
        }
        private void LoadGender()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select *from Gender", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbGenderU.DataSource = dt;
            cmbGenderU.ValueMember = "GenderId";
            cmbGenderU.DisplayMember = "GenderName";
            con.Close();

        }
        private void LoadClass()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Class", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbClassU.DataSource = dt;
            cmbClassU.ValueMember = "ClassId";
            cmbClassU.DisplayMember = "ClassName";
            con.Close();

        }
        private void LoadSection()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *from Section", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbSectionU.DataSource = dt;
            cmbSectionU.ValueMember = "SectionId";
            cmbSectionU.DisplayMember = "SectionName";
            con.Close();

        }
        private void clearAll()
        {
            txtsearch.Clear();
            txtNameu.Clear();
            datagridupdate.ClearSelection();
            txtIdu.Clear();
            txtRollU.Clear();
            txtfatherNameu.Clear();
            txtFnidu.Clear();
            txtMotherNameU.Clear();
            txtgerdianNameU.Clear();
            txtGerdianPhoneU.Clear();
            pictureboxUpdate.CancelAsync();
            txtBrCU.Clear();
            txtFnidu.Clear();
            txtAddressU.Clear();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *from Student",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datagridupdate.DataSource = dt;
            con.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM student WHERE StudentId=" + txtsearch.Text + "";
                cmd.ExecuteNonQuery();
                txtsearch.Clear();
                txtsearch.Focus();
                MessageBox.Show("Data Deleted Succesfully");

                con.Close();
            
           
        }
    }
}
