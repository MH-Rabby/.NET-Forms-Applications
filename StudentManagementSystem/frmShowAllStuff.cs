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
    public partial class frmShowAllStuff : Form
    {
        SqlConnection con = new SqlConnection("server =DESKTOP-KU43MHN;database =StudentInfo; Trusted_Connection =True");
        public frmShowAllStuff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda =new SqlDataAdapter("select stuffid,Name,DateOfBirth,PhoneNumber,Email,Address,Designation,Salary,joindate,Picture,GenderName from Stuffs s\r\n  inner join Gender g\r\n  ON s.gerderId=g.GenderId\r\n  inner join Designations d\r\n  on s.Designationid=d.DesignatinId  where stuffid="+cmbDesignation.SelectedValue+"", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datagridStuff.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void loadDesignation()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *from Designations",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmbDesignation.DataSource = dt;
            cmbDesignation.ValueMember = "DesignatinId";
            cmbDesignation.DisplayMember = "Designation";
            con.Close();
        }

        private void frmShowAllStuff_Load(object sender, EventArgs e)
        {
            loadDesignation();
        }

        private void btnAllstuff_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select stuffid,Name,DateOfBirth,PhoneNumber,Email,Address,Designation,Salary,joindate,Picture,GenderName from Stuffs s\r\n  inner join Gender g\r\n  ON s.gerderId=g.GenderId\r\n  inner join Designations d\r\n  on s.Designationid=d.DesignatinId", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datagridStuff.DataSource = dt;
            con.Close();
        }
    }
}
