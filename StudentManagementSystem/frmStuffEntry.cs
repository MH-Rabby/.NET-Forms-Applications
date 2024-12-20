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
    public partial class frmStuffEntry : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-KU43MHN;database =StudentInfo; Trusted_Connection =True");
        public frmStuffEntry()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
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
                //Image first
                Image img =Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms =new MemoryStream();
                img.Save(ms,ImageFormat.Bmp);
                //Main Insert (Other field)
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Stuffs(StuffId,Name,DateOfBirth,PhoneNumber,Email,Address,Designationid,Salary,joindate,Picture,gerderId) values(@id,@name,@dob,@phone,@email,@add,@desi,@salary,@joindate,@pic,@gender)";
                cmd.Parameters.AddWithValue("@id",txtId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", dobpicker1.Value);
                cmd.Parameters.AddWithValue("@phone", txtphone.Text);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@add",txtAddress.Text);
                cmd.Parameters.AddWithValue("@desi", cmbDesignation.SelectedValue);
                cmd.Parameters.AddWithValue("@salary", txtsalary.Text);
                cmd.Parameters.AddWithValue("@joindate", joinpicker2.Value);
                cmd.Parameters.AddWithValue("@gender",cmbGender.SelectedValue);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value=ms.ToArray()});
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted Succesfully");
                con.Close();
                clearAll();
            }
                    



        }
        private void LoadGender()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *from Gender",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbGender.DataSource = dt;
            cmbGender.ValueMember = "genderId";
            cmbGender.DisplayMember="GenderName";       
            con.Close();
            
        }
        private void LoadDegination()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT *From Designations", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbDesignation.DataSource = dt;
            cmbDesignation.ValueMember = "DesignatinId";
            cmbDesignation.DisplayMember = "Designation";
            con.Close();
        }

        private void frmStuffEntry_Load(object sender, EventArgs e)
        {
            LoadGender();
            LoadDegination();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                Image img =Image.FromFile(openFileDialog1.FileName);
                this.StuffPic.Image = img;
            }
        }
        private void clearAll()
        {
            con.Open();
            txtId.Clear();
            txtName.Clear();
            txtphone.Clear();
            txtemail.Clear();
            txtAddress.Clear();
            txtsalary.Clear();
            StuffPic.Image = null;
            con.Close();
            txtId.Focus();

        }
    }
}
