using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentManagementSystem
{
    public partial class frmPaymentHistory : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-KU43MHN;Database=StudentInfo;Trusted_connection=true");
        
        public frmPaymentHistory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select s.StudentId, s.Name, paymentid, MustPay, MonthlyFee, ExamFee, Others, TotalRecive, Date, Dou, Comment from PaymentRecive pr\r\ninner join student s\r\non pr.StudetnId = s.StudentId where s.classID = "+cmdClass.SelectedValue+" and s.StudentId = "+txtsearch.Text+"", con);
            DataTable dt= new DataTable();
            sda.Fill(dt);
            datagridupdate.DataSource = dt;
            con.Close();
        }
        private void frmPaymentHistory_Load(object sender, EventArgs e)
        {
            loadClass();

        }
        private void loadClass()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select *from class",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmdClass.DataSource = dt;
            cmdClass.ValueMember = "Classid";
            cmdClass.DisplayMember = "ClassName";
            con.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
