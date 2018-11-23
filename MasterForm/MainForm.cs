using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccesslayer;
using BussinessLogiclayer;

namespace MasterForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        BussinessLogicClass blc = new BussinessLogicClass();
        MemberClass mcl = new MemberClass();
        ProjectManagementClass pmc = new ProjectManagementClass();
        ProjectMemberClass pm = new ProjectMemberClass();
        RegisterBugClass rbc = new RegisterBugClass();
        RegBugSolutionClass rbs = new RegBugSolutionClass();
       
        public string UserType;
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
            ToolTip t = new ToolTip();

           
            
            //starting using Tooltip (Message Box Show when click these Buttom)
            t.ToolTipTitle = "Manage User Role";
            t.UseFading = true;
            t.UseAnimation = true;
            t.IsBalloon = true;
            t.ShowAlways = true;
            t.AutoPopDelay = 5000;
            t.InitialDelay = 1000;
            t.ReshowDelay = 500;
            t.SetToolTip(btnManageUserRole, "Click Me To Access Manage UserRole Form");

            ToolTip a = new ToolTip();
            a.ToolTipTitle = "Manage User";
            a.UseFading = true;
            a.UseAnimation = true;
            a.IsBalloon = true;
            a.ShowAlways = true;
            a.AutoPopDelay = 5000;
            a.InitialDelay = 1000;
            a.ReshowDelay = 500;
            a.SetToolTip(btnManageUser, "Click Me To Access Manage User Form");

            ToolTip b = new ToolTip();
            b.ToolTipTitle = "Manage Member";
            b.UseFading = true;
            b.UseAnimation = true;
            b.IsBalloon = true;
            b.ShowAlways = true;
            b.AutoPopDelay = 5000;
            b.InitialDelay = 1000;
            t.ReshowDelay = 500;
            b.SetToolTip(btnManageMember, "Click Me To Access Manage Member Form");

            ToolTip c = new ToolTip();
            c.ToolTipTitle = "Manage Project Member";
            c.UseFading = true;
            c.UseAnimation = true;
            c.IsBalloon = true;
            c.ShowAlways = true;
            c.AutoPopDelay = 5000;
            c.InitialDelay = 1000;
            c.ReshowDelay = 500;
            c.SetToolTip(btnProjectMember, "Click Me To Access Manage Project Member Form");

            ToolTip d = new ToolTip();
            d.ToolTipTitle = "Project Management";
            d.UseFading = true;
            d.UseAnimation = true;
            d.IsBalloon = true;
            d.ShowAlways = true;
            d.AutoPopDelay = 5000;
            d.InitialDelay = 1000;
            d.ReshowDelay = 500;
            d.SetToolTip(btnProjectManage, "Click Me To Access Project Management Form");


            ToolTip f = new ToolTip();
            f.ToolTipTitle = "Register New Bug";
            f.UseFading = true;
            f.UseAnimation = true;
            f.IsBalloon = true;
            f.ShowAlways = true;
            f.AutoPopDelay = 5000;
            f.InitialDelay = 1000;
            f.ReshowDelay = 500;
            f.SetToolTip(btnNewbug, "Click Me To Access Register New Bug Form");


            ToolTip n = new ToolTip();
            n.ToolTipTitle = "Manage Member";
            n.UseFading = true;
            n.UseAnimation = true;
            n.IsBalloon = true;
            n.ShowAlways = true;
            n.AutoPopDelay = 5000;
            n.InitialDelay = 1000;
            n.ReshowDelay = 500;
            n.SetToolTip(btnBugSol, "Click Me To Access Register New Bug Form");


            ToolTip o = new ToolTip();
            o.ToolTipTitle = "Bug History";
            o.UseFading = true;
            o.UseAnimation = true;
            o.IsBalloon = true;
            o.ShowAlways = true;
            o.AutoPopDelay = 5000;
            o.InitialDelay = 1000;
            o.ReshowDelay = 500;
            o.SetToolTip(btnBugHis, "Click Me To Access Bug History Form");


            ToolTip p = new ToolTip();
            p.ToolTipTitle = "Clone To GitHub";
            p.UseFading = true;
            p.UseAnimation = true;
            p.IsBalloon = true;
            p.ShowAlways = true;
            p.AutoPopDelay = 5000;
            p.InitialDelay = 1000;
            p.ReshowDelay = 500;
            p.SetToolTip(BtnClone, "Click Me To Access Clone to GitHub Details");


            ToolTip h= new ToolTip();
            h.ToolTipTitle = "Log Out";
            h.UseFading = true;
            h.UseAnimation = true;
            h.IsBalloon = true;
            h.ShowAlways = true;
            h.AutoPopDelay = 5000;
            h.InitialDelay = 1000;
            h.ReshowDelay = 500;
            h.SetToolTip(btnLogOut,"Click Me To Exit The Application");



            try
            {
                
                
                lblTotalProject.Text = pmc.countNumberOfProjects().ToString();
                lbltmem.Text = mcl.totalMember().ToString();
                lblTotalBugResigter.Text = rbc.getAllBugs().Rows.Count.ToString();
                lblTotalFixed.Text = rbs.getAllBugSolutions().Rows.Count.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void manageUserRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRole mr = new ManageRole();
            mr.Show();

            // mr.MdiParent = this;


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
            

           
        }

        private void bugHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RegisterBugSolution rg = new RegisterBugSolution();
            rg.userType = lblUserType.Text;
            rg.Show();


        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Git to Leave C#
            System.Diagnostics.Process.Start("https://github.com/bigyansedhai/bug-tracking-");
        }

    

   


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void cloneToBitBucketToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           
            Application.Exit();
        }

     

       

       

       

      

      

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnManageUserRole_Click(object sender, EventArgs e)
        {
            ManageRole mr = new ManageRole();
            mr.Show();
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            ManageUser mu = new ManageUser();
            mu.Show();
        }

        private void btnManageMember_Click(object sender, EventArgs e)
        {
            ManageMember m = new ManageMember();
            m.Show();
        }

        private void btnProjectMember_Click(object sender, EventArgs e)
        {
            ProjectMember p = new ProjectMember();
            p.Show();
        }

        private void btnProjectManage_Click(object sender, EventArgs e)
        {
            ProjectManagement pm = new ProjectManagement();
            pm.Show();
        }

        private void btnNewbug_Click(object sender, EventArgs e)
        {
            RegisterBug r = new RegisterBug();

            r.UserType = lblUserType.Text;
            r.Show();

            
        }

        private void btnBugSol_Click(object sender, EventArgs e)
        {
            RegisterBugSolution rg = new RegisterBugSolution();
            rg.userType = lblUserType.Text;

            rg.Show();
        }

        private void btnBugHis_Click(object sender, EventArgs e)
        {
            BugHistory bh = new BugHistory();
            bh.Show();
        }

        private void BtnClone_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://github.com/bigyansedhai/bug-tracking-");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginFrm f = new LoginFrm();
            f.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        
        {
            BugHistory bh = new BugHistory();
            bh.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void registerBugSearchToolStripMenuItem1_Click(object sender, EventArgs e)
        {

           
           
        }

       

        private void registerBugViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterBugSearch bs = new RegisterBugSearch();
            bs.ShowDialog();
        }

        private void registerBugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterBug r = new RegisterBug();
            r.UserType = lblUserType.Text;
            r.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bugSolutionViewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            

            System.Diagnostics.Process.Start("file:///D:/The%20British%20college/advance%20software/BugHelp.pdf");
        }

        private void lblUserType_Click(object sender, EventArgs e)
        {
           // lblUserType.DataBindings = 
        }

      

        private void backUpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DatabaseBackupRestore db = new DatabaseBackupRestore();
            db.Show();
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bigyansedhai/bug-tracking-");
        }
    }
}
