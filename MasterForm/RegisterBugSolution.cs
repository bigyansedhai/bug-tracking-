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
using System.IO;
using System.Data.SqlClient;
using DataAccesslayer;
using WinFormsSyntaxHighlighter;
using System.Text.RegularExpressions;

namespace MasterForm
{
    public partial class RegisterBugSolution : Form
    {
        public RegisterBugSolution()
        {
            InitializeComponent();
            var syntaxHighlighter = new SyntaxHighlighter(txtCode);

            syntaxHighlighter.AddPattern(new PatternDefinition(new Regex(@"/\*(.|[\r\n])*?\*/", RegexOptions.Multiline | RegexOptions.Compiled)), new SyntaxStyle(Color.DarkSeaGreen, false, true));

            syntaxHighlighter.AddPattern(new PatternDefinition(new Regex(@"//.*?$", RegexOptions.Multiline | RegexOptions.Compiled)), new SyntaxStyle(Color.Green, false, true));

            syntaxHighlighter.AddPattern(new PatternDefinition(@"\d+\.\d+|\d+"), new SyntaxStyle(Color.Purple));

            syntaxHighlighter.AddPattern(new PatternDefinition(@"\""([^""]|\""\"")+\"""), new SyntaxStyle(Color.Red));

            syntaxHighlighter.AddPattern(new PatternDefinition(@"\'([^']|\'\')+\'"), new SyntaxStyle(Color.Salmon));

            syntaxHighlighter.AddPattern(new PatternDefinition("for", "foreach", "int", "var"), new SyntaxStyle(Color.Blue));

            syntaxHighlighter.AddPattern(new CaseInsensitivePatternDefinition("public", "partial", "class", "void"), new SyntaxStyle(Color.Navy, true, false));

            syntaxHighlighter.AddPattern(new PatternDefinition("+", "-", ">", "<", "&", "|"), new SyntaxStyle(Color.Brown));

        }
        BussinessLogicClass blc = new BussinessLogicClass();
        RegisterBugClass rbc = new RegisterBugClass();
        ProjectManagementClass pmc = new ProjectManagementClass();
        RegBugSolutionClass rbs = new RegBugSolutionClass();
        MemberClass mcl = new MemberClass();
        int Id;
        public string userType;
        private void dgvRegBugSolution_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Id= Convert.ToInt32(dgvRegBugSolution.SelectedRows[0].Cells["bugSolutionId"].Value.ToString());
                cmbProject.Text = dgvRegBugSolution.SelectedRows[0].Cells["projectName"].Value.ToString();
                cmbBugDetails.Text = dgvRegBugSolution.SelectedRows[0].Cells["bugDetails"].Value.ToString();
                cmbBugSolvedBy.Text= dgvRegBugSolution.SelectedRows[0].Cells["memberName"].Value.ToString();
                txtSolutionDetails.Text = dgvRegBugSolution.SelectedRows[0].Cells["solutionDetails"].Value.ToString();
                dtpDate.Text = dgvRegBugSolution.SelectedRows[0].Cells["dateOfSolutionIdentified"].Value.ToString();
                
                txtCode.Rtf = dgvRegBugSolution.SelectedRows[0].Cells["codeAfterFixingBug"].Value.ToString();






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
                if (dtpDate.Text == "")
                {
                    MessageBox.Show("Please provide Bug Solution");
                    dtpDate.Focus();
                }
                else if (cmbProject.SelectedIndex < 0)
                {
                    MessageBox.Show("Please choose Project");
                    cmbProject.Focus();
                }
                else if (cmbBugDetails.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select the Bug");
                    cmbBugDetails.Focus();
                }
                else if (txtSolutionDetails.Text == "")
                {
                    MessageBox.Show("Please provide the bug solution");
                    txtSolutionDetails.Focus();
                }
                else if (txtCode.Rtf == "")
                {
                    MessageBox.Show("Please method the block which was modified after solving bug");
                    txtCode.Focus();
                }
                else
                {
                    AddBugSolution();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                
            }

        }

        private void RegisterBugSolution_Load(object sender, EventArgs e)
        {
            if (userType == "Tester")
            {
                btnUpdate.Enabled = false;
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;
            }
            else if(userType=="Developer")
                {
                btnDelete.Enabled = false;
            }

            dgvRegBugSolution.DataSource = rbs.getAllBugSolutions();
                cmbProject.DataSource = pmc.getAllProjects();
                cmbProject.ValueMember = "projectId";
                cmbProject.DisplayMember = "projectName";
                cmbProject.SelectedIndex = -1;

                cmbBugDetails.DataSource = rbc.getAllBugsforcombobox();
                cmbBugDetails.ValueMember = "bugId";
                cmbBugDetails.DisplayMember = "bugDetails";
                cmbBugDetails.SelectedIndex = -1;

                cmbBugSolvedBy.DataSource = mcl.getAllMembers();
                cmbBugSolvedBy.ValueMember = "memberId";
                cmbBugSolvedBy.DisplayMember = "memberName";
                cmbBugSolvedBy.SelectedIndex = -1;
            
            
        }

        private void cmbProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbBugDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbBugDetails.SelectedIndex == -1)
                {
                    pbPictureIcon.Image = null;
                }
                else
                {

                    SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Select pbPictureImage from BugEntryTable where bugId=@bugId", conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    cmd.Parameters.AddWithValue("@bugId", cmbBugDetails.SelectedValue);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "BugEntryTable");
                    int c = ds.Tables["BugEntryTable"].Rows.Count;
                    if (c > 0)
                    {
                        Byte[] byteBLOData = new Byte[0];
                        byteBLOData = (Byte[])(ds.Tables["BugEntryTable"].Rows[c - 1]["pbPictureImage"]);
                        MemoryStream memoryStream = new MemoryStream(byteBLOData);
                        pbPictureIcon.Image = Image.FromStream(memoryStream);

                    }
                    conn.Close();
                }
                   
            }
            catch (Exception)// exception should be igonered 
            {

                
            }
            



           
        }
        public void AddBugSolution()
        {

            try
            {
                bool result = blc.manageBugSolutions(0, Convert.ToDateTime(dtpDate.Text), Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbBugDetails.SelectedValue.ToString()), Convert.ToInt32(cmbBugSolvedBy.SelectedValue.ToString()), txtSolutionDetails.Text, txtCode.Rtf, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW BUG SOLUTION HAS BEEN REGISTERED");
                    Assitantclass.makeFieldsBlank(gbRegisterBugSolution);
                    dgvRegBugSolution.DataSource = rbs.getAllBugSolutions();
                    dtpDate.Focus();
                }
                else
                {

                    MessageBox.Show("ERROR IN REGISTERING BUG SOLUTION");
                    dgvRegBugSolution.DataSource = rbs.getAllBugSolutions();
                    Assitantclass.makeFieldsBlank(gbRegisterBugSolution);
                    dtpDate.Focus();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateBugSolution()
        {

            try
            {
                bool result = blc.manageBugSolutions(Id, Convert.ToDateTime(dtpDate.Text), Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbBugDetails.SelectedValue.ToString()), Convert.ToInt32(cmbBugSolvedBy.SelectedValue.ToString()), txtSolutionDetails.Text, txtCode.Rtf, 2);
                if (result == true)
                {
                    MessageBox.Show("BUG SOLUTION HAS BEEN MODIFIED");
                    Assitantclass.makeFieldsBlank(gbRegisterBugSolution);
                    dtpDate.Focus();
                }
                else
                {

                    MessageBox.Show("ERROR IN MODIFYING BUG SOLUTION");
                    Assitantclass.makeFieldsBlank(gbRegisterBugSolution);
                    dtpDate.Focus();
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
                if (dtpDate.Text == "")
                {
                    MessageBox.Show("Please provide Bug Solution");
                    dtpDate.Focus();
                }
                else if (cmbProject.SelectedIndex < 0)
                {
                    MessageBox.Show("Please choose Project");
                    cmbProject.Focus();
                }
                else if (cmbBugDetails.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select the Bug");
                    cmbBugDetails.Focus();
                }
                else if (txtSolutionDetails.Text == "")
                {
                    MessageBox.Show("Please provide the bug solution");
                    txtSolutionDetails.Focus();
                }
                else if (txtCode.Rtf == "")
                {
                    MessageBox.Show("Please method the block which was modified after solving bug");
                    txtCode.Focus();
                }
                else
                {
                    UpdateBugSolution();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
      public void deleteBugSolution()
        {
            try
            {
                bool result = blc.manageBugSolutions(Id, Convert.ToDateTime(dtpDate.Text), Convert.ToInt32(cmbProject.SelectedValue.ToString()), Convert.ToInt32(cmbBugDetails.SelectedValue.ToString()), Convert.ToInt32(cmbBugSolvedBy.SelectedValue.ToString()), txtSolutionDetails.Text, txtCode.Rtf, 3);
                if (result == true)
                {
                    MessageBox.Show("BUG SOLUTION HAS BEEN DELETED");
                    Assitantclass.makeFieldsBlank(gbRegisterBugSolution);
                    dtpDate.Focus();
                }
                else
                {

                    MessageBox.Show("ERROR IN DELETING BUG SOLUTION");
                    Assitantclass.makeFieldsBlank(gbRegisterBugSolution);
                    dtpDate.Focus();
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
                if (dtpDate.Text == "")
                {
                    MessageBox.Show("Please provide Bug Solution");
                    dtpDate.Focus();
                }
                else if (cmbProject.SelectedIndex < 0)
                {
                    MessageBox.Show("Please choose Project");
                    cmbProject.Focus();
                }
                else if (cmbBugDetails.SelectedIndex < 0)
                {
                    MessageBox.Show("Please select the Bug");
                    cmbBugDetails.Focus();
                }
                else if (txtSolutionDetails.Text == "")
                {
                    MessageBox.Show("Please provide the bug solution");
                    txtSolutionDetails.Focus();
                }
                else if (txtCode.Rtf == "")
                {
                    MessageBox.Show("Please method the block which was modified after solving bug");
                    txtCode.Focus();
                }
                else
                {
                    deleteBugSolution();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbBugSolvedBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    cmbBugDetails.DataSource = rbc.getBugsInProjectByProjectId(Convert.ToInt32(cmbBugDetails.SelectedValue.ToString()));
            //    cmbBugDetails.ValueMember = "bugId";
            //    cmbBugDetails.DisplayMember = "bugDetails";
            //    cmbBugDetails.SelectedIndex = -1;
            //}
            //catch (NullReferenceException)
            //{


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dgvRegBugSolution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pbPictureIcon_Click(object sender, EventArgs e)
        {
         
        }
    }
}
