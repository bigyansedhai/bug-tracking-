using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterForm
{
    public partial class BugTrackingSystem : Form
    {
        public BugTrackingSystem()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Text = dateTimePicker1.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRole frm = new ManageRole();
            frm.Show();

     }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUser frm = new ManageUser();
            frm.Show();
        }

        private void manageMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMember frm = new ManageMember();
            frm.Show();
        }

        private void manageProjectMeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManagement frm = new ProjectManagement();
            frm.Show();
        }

        private void registerNewBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectMember frm = new ProjectMember();
            frm.Show();
        }

        private void registerNewSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterBug frm = new RegisterBug();
            frm.Show();
        }

        private void connectToBitBucketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterBugSolution frm = new RegisterBugSolution();
            frm.Show();
        }

        private void connectToBitBuckectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BugHistory frm = new BugHistory();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageRole frm = new ManageRole();
            frm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManageUser frm = new ManageUser();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageMember frm = new ManageMember();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProjectManagement frm = new ProjectManagement();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageMember frm = new ManageMember();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            RegisterBug frm = new RegisterBug();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RegisterBugSolution frm = new RegisterBugSolution();
            frm.Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            BugHistory frm = new BugHistory();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrm frm = new LoginFrm();
            frm.Show();
        }
    }
}
