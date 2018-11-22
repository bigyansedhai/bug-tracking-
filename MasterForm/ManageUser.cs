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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }
        // fetch class from Other Class
        //fetch BussinessLogic class
        BussinessLogicClass blc = new BussinessLogicClass();    
        public int userId;
        ManageUserClass muc = new ManageUserClass();
        MemberClass mcl = new MemberClass();
        ManageUserRoleClass ur = new ManageUserRoleClass();

        private void ManageUser_Load(object sender, EventArgs e)
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="Lode code  and show all work inside dataGridViews"></param>
           
            dgvManageUser.DataSource = muc.getAllUsers();
          cmbfirstname.DataSource = mcl.getAllMembers();
            cmbfirstname.ValueMember = "memberId";
            cmbfirstname.DisplayMember = "memberName";
            cmbfirstname.SelectedIndex = -1;
            cmbUserRole.DataSource =  ur.getAllUserRoles();
            cmbUserRole.ValueMember = "userRoleId";
            cmbUserRole.DisplayMember = "userRole";
            cmbUserRole.SelectedIndex = -1;
        }

        /// <summary>
        
        /// </summary> create Function
        public void AddManageUser()
        {
            try
            {
                bool result = blc.manageUsers(0, Convert.ToInt32(cmbUserRole.SelectedValue.ToString()), Convert.ToInt32(cmbfirstname.SelectedValue.ToString()), txtusername.Text, txtpassword.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW USER HAS BEEN ADDED");
                    dgvManageUser.DataSource = muc.getAllUsers();
                    Assitantclass.makeFieldsBlank(pnlUserInfo);
                }
                else
                {
                    MessageBox.Show("ERROR ON ADDING NEW USER");
                    dgvManageUser.DataSource = muc.getAllUsers();
                    Assitantclass.makeFieldsBlank(pnlUserInfo);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            /// Starting Validation for form
            try
            {
                if (cmbUserRole.SelectedIndex < 0)
                {
                    MessageBox.Show("Please provide ManageRole");
                    cmbUserRole.Focus();
                }
                else if (cmbfirstname.SelectedIndex < 0)
                {
                    MessageBox.Show("Please fii the Description TextBox");
                    cmbfirstname.Focus();
                }
                else if(txtusername.Text =="")
                {
                    MessageBox.Show("Please Fillup Of the UserNameBox");
                    txtusername.Focus();
                }
                else if(txtpassword.Text=="")
                {
                    MessageBox.Show("please fill the Password Box");
                    txtpassword.Focus();
                }
                else
                {
                    AddManageUser();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvManageUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userId = Convert.ToInt32(dgvManageUser.SelectedRows[0].Cells["Id"].Value.ToString());
                cmbUserRole.Text = dgvManageUser.SelectedRows[0].Cells["Role"].Value.ToString();
                cmbfirstname.Text = dgvManageUser.SelectedRows[0].Cells["Name"].Value.ToString();
                txtusername.Text = dgvManageUser.SelectedRows[0].Cells["Username"].Value.ToString();
                txtpassword.Text = dgvManageUser.SelectedRows[0].Cells["Password"].Value.ToString();
                txtconfirmpassword.Text = dgvManageUser.SelectedRows[0].Cells["Password"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        
        public void UpdateManageUser()
        {
            try
            {
                bool result = blc.manageUsers(userId, Convert.ToInt32(cmbUserRole.SelectedValue.ToString()), Convert.ToInt32(cmbfirstname.SelectedValue.ToString()), txtusername.Text, txtpassword.Text, 2);
                if (result == true)
                {
                    MessageBox.Show("User has been Updated");
                    dgvManageUser.DataSource = muc.getAllUsers();
                    Assitantclass.makeFieldsBlank(pnlUserInfo);
                }
                else
                {
                    MessageBox.Show("Error updated");
                    dgvManageUser.DataSource = muc.getAllUsers();
                    Assitantclass.makeFieldsBlank(pnlUserInfo);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUserRole.SelectedIndex < 0)
                {
                    MessageBox.Show("Please provide ManageRole");
                    cmbUserRole.Focus();
                }
                else if (cmbfirstname.SelectedIndex < 0)
                {
                    MessageBox.Show("Please fii the Description TextBox");
                    cmbfirstname.Focus();
                }
                else if (txtusername.Text == "")
                {
                    MessageBox.Show("Please Fillup Of the UserNameBox");
                    txtusername.Focus();
                }
                else if (txtpassword.Text == "")
                {
                    MessageBox.Show("please fill the Password Box");
                    txtpassword.Focus();
                }
                else
                {
                    UpdateManageUser();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteManageUser()
        {
            try
            {
                bool result = blc.manageUsers(userId, Convert.ToInt32(cmbUserRole.SelectedValue.ToString()), Convert.ToInt32(cmbfirstname.SelectedValue.ToString()), txtusername.Text, txtpassword.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("User has been deleted");
                    dgvManageUser.DataSource = muc.getAllUsers();
                    Assitantclass.makeFieldsBlank(pnlUserInfo);
                }
                else
                {
                    MessageBox.Show("Error");
                    dgvManageUser.DataSource = muc.getAllUsers();
                    Assitantclass.makeFieldsBlank(pnlUserInfo);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUserRole.SelectedIndex < 0)
                {
                    MessageBox.Show("Please provide ManageRole");
                    cmbUserRole.Focus();
                }
                else if (cmbfirstname.SelectedIndex < 0)
                {
                    MessageBox.Show("Please fii the Description TextBox");
                    cmbfirstname.Focus();
                }
                else if (txtusername.Text == "")
                {
                    MessageBox.Show("Please Fillup Of the UserNameBox");
                    txtusername.Focus();
                }
                else if (txtpassword.Text == "")
                {
                    MessageBox.Show("please fill the Password Box");
                    txtpassword.Focus();
                }
                else
                {
                    DeleteManageUser();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}

