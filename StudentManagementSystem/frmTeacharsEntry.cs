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
    public partial class frmTeacharsEntry : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-KU43MHN;database =StudentInfo; Trusted_Connection =True");
        public frmTeacharsEntry()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTeacharsEntry_Load(object sender, EventArgs e)
        {
            LoadGender();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                Image img =Image.FromFile(openFileDialog1.FileName);
                teachaesPic.Image = img;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                          cmbGender.SelectedIndex == -1 ||
                         dateTimePicker1.Value == null ||
                         dateTimePicker2.Value==null ||
                         teachaesPic.Image == null ||
                         string.IsNullOrWhiteSpace(txtphone.Text) ||
                         string.IsNullOrWhiteSpace(txtemail.Text) ||
               string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please Fill up All Fields");
            }
            else
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                img.Save(ms,ImageFormat.Bmp);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert into Teachers(TeacherId,Name,Address,DateOfBirth,Phone_Number,Email,Gender,JoinDate,Picture) values(@tId,@name,@add,@dob,@phone,@email,@gen,@join,@pic)";
                cmd.Parameters.AddWithValue("@tId", txtId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@add", txtAddress.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@phone",txtphone.Text);
                cmd.Parameters.AddWithValue("@email",txtemail.Text);
                cmd.Parameters.AddWithValue("@gen", cmbGender.SelectedValue);
                cmd.Parameters.AddWithValue("@join", dateTimePicker2.Value);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value=ms.ToArray()});
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Insered Succesfully");
                clearAll();
            }
          
        }
        private void LoadGender()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * FROM Gender ", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbGender.DataSource = dt;
            cmbGender.ValueMember = "GenderId";
            cmbGender.DisplayMember = "GenderName";
            con.Close();
        }
        private void clearAll()
        {
            txtId.Clear();
            txtName.Clear();
            txtAddress.Clear();
            teachaesPic.Image = null;
            txtphone.Clear();
            txtemail.Clear();
            txtId.Focus();
        }
    }
}
