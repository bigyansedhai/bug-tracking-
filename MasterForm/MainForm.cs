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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString();
        }

        private void manageUserRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRole mr = new ManageRole();
            mr.Show();
        }

        private void manageUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Show();
        }

        private void manageMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageMember m = new ManageMember();
            m.Show();
        }

        private void manageProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectMember p = new ProjectMember();
            p.Show();

           
        }

        private void registerNewBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManagement pm = new ProjectManagement();
            pm.Show();

            
        }
        
        private void registerBugSolutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterBug r = new RegisterBug();
            r.Show();

           
        }

        private void bugHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterBugSolution rg = new RegisterBugSolution();
            rg.Show();


        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManageRole mr = new ManageRole();
            mr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageMember m = new ManageMember();
            m.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cloneToBitBucketToolStripMenuItem_Click(object sender, EventArgs e)
        {

            BugHistory bh = new BugHistory();
            bh.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrm f = new LoginFrm();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProjectMember p = new ProjectMember();
            p.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProjectManagement pm = new ProjectManagement();
            pm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RegisterBug r = new RegisterBug();
            r.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RegisterBugSolution rg = new RegisterBugSolution();
            rg.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BugHistory bh = new BugHistory();
            bh.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrm f = new LoginFrm();
            f.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
