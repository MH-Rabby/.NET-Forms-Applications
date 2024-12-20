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
    public partial class frmStuffUpdateDelete : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-KU43MHN;database =StudentInfo; Trusted_Connection =True");
        public frmStuffUpdateDelete()
        {
            InitializeComponent();
        }

        private void frmStuffUpdateDelete_Load(object sender, EventArgs e)
        {
            LoadGender();
            LoadDesignation();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *FROM Stuffs",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datagridupdate.DataSource = dt;
            con.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsearch.Text))
            {
                MessageBox.Show("Please Enter A Valid StuffId First");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from stuffs where StuffId = " + txtsearch.Text + "", con);
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
              string.IsNullOrWhiteSpace(txtsalary.Text) ||
              dobpicker1.Value == null ||
              joinpicker2.Value == null ||
               cmbDesignation.SelectedIndex == -1 ||
               cmbGender.SelectedIndex == -1 ||
               StuffPic.Image == null)
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
                cmd.CommandText = "update Stuffs set StuffId=@id,Name=@name,DateOfBirth=@dob,PhoneNumber=@phone,Email=@mail,Address=@add,Designationid=@degid,Picture=@pic,gerderId=@genderid where stuffid="+txtId.Text+"";
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", dobpicker1.Value);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@mail", txtemail.Text);
                cmd.Parameters.AddWithValue("@add", txtAddress.Text);
                cmd.Parameters.AddWithValue("@degid", cmbDesignation.SelectedValue);
                cmd.Parameters.AddWithValue("@genderid", cmbGender.SelectedValue);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Successfully");
                con.Close();
                clearAll();
            }
               
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
        private void LoadDesignation()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *FROM DESIGNATIONS ",con);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            cmbDesignation.DataSource = dt;
            cmbDesignation.DisplayMember = "Designation";
            cmbDesignation.ValueMember = "DesignatinId";
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                StuffPic.Image = img;
            }
        }
        private void clearAll()
        {
            txtId.Clear();
            txtName.Clear();
            txtphone.Clear();
            txtemail.Clear();
            txtAddress.Clear();  
            cmbDesignation.Items.Clear();
            StuffPic.CancelAsync();

        }

        private void datagridupdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StuffPic_Click(object sender, EventArgs e)
        {

        }

        private void joinpicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dobpicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbDesignation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "Delete from stuffs where stuffid =" + txtsearch.Text + "";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Deleted Succesfully");
            datagridupdate.Columns.Clear();
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
