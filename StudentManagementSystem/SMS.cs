using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class sms : Form
    {
        public sms()
        {
            InitializeComponent();
        }

        private void menuStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStuffUpdateDelete fud = new frmStuffUpdateDelete();
            fud.Show();
            fud.MdiParent = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void entryNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentEntry fse =new frmStudentEntry();
            fse.Show();
            fse.MdiParent = this;
        }

        private void updateDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmUpdate_Delete fud = new frmUpdate_Delete();
            fud.Show();
            fud.MdiParent = this;
        }

        private void showAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowAllStudents fsas = new FrmShowAllStudents();
            fsas.Show();
            fsas.MdiParent = this;
        }

        private void insertNewTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTeacharsEntry fmt = new frmTeacharsEntry();
            fmt.Show();
            fmt.MdiParent = this;
        }

        private void updateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fud =new Form1();
            fud.Show();
            fud.MdiParent=this;
        }

        private void insertNewStuffInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmStuffEntry fse =new frmStuffEntry();
            fse.Show();
            fse.MdiParent = this;
        }

        private void paymentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void teachartsEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iDWiseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPaymentHistory fph = new frmPaymentHistory();
            fph.Show();
            fph.MdiParent = this;
        }

        private void cashReciveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRecivePayment frp = new frmRecivePayment();
            frp.Show();
            frp.MdiParent = this;
        }

        private void showAllTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowAllTeacher fst = new FrmShowAllTeacher();
            fst.Show();
            fst.MdiParent = this;
        }

        private void showAllStuffsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           frmShowAllStuff fss=new frmShowAllStuff();
            fss.Show();
            fss.MdiParent = this;
        }

        private void entryResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntryResults fer = new frmEntryResults();
            fer.Show();
            fer.MdiParent = this;
        }
    }
}
