using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class frmRecivePayment : Form
    {
        SqlConnection con = new SqlConnection("server=DESKTOP-KU43MHN;Database=StudentInfo;Trusted_connection=true");
        public frmRecivePayment()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select s.StudentId,s.Name, paymentid,MustPay,MonthlyFee,ExamFee,Others,TotalRecive,Date,Dou,Comment from PaymentRecive pr\r\ninner join student s\r\non pr.StudetnId=s.StudentId where s.classID="+cmdClass.SelectedValue+" and s.StudentId="+txtsearch.Text+"", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datagridupdate.DataSource = dt;
            con.Close();
        }
        private void LoadClass()
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select *from class",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmdClass.DataSource = dt;
            cmdClass.ValueMember = "Classid";
            cmdClass.DisplayMember = "ClassName";
            cmdClass2.DataSource= dt;
            cmdClass2.ValueMember = "Classid";
            cmdClass2.DisplayMember = "ClassName";
            con.Close();
        }

        private void frmRecivePayment_Load(object sender, EventArgs e)
        {
            LoadClass();
            loadpaymentFrom();



        }

        private void Datagridupdate2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
        private void loadpaymentFrom()
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int i =0;i<Datagridupdate2.Rows.Count;i++)
            {
               

                if (Datagridupdate2.Rows[i].Cells["txtmustfee"].Value ==null && 
                    Datagridupdate2.Rows[i].Cells["Monthlyfee"].Value==null && 
                    Datagridupdate2.Rows[i].Cells["txtother"].Value==null &&
                    Datagridupdate2.Rows[i].Cells["txtComment"].Value == null&& 
                    Datagridupdate2.Rows[i].Cells["txtexamfee"].Value == null&&
                    string.IsNullOrEmpty(txtserch2.Text))
                {
                    MessageBox.Show("Plese Enter All Data " );
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = ("insert into PaymentRecive(StudetnId,PaymentId,Mustpay,MonthlyFee,Examfee,Others,Comment,ClassId) values (@id,newid(),@mustpay,@monthly,@examfee,@others,@classid,@comment");

                    cmd.Parameters.AddWithValue("@id", txtserch2.Text);
                    cmd.Parameters.AddWithValue("@mustpay", Datagridupdate2.Rows[i].Cells["txtmustfee"].Value);
                    cmd.Parameters.AddWithValue("@monthly", Datagridupdate2.Rows[i].Cells["Monthlyfee"].Value);
                    cmd.Parameters.AddWithValue("@examfee", Datagridupdate2.Rows[i].Cells["txtexamfee"].Value);
                    cmd.Parameters.AddWithValue("@others", Datagridupdate2.Rows[i].Cells["txtother"].Value);
                    cmd.Parameters.AddWithValue("@classid", cmdClass2.SelectedValue);
                    cmd.Parameters.AddWithValue("@comment", Datagridupdate2.Rows[i].Cells["txtComment"].Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data inserted Succesfully");
                    con.Close();

                   
                }
            }
            
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select *from PaymentRecive where ClassId ="+cmdClass2.SelectedValue+"",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            datagridupdate.DataSource = dt;
            con.Close();
        }
    }
}
