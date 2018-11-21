using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLogiclayer;
using DataAccesslayer;

namespace MasterForm
{
    public partial class LoginFrm : Form
    {
        public LoginFrm()
        {
            InitializeComponent();
        }
        BussinessLogicClass blc = new BussinessLogicClass();
        ManageUserClass mcl = new ManageUserClass();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            try
            {
                DataTable result = mcl.userType(txtUserName.Text, txtPassword.Text);
                String Role = result.Rows[0]["userRole"].ToString();

                if (Role == "Project Manager")
                {
                    MainForm b = new MainForm();
                    this.Hide();
                    b.Show();
                }
                if (Role == "Developer")
                {

                    MainForm b = new MainForm();
                    this.Hide();
                    
                    //b.bo.Enabled = false;
                    //b.btnManageUserRole.Enabled = false;
                    //b.btnManageProject.Enabled = false;
                    //b.btnManageMemberInProject.Enabled = false;
                    //b.Show();
                }
                if (Role =="Tester")
                {
                    MainForm b = new MainForm();
                    this.Hide();
                    //dashboad.btnManageUser.Enabled = false;
                    //dashboad.btnManageMember.Enabled = false;
                    //dashboad.btnManageUserRole.Enabled = false;
                    //dashboad.btnCloneToBitbucket.Enabled = false;
                    //dashboad.btnRegisterBugSolution.Enabled = false;
                    //dashboad.btnManageProject.Enabled = false;
                    //dashboad.btnManageMemberInProject.Enabled = false;

                    b.Show();
                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Invalid User Name or Password");
            }
        }
    }
}
