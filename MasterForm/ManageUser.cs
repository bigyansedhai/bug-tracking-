﻿using System;
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

        BussinessLogicClass blc = new BussinessLogicClass();
        public int userId;
        ManageUserClass muc = new ManageUserClass();
        MemberClass mcl = new MemberClass();
        ManageUserRoleClass ur = new ManageUserRoleClass();
        private void ManageUser_Load(object sender, EventArgs e)
        {
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

        private void btnAdd_Click(object sender, EventArgs e)
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

        private void dgvManageUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userId = Convert.ToInt32(dgvManageUser.SelectedRows[0].Cells["Id"].Value.ToString());
                cmbUserRole.Text = dgvManageUser.SelectedRows[0].Cells["Role"].Value.ToString();
                cmbfirstname.Text = dgvManageUser.SelectedRows[0].Cells["Name"].Value.ToString();
                txtusername.Text = dgvManageUser.SelectedRows[0].Cells["Username"].Value.ToString();
                txtusername.Text = dgvManageUser.SelectedRows[0].Cells["Password"].Value.ToString();
                txtconfirmpassword.Text = dgvManageUser.SelectedRows[0].Cells["Password"].Value.ToString();
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

        private void btnDelete_Click(object sender, EventArgs e)
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
    }
}
