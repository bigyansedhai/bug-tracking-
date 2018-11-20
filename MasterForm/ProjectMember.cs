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
    public partial class ProjectMember : Form
    {
        public ProjectMember()
        {
            InitializeComponent();
        }
        ProjectMemberClass pm = new ProjectMemberClass();
        MemberClass mcl = new MemberClass();
        ProjectManagementClass pmc = new ProjectManagementClass();
        ManageUserRoleClass ur = new ManageUserRoleClass();
        BussinessLogicClass blc = new BussinessLogicClass();
        public int projectmemberid;
        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void ProjectMember_Load(object sender, EventArgs e)
        {


            dgvProjectMember.DataSource = pm.getAllMembersInProject();
            cmbMember.DataSource = mcl.getAllMembers();
            cmbMember.ValueMember = "memberId";
            cmbMember.DisplayMember = "memberName";
            cmbMember.SelectedIndex = -1;

            cmbProject.DataSource = pmc.getAllProjects();
            cmbProject.ValueMember = "projectId";
            cmbProject.DisplayMember = "projectName";
            cmbProject.SelectedIndex = -1;

            cmbMemberRole.DataSource = ur.getAllUserRoles();
            cmbMemberRole.ValueMember = "userRoleId";
            cmbMemberRole.DisplayMember = "userRole";
            cmbMemberRole.SelectedIndex = -1;
            dgvProjectMember.DataSource = pm.getAllMembersInProject();
        }

        private void dgvProjectMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                projectmemberid= Convert.ToInt32(dgvProjectMember.SelectedRows[0].Cells["id"].Value.ToString());
                cmbProject.Text = dgvProjectMember.SelectedRows[0].Cells["projectName"].Value.ToString();
                cmbMember.Text = dgvProjectMember.SelectedRows[0].Cells["memberName"].Value.ToString();
                cmbMemberRole.Text = dgvProjectMember.SelectedRows[0].Cells["memberRole"].Value.ToString();
                txtResonse.Text = dgvProjectMember.SelectedRows[0].Cells["memberResponsibilities"].Value.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool result = blc.manageProjectMembers(0, Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbMember.SelectedValue.ToString()), cmbMemberRole.Text, txtResonse.Text, 1);
            if (result == true)
            {
                MessageBox.Show("NEW MEMBER HAS BEEN ADDED TO THE PROJECT");
                dgvProjectMember.DataSource = pm.getAllMembersInProject();
                Assitantclass.makeFieldsBlank(gbAssignMemberForTheProject);
            }
            else
            {
                MessageBox.Show("ERROR IN ADDING MEMBER IN THE PROJECT");
                dgvProjectMember.DataSource = pm.getAllMembersInProject();
                Assitantclass.makeFieldsBlank(gbAssignMemberForTheProject);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            bool result = blc.manageProjectMembers(projectmemberid, Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbMember.SelectedValue.ToString()), cmbMemberRole.Text, txtResonse.Text, 2);
            if (result == true)
            {
                MessageBox.Show("MEMBER INFORMATION IN THE PROJECT HAS BEEN MODIFIED");
                dgvProjectMember.DataSource = pm.getAllMembersInProject();
                Assitantclass.makeFieldsBlank(gbAssignMemberForTheProject);
            }
            else
            {
                MessageBox.Show("ERROR IN MODIFYING MEMBER INFORMATION OF THE PROJECT");
                dgvProjectMember.DataSource = pm.getAllMembersInProject();
               Assitantclass.makeFieldsBlank(gbAssignMemberForTheProject);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool result = blc.manageProjectMembers(projectmemberid, Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbMember.SelectedValue.ToString()), cmbMemberRole.Text, txtResonse.Text, 3);
            if (result == true)
            {
                MessageBox.Show("PROJECT MEMBER HAS BEEN DELETED");
                dgvProjectMember.DataSource = pm.getAllMembersInProject();
               Assitantclass.makeFieldsBlank(gbAssignMemberForTheProject);
            }
            else
            {
                MessageBox.Show("ERROR IN DELETING PROJECT MEMBER FROM THE PROJECT");
                dgvProjectMember.DataSource = pm.getAllMembersInProject();
                Assitantclass.makeFieldsBlank(gbAssignMemberForTheProject);
            }
        }
    }
    }

