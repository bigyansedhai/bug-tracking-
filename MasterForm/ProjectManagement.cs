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
    public partial class ProjectManagement : Form
    {
        public ProjectManagement()
        {
            InitializeComponent();
        }

        // project management form add update delete using fuction
        //retive data from bussinesslogicclass and data access layer
        ProjectManagementClass pmc = new ProjectManagementClass();
        BussinessLogicClass blc = new BussinessLogicClass();
        public int projectId;
        private void dgvProjectManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            projectId = Convert.ToInt32(dgvProjectManagement.SelectedRows[0].Cells["projectId"].Value.ToString());
            txtProjectName.Text = dgvProjectManagement.SelectedRows[0].Cells["projectName"].Value.ToString();
            dtpStartDate.Text = dgvProjectManagement.SelectedRows[0].Cells["projectStartDate"].Value.ToString();
            dtpEndDate.Text = dgvProjectManagement.SelectedRows[0].Cells["projectEndDate"].Value.ToString();
            txtProjectDescription.Text = dgvProjectManagement.SelectedRows[0].Cells["projectDescription"].Value.ToString();
        }

        private void ProjectManagement_Load(object sender, EventArgs e)
        {

            dgvProjectManagement.DataSource = pmc.getAllProjects();
        }

        public void addProject()
        {
            try
            {
                bool result = blc.manageProjects(0, txtProjectName.Text, Convert.ToDateTime(dtpStartDate.Text), Convert.ToDateTime(dtpEndDate.Text), txtProjectDescription.Text, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW PROJECT HAS BEEN SUCCESSFULLY ADDED");
                    dgvProjectManagement.DataSource = pmc.getAllProjects();
                    Assitantclass.makeFieldsBlank(pnlManageProject);
                }
                else
                {
                    MessageBox.Show("ERROR ON ADDING NEW PROJECT");
                    dgvProjectManagement.DataSource = pmc.getAllProjects();
                    Assitantclass.makeFieldsBlank(pnlManageProject);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtProjectName.Text == "")
                {
                    MessageBox.Show("Please Provide Project Name");
                    txtProjectName.Focus();
                }
                else if (txtProjectDescription.Text == "")
                {
                    MessageBox.Show("Please Provide Description for " + txtProjectName.Text);
                    txtProjectDescription.Focus();
                }
                else if (dtpStartDate.Text == dtpEndDate.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure the project will complete in a single day", "Consider the Project Interval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        dtpEndDate.Focus();
                    }
                    else
                    {
                        addProject();
                    }
                }
                else
                {
                    addProject();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void updateProject()
        {
            try
            {
                bool result = blc.manageProjects(projectId, txtProjectName.Text, Convert.ToDateTime(dtpStartDate.Text), Convert.ToDateTime(dtpEndDate.Text), txtProjectDescription.Text, 2);
                if (result == true)
                {
                    MessageBox.Show("PROJECT INFORMATION HAS BEEN SUCCESSFULLY UPDATED");
                    dgvProjectManagement.DataSource = pmc.getAllProjects();
                    Assitantclass.makeFieldsBlank(pnlManageProject);
                }
                else
                {
                    MessageBox.Show("ERROR ON UPDATING PROJECT INFORMATION");
                    dgvProjectManagement.DataSource = pmc.getAllProjects();
                    Assitantclass.makeFieldsBlank(pnlManageProject);
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
                if (txtProjectName.Text == "")
                {
                    MessageBox.Show("Please Provide Project Name");
                    txtProjectName.Focus();
                }
                else if (txtProjectDescription.Text == "")
                {
                    MessageBox.Show("Please Provide Description for " + txtProjectName.Text);
                    txtProjectDescription.Focus();
                }
                else if (dtpStartDate.Text == dtpEndDate.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure the project will complete in a single day", "Consider the Project Interval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        dtpEndDate.Focus();
                    }
                    else
                    {
                        updateProject();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update Project Information", "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        updateProject();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void deleteProject()
        {
            try
            {
                bool result = blc.manageProjects(projectId, txtProjectName.Text, Convert.ToDateTime(dtpStartDate.Text), Convert.ToDateTime(dtpEndDate.Text), txtProjectDescription.Text, 3);
                if (result == true)
                {
                    MessageBox.Show("PROJECT INFORMATION HAS BEEN SUCCESSFULLY DELETED");
                    dgvProjectManagement.DataSource = pmc.getAllProjects();
                    Assitantclass.makeFieldsBlank(pnlManageProject);
                }
                else
                {
                    MessageBox.Show("ERROR ON DELETING PROJECT INFORMATION");
                    dgvProjectManagement.DataSource = pmc.getAllProjects();
                    Assitantclass.makeFieldsBlank(pnlManageProject);
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
                if (txtProjectName.Text == "")
                {
                    MessageBox.Show("Please Provide Project Name");
                    txtProjectName.Focus();
                }
                else if (txtProjectDescription.Text == "")
                {
                    MessageBox.Show("Please Provide Description for " + txtProjectName.Text);
                    txtProjectDescription.Focus();
                }
                else if (dtpStartDate.Text == dtpEndDate.Text)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure the project will complete in a single day", "Consider the Project Interval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        dtpEndDate.Focus();
                    }
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Project Information", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        deleteProject();
                    }
                    else
                    {
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
