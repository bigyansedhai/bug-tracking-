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
    public partial class ManageRole : Form
    {
        public ManageRole()
        {
            InitializeComponent();
        }
        BussinessLogicClass blc = new BussinessLogicClass();
        public int id;
        ManageUserRoleClass m = new ManageUserRoleClass();
        

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void AddManageRole()
        {
            try
            {
                bool result = blc.ManageRole(0, txtUserRole.Text, txtDescription.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW USER ROLE HAS BEEN ADDED");
                    dgvManageRole.DataSource = m.getAllUserRoles();
                    Assitantclass.makeFieldsBlank(pnlManageUserRole);
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING USER ROLE");
                    dgvManageRole.DataSource = m.getAllUserRoles();
                    Assitantclass.makeFieldsBlank(pnlManageUserRole);
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
                if (txtUserRole.Text == "")
                {
                    MessageBox.Show("Please provide ManageRole");
                    txtUserRole.Focus();
                }
                else if (txtDescription.Text=="")
                {
                    MessageBox.Show("Please fii the Description TextBox");
                    txtDescription.Focus();
                }
                else
                {
                    AddManageRole();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public void UpdateManageRole()
        {
            try
            {
                bool result = blc.ManageRole(id, txtUserRole.Text, txtDescription.Text, 2);
                if (result == true)
                {
                    MessageBox.Show("NEW USER ROLE HAS BEEN updated");
                    dgvManageRole.DataSource = m.getAllUserRoles();
                    Assitantclass.makeFieldsBlank(pnlManageUserRole);

                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING USER ROLE");
                    dgvManageRole.DataSource = m.getAllUserRoles();
                    Assitantclass.makeFieldsBlank(pnlManageUserRole);
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
                if (txtUserRole.Text == "")
                {
                    MessageBox.Show("Please fill the ManageRole");
                    txtUserRole.Focus();
                }
                else if (txtDescription.Text == "")
                {
                    MessageBox.Show("Please fii the Description TextBox");
                    txtDescription.Focus();
                }
                else
                {
                    UpdateManageRole();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvManageRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgvManageRole.SelectedRows[0].Cells["userRoleId"].Value.ToString());
            txtUserRole.Text = dgvManageRole.SelectedRows[0].Cells["userRole"].Value.ToString();
            txtDescription.Text = dgvManageRole.SelectedRows[0].Cells["roleDescription"].Value.ToString();
        }

        private void ManageRole_Load(object sender, EventArgs e)
        {
            dgvManageRole.DataSource = m.getAllUserRoles();
        }

        public void DeleteManageRole()
        {
            try
            {
                bool result = blc.ManageRole(id, txtUserRole.Text, txtDescription.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("user Successfully deleted");
                    dgvManageRole.DataSource = m.getAllUserRoles();
                    Assitantclass.makeFieldsBlank(pnlManageUserRole);
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING USER ROLE");
                    dgvManageRole.DataSource = m.getAllUserRoles();
                    Assitantclass.makeFieldsBlank(pnlManageUserRole);
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
                if(txtUserRole.Text=="")
                {
                    MessageBox.Show("Please fill the ManageRole BOX");
                    txtUserRole.Focus();
                }
                else if(txtDescription.Text=="")
                {
                    MessageBox.Show("Plese fill the DescriptionBox ");
                    txtDescription.Focus();
                }
                else
                {
                    DeleteManageRole();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
