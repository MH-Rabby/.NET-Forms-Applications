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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManagementSystem
{
    public partial class frmStudentEntry : Form
    {
        SqlConnection con =new SqlConnection("server =DESKTOP-KU43MHN;database =StudentInfo; Trusted_Connection =True");
        public frmStudentEntry()
        {
            InitializeComponent();
        }

        private void cmbCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmStudentEntry_Load(object sender, EventArgs e)
        {
            LoadGender();
            LoadClass();
            LoadSection();  
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        //This button1_click is for select file from pc
        private void button1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                Image img =Image.FromFile(openFileDialog1.FileName);
                this.studentPicture.Image = img;
            }
        }

        private void txtGerdianPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtRoll.Text) ||
                string.IsNullOrWhiteSpace(txtfatherName.Text) ||
                string.IsNullOrWhiteSpace(txtMotherName.Text) ||
                          cmbGender.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtgerdianName.Text) ||
                string.IsNullOrWhiteSpace(txtGerdianPhone.Text) ||
                         dateTimePicker1.Value == null ||
                         studentPicture.Image == null ||
                         cmbClass.SelectedIndex == -1 ||
               string.IsNullOrWhiteSpace(txtBrC.Text) ||
               string.IsNullOrWhiteSpace(txtFnid.Text) ||
               string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please Fill up All Fields");
            }
            else
            {
                Image img = Image.FromFile(openFileDialog1.FileName);
                MemoryStream ms = new MemoryStream();
                img.Save(ms, ImageFormat.Bmp);
                //for normal data entry
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "Insert into student (StudentId,Name,RollNo,Fathers_Name,Mothers_Name,Gender,Gerdians_Name,Gerdians_Phone,DateOfBirth,Picture,classID,BirthCRNO,FatherNIDno,address)\r\nValues(@id,@name,@roll,@fatherN,@motherN,@gen,@gerdianN,@gerdianP,@dob,@pic,@cid,@bcrno,@fathId,@add)";
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@roll", txtRoll.Text);
                cmd.Parameters.AddWithValue("@fatherN", txtfatherName.Text);
                cmd.Parameters.AddWithValue("@motherN", txtMotherName.Text);
                cmd.Parameters.AddWithValue("@gen", cmbGender.SelectedValue);
                cmd.Parameters.AddWithValue("@gerdianN", txtgerdianName.Text);
                cmd.Parameters.AddWithValue("@gerdianP", txtGerdianPhone.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Value);
                cmd.Parameters.Add(new SqlParameter("@pic", SqlDbType.VarBinary) { Value = ms.ToArray() });
                cmd.Parameters.AddWithValue("@cid", cmbClass.SelectedValue);
                cmd.Parameters.AddWithValue("@bcrno", txtBrC.Text);
                cmd.Parameters.AddWithValue("@fathid", txtFnid.Text);
                cmd.Parameters.AddWithValue("@add", txtAddress.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Inserted SuccesFully");
                clearAll();
            }
            
        }
        private void LoadGender()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select *from Gender",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbGender.DataSource = dt;
            cmbGender.ValueMember = "GenderId";
            cmbGender.DisplayMember = "GenderName";
            con.Close();

        }
        private void LoadClass()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from Class",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbClass.DataSource = dt;
            cmbClass.ValueMember = "ClassId";
            cmbClass.DisplayMember = "ClassName";
            con.Close();

        }
        private void LoadSection ()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *from Section", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbSection.DataSource = dt;
            cmbSection.ValueMember = "SectionId";
            cmbSection.DisplayMember = "SectionName";
            con.Close();

        }
        private void clearAll()
        {
            con.Open();
            txtId.Clear();
            txtName.Clear();
            txtRoll.Clear();    
            txtfatherName.Clear();
            txtMotherName.Clear();
            txtGerdianPhone.Clear();
            txtgerdianName.Clear();
            txtBrC.Clear();
            txtFnid.Clear();
            txtAddress.Clear();
            studentPicture.Image = null;
            con.Close();
            
        }
    }
}
