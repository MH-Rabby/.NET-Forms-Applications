using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{

    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-KU43MHN;database =StudentInfo; Trusted_Connection =True");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *FROM Teachers", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datagridupdate.DataSource = dt;
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtsearch.Text))
            {
                MessageBox.Show("Please Enter A Valid Teachersid First");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Teachers where Teacherid = " + txtsearch.Text + "", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                datagridupdate.DataSource = dt;
                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
            string.IsNullOrWhiteSpace(txtName.Text) ||
            string.IsNullOrWhiteSpace(txtphone.Text) ||
            string.IsNullOrWhiteSpace(txtemail.Text) ||
            string.IsNullOrWhiteSpace(txtAddress.Text) ||          
            dobpicker1.Value == null ||
            joinpicker2.Value == null ||          
             cmbGender.SelectedIndex == -1 ||
             teachaesPic.Image == null)
            {
                MessageBox.Show("Please Fill Up All fields First");
                return;
            }
            if (txtphone.Text.Length > 11)
            {
                MessageBox.Show("Your phone number has more than 11 digits");
                return;
            }

            if (dobpicker1.Value >= joinpicker2.Value)
            {
                MessageBox.Show("Join Date Must be Smaller then Birth Date");
                return;
            }
            else
            {
                //For Image
                Image img = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);
                //for other
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Teachers set Teacherid=@id,Name=@name,DateOfBirth=@dob,Phone_Number=@phone,Email=@mail,Address=@add,Picture=@pic,gender=@genderid where Teacherid=" + txtId.Text + "";
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", dobpicker1.Value);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@mail", txtemail.Text);
                cmd.Parameters.AddWithValue("@add", txtAddress.Text);            
                cmd.Parameters.AddWithValue("@genderid", cmbGender.SelectedValue);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
                con.Close();
                clearAll();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                teachaesPic.Image = img;
            }
        }

        private void teachaesPic_Click(object sender, EventArgs e)
        {

        }
        private void clearAll()
        {
            txtId.Clear();
            txtName.Clear();
            txtphone.Clear();
            txtemail.Clear();
            txtAddress.Clear();
            teachaesPic.CancelAsync();

        }
        private void LoadGender()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select *from Gender", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbGender.DataSource = dt;
            cmbGender.ValueMember = "GenderId";
            cmbGender.DisplayMember = "GenderName";
            con.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadGender();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from Teachers where Teacherid =" + txtsearch.Text + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Succesfully");
            datagridupdate.Columns.Clear();
            con.Close();
        }
    }
}
