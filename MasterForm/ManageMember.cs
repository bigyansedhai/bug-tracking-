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
using System.IO;

namespace MasterForm
{
    public partial class ManageMember : Form
    {
        public ManageMember()
        {
            InitializeComponent();

        }

        MemberClass mcl = new MemberClass();
        public int memberId;
        BussinessLogicClass blc = new BussinessLogicClass();

        private void dgvManageMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            memberId = Convert.ToInt32(dgvManageMember.SelectedRows[0].Cells["memberId"].Value.ToString());
            txtMemberName.Text = dgvManageMember.SelectedRows[0].Cells["memberName"].Value.ToString();
            txtMemberAddress.Text = dgvManageMember.SelectedRows[0].Cells["memberAddress"].Value.ToString();
            txtConatctNumber.Text = dgvManageMember.SelectedRows[0].Cells["contactNumber"].Value.ToString();
            txtEmailAddress.Text = dgvManageMember.SelectedRows[0].Cells["emailAddress"].Value.ToString();
            cmbGender.Text = dgvManageMember.SelectedRows[0].Cells["gender"].Value.ToString();
            dtpDateOfBirth.Text = dgvManageMember.SelectedRows[0].Cells["dateOfBirth"].Value.ToString();
            dtpDateOfJoin.Text = dgvManageMember.SelectedRows[0].Cells["dateOfJoin"].Value.ToString();
            txtDesignation.Text = dgvManageMember.SelectedRows[0].Cells["memberDesignation"].Value.ToString();
            MemoryStream memoryStream = new MemoryStream((byte[])dgvManageMember.SelectedRows[0].Cells["profilePicture"].Value);
            pbProfilePicture.Image = Image.FromStream(memoryStream);
        }

        private void ManageMember_Load(object sender, EventArgs e)
        {
            dgvManageMember.DataSource = mcl.getAllMembers();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    OpenFileDialog ofd = new OpenFileDialog();
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pbProfilePicture.Image = Image.FromFile(ofd.FileName);

                    }
                    else
                    {
                        MessageBox.Show("Please select a profile picture");
                    }

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void AddManageMember()
        {
            try
            {
                bool result = blc.ManageMembers(0, txtMemberName.Text, txtMemberAddress.Text, txtConatctNumber.Text, txtEmailAddress.Text, cmbGender.Text, Convert.ToDateTime(dtpDateOfBirth.Text), Convert.ToDateTime(dtpDateOfJoin.Text), txtDesignation.Text, Assitantclass.imageConverter(pbProfilePicture), 1);
                if (result == true)
                {
                    MessageBox.Show("NEW MEMBER HAS SUCCESSFULLY CREATED");
                    dgvManageMember.DataSource = mcl.getAllMembers();
                    Assitantclass.makeFieldsBlank(pnlMemberInformation);
                    pbProfilePicture.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN CREATING MEMBER");
                    dgvManageMember.DataSource = mcl.getAllMembers();
                    Assitantclass.makeFieldsBlank(pnlMemberInformation);
                    pbProfilePicture.Image = null;
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
                if (txtMemberName.Text== "")
                {
                    MessageBox.Show("Please provide Member Name");
                    txtMemberName.Focus();
                }
                else if (txtMemberAddress.Text=="")
                {
                    MessageBox.Show("Please Provide Member Address");
                    txtMemberAddress.Focus();
                }
                else if (txtConatctNumber.Text=="")
                {
                    MessageBox.Show("Please Provide Contact Number");
                    txtConatctNumber.Focus();
                }
                else if (txtEmailAddress.Text == "")
                {
                    MessageBox.Show("please Provide EmailAddress");
                    txtEmailAddress.Focus();
                }
                else if(cmbGender.SelectedIndex < 0)
                {
                    MessageBox.Show("Please provide Gender");
                    cmbGender.Focus();
                }
                else if(pbProfilePicture.Image==null)
                {
                    MessageBox.Show("Please Select The Picture from Gallary");
                    pbProfilePicture.Focus();
                }
                else
                {
                    AddManageMember();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void pbProfilePicture_Click(object sender, EventArgs e)
        {

        }
        public void UpdateManageMenber()
        {
            try
            {
                bool result = blc.ManageMembers(memberId, txtMemberName.Text, txtMemberAddress.Text, txtConatctNumber.Text, txtEmailAddress.Text, cmbGender.Text, Convert.ToDateTime(dtpDateOfBirth.Text), Convert.ToDateTime(dtpDateOfJoin.Text), txtDesignation.Text, Assitantclass.imageConverter(pbProfilePicture), 2);
                if (result == true)
                {
                    MessageBox.Show("Member Has Successfully Updated");
                    dgvManageMember.DataSource = mcl.getAllMembers();
                    Assitantclass.makeFieldsBlank(pnlMemberInformation);
                    pbProfilePicture.Image = null;
                }
                else
                {
                    MessageBox.Show("Error updated Member");
                    dgvManageMember.DataSource = mcl.getAllMembers();
                    Assitantclass.makeFieldsBlank(pnlMemberInformation);
                    pbProfilePicture.Image = null;
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
                if (txtMemberName.Text == "")
                {
                    MessageBox.Show("Please provide Member Name");
                    txtMemberName.Focus();
                }
                else if (txtMemberAddress.Text == "")
                {
                    MessageBox.Show("Please Provide Member Address");
                    txtMemberAddress.Focus();
                }
                else if (txtConatctNumber.Text == "")
                {
                    MessageBox.Show("Please Provide Contact Number");
                    txtConatctNumber.Focus();
                }
                else if (txtEmailAddress.Text == "")
                {
                    MessageBox.Show("please Provide EmailAddress");
                    txtEmailAddress.Focus();
                }
                else if (cmbGender.SelectedIndex < 0)
                {
                    MessageBox.Show("Please provide Gender");
                    cmbGender.Focus();
                }
                else if (pbProfilePicture.Image == null)
                {
                    MessageBox.Show("Please Select The Picture from Gallary");
                    pbProfilePicture.Focus();
                }
                else
                {
                    UpdateManageMenber();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteManageMember()
        {
            try
            {
                bool result = blc.ManageMembers(memberId, txtMemberName.Text, txtMemberAddress.Text, txtConatctNumber.Text, txtEmailAddress.Text, cmbGender.Text, Convert.ToDateTime(dtpDateOfBirth.Text), Convert.ToDateTime(dtpDateOfJoin.Text), txtDesignation.Text, Assitantclass.imageConverter(pbProfilePicture), 3);
                if (result == true)
                {
                    MessageBox.Show("Member successfully deleted");
                    dgvManageMember.DataSource = mcl.getAllMembers();
                    Assitantclass.makeFieldsBlank(pnlMemberInformation);
                    pbProfilePicture.Image = null;
                }
                else
                {
                    MessageBox.Show("Error");
                    dgvManageMember.DataSource = mcl.getAllMembers();
                    Assitantclass.makeFieldsBlank(pnlMemberInformation);
                    pbProfilePicture.Image = null;
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
                if (txtMemberName.Text == "")
                {
                    MessageBox.Show("Please provide Member Name");
                    txtMemberName.Focus();
                }
                else if (txtMemberAddress.Text == "")
                {
                    MessageBox.Show("Please Provide Member Address");
                    txtMemberAddress.Focus();
                }
                else if (txtConatctNumber.Text == "")
                {
                    MessageBox.Show("Please Provide Contact Number");
                    txtConatctNumber.Focus();
                }
                else if (txtEmailAddress.Text == "")
                {
                    MessageBox.Show("please Provide EmailAddress");
                    txtEmailAddress.Focus();
                }
                else if (cmbGender.SelectedIndex < 0)
                {
                    MessageBox.Show("Please provide Gender");
                    cmbGender.Focus();
                }
                else if (pbProfilePicture.Image == null)
                {
                    MessageBox.Show("Please Select The Picture from Gallary");
                    pbProfilePicture.Focus();
                }
                else
                {
                    DeleteManageMember();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
    }

