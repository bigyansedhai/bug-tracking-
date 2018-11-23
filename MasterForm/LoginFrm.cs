using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccesslayer;

namespace MasterForm
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        ManageUserClass muc = new ManageUserClass();
        ManageUserRoleClass m = new ManageUserRoleClass();
        RegisterBugClass rbc = new RegisterBugClass();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void btnConnect_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("https://github.com/bigyansedhai/bug-tracking-");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable result = muc.userType(Convert.ToInt32(cmbUserRole.SelectedValue.ToString()),txtUserName.Text, txtPassword.Text);

                String Role = result.Rows[0]["userRole"].ToString();
              if (Role == "Project  Manager")
                {
                    MainForm dashboad = new MainForm();
                    this.Hide();
                    MessageBox.Show(ForeColor.IsNamedColor.ToString() + " Login Successfully WELCOME TO BUG TRACKING SYSTEM");
                    dashboad.lblUserType.Text = cmbUserRole.Text;
                    dashboad.UserType = cmbUserRole.Text;
                    dashboad.lbluser.Text = "Username: " + txtUserName.Text;
                    dashboad.Show();
                }

               else if (Role == "Admin")
                {
                    MainForm dashboad = new MainForm();
                    this.Hide();

                    MessageBox.Show(ForeColor.IsNamedColor.ToString() + " Login Successfully WELCOME TO BUG TRACKING SYSTEM");
                    dashboad.lblUserType.Text = cmbUserRole.Text;
                    dashboad.UserType = cmbUserRole.Text;
                    dashboad.lbluser.Text = "Username: " + txtUserName.Text;
                    dashboad.Show();
                }

                else if (Role == "Tester")

                {
                    MainForm dashboad = new MainForm();
                    this.Hide();

                    MessageBox.Show(ForeColor.IsNamedColor.ToString() + " Login Successfully WELCOME TO BUG TRACKING SYSTEM");
                    dashboad.lblUserType.Text = cmbUserRole.Text;
                    dashboad.UserType = cmbUserRole.Text;
                    dashboad.lbluser.Text = "Username: " + txtUserName.Text;
                    dashboad.btnManageUser.Enabled = false;
                    dashboad.btnManageMember.Enabled = false;
                    dashboad.btnManageUserRole.Enabled = false;
                    dashboad.BtnClone.Enabled = false;
                    dashboad.btnProjectManage.Enabled = false;
                    dashboad.btnProjectMember.Enabled = false;
                


                    dashboad.manageUserToolStripMenuItem.Enabled = false;
                    dashboad.manageMemberToolStripMenuItem.Enabled = false;
                    dashboad.manageUserRoleToolStripMenuItem.Enabled = false;
                    dashboad.manageProjectToolStripMenuItem.Enabled = false;
                    dashboad.ProjectManagementToolStripMenuItem.Enabled = false;
                 
                    
                   
                    dashboad.Show();

                }
               else if (Role == "Developer")
                {

                    MainForm dashboad = new MainForm();
                    this.Hide();

                    MessageBox.Show(ForeColor.IsNamedColor.ToString() + " Login Successfully WELCOME TO BUG TRACKING SYSTEM");
                    dashboad.btnManageUser.Enabled = false;
                    dashboad.btnManageMember.Enabled = false;
                    dashboad.btnManageUserRole.Enabled = false;
                    dashboad.btnProjectManage.Enabled = false;
                    dashboad.btnProjectMember.Enabled = false;
                    dashboad.manageUserToolStripMenuItem.Enabled = false;
                    dashboad.manageMemberToolStripMenuItem.Enabled = false;
                    dashboad.manageUserRoleToolStripMenuItem.Enabled = false;
                    dashboad.manageProjectToolStripMenuItem.Enabled = false;
                    dashboad.ProjectManagementToolStripMenuItem.Enabled = false;
                    dashboad.lblUserType.Text = cmbUserRole.Text;
                    dashboad.UserType = cmbUserRole.Text;
                    dashboad.lbluser.Text = "Username: " + txtUserName.Text;
                    dashboad.Show();


                }
                else
                {
                   MessageBox.Show("Invalid User Type");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid User Name or Password");
            }
        }
    
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                txtPassword.UseSystemPasswordChar = false;

            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            //cmbUserRole.DataSource = m.getAllUserRoles();
            cmbUserRole.DataSource = m.getRoleUser();
            cmbUserRole.ValueMember = "userRoleId";
            cmbUserRole.DisplayMember = "userRole";
            cmbUserRole.SelectedIndex = -1;
        }
    }
}
