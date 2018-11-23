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
using WinFormsSyntaxHighlighter;
using System.Text.RegularExpressions;

namespace MasterForm
{
    public partial class RegisterBug : Form
    {
    
        public RegisterBug()
        {
            InitializeComponent();

            var syntaxHighlighter = new SyntaxHighlighter(txtCode1);
            
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
        MemberClass mcl = new MemberClass();
        int bugId;
        public string UserType;
        private void label5_Click(object sender, EventArgs e)
        {


        }

       
        public void AddRegisterBug()
        {
            try
            {

                bool result = blc.manageBugs(0, Convert.ToDateTime(dtpBugIdentityDate.Text), Convert.ToInt32(cmbIdentityBy.SelectedValue.ToString()), Convert.ToInt32(cmbProjectName.SelectedValue.ToString()), txtClassLibrary.Text, txtClass.Text, txtMethod.Text, txtBlock.Text, txtLineNumber.Text, txtBugDetails.Text, Assitantclass.imageConverter(pbPictureImages), txtCode1.Rtf, 1);
                if (result == true)
                {
                    MessageBox.Show("NEW BUG RECORD HAS BEEN ADDED");
                    dgvRegisterBug.DataSource = rbc.getAllBugs();
                    Assitantclass.makeFieldsBlank(pnlManageBugInformation);
                    pbPictureImages.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING BUG RECORD");
                    dgvRegisterBug.DataSource = rbc.getAllBugs();
                    Assitantclass.makeFieldsBlank(pnlManageBugInformation);
                    pbPictureImages.Image = null;
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
                if (cmbIdentityBy.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Provide the Identity By");
                    cmbIdentityBy.Focus();

                }
                else if (cmbProjectName.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Provide the Project Name");
                    cmbProjectName.Focus();
                }
                else if (txtClassLibrary.Text == "")
                {
                    MessageBox.Show("Please Provide the Class Libaray");
                    txtClassLibrary.Focus();
                }
                else if (txtClass.Text == "")
                {
                    MessageBox.Show("Please Provide the ClassName");
                    txtClass.Focus();
                }
                else if (txtMethod.Text == "")
                {
                    MessageBox.Show("Please Provide the Method");
                    txtMethod.Focus();
                }
                else if (txtBlock.Text == "")
                {
                    MessageBox.Show("Please provide the Block");
                    txtBlock.Focus();
                }
                else if (txtLineNumber.Text == "")
                {
                    MessageBox.Show("Please Provide the Line Number");
                    txtLineNumber.Focus();
                }
                else if (txtBugDetails.Text == "")
                {
                    MessageBox.Show("Please Provide the Bug Details");
                    txtBugDetails.Focus();
                }
                else if (pbPictureImages.Image == null)
                {
                    MessageBox.Show("Please Select The Picture from Gallary");
                    pbPictureImages.Focus();
                }
                else
                {
                    AddRegisterBug();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
                        pbPictureImages.Image = Image.FromFile(ofd.FileName);

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

        private void dgvRegisterBug_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                bugId = Convert.ToInt32(dgvRegisterBug.SelectedRows[0].Cells["bugId"].Value.ToString());
                dtpBugIdentityDate.Text = dgvRegisterBug.SelectedRows[0].Cells["bugIdentifiedDate"].Value.ToString();
                cmbIdentityBy.Text = dgvRegisterBug.SelectedRows[0].Cells["memberName"].Value.ToString();
                cmbProjectName.Text = dgvRegisterBug.SelectedRows[0].Cells["projectName"].Value.ToString();
                txtClassLibrary.Text = dgvRegisterBug.SelectedRows[0].Cells["classLibraryName"].Value.ToString();
                txtClass.Text = dgvRegisterBug.SelectedRows[0].Cells["className"].Value.ToString();
                txtMethod.Text = dgvRegisterBug.SelectedRows[0].Cells["methodName"].Value.ToString();
                txtBlock.Text = dgvRegisterBug.SelectedRows[0].Cells["blockName"].Value.ToString();
                txtLineNumber.Text = dgvRegisterBug.SelectedRows[0].Cells["lineNumber"].Value.ToString();
                txtBugDetails.Text = dgvRegisterBug.SelectedRows[0].Cells["bugDetails"].Value.ToString();


                MemoryStream memoryStream = new MemoryStream((byte[])dgvRegisterBug.SelectedRows[0].Cells["pbPictureImage"].Value);
                pbPictureImages.Image = Image.FromStream(memoryStream);

                txtCode1.Rtf = dgvRegisterBug.SelectedRows[0].Cells["codeContainingBug"].Value.ToString();

                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void RegisterBug_Load(object sender, EventArgs e)
        {
            dgvRegisterBug.DataSource = rbc.getAllBugs();
            cmbIdentityBy.ValueMember = "memberId";
            cmbIdentityBy.DisplayMember = "memberName";
            cmbIdentityBy.DataSource = mcl.getAllMembers();
            cmbIdentityBy.SelectedIndex = -1;
            cmbProjectName.DataSource = pmc.getAllProjects();
            cmbProjectName.ValueMember = "projectId";
            cmbProjectName.DisplayMember = "projectName";
            cmbProjectName.SelectedIndex = -1;
            if (UserType=="Tester")
            {
                btnDelete.Enabled = false;
            }

        }

        public void UpdateRegisterBug()
        {
            try
            {

                bool result = blc.manageBugs(bugId, Convert.ToDateTime(dtpBugIdentityDate.Text), Convert.ToInt32(cmbIdentityBy.SelectedValue.ToString()), Convert.ToInt32(cmbProjectName.SelectedValue.ToString()), txtClassLibrary.Text, txtClass.Text, txtMethod.Text, txtBlock.Text, txtLineNumber.Text, txtBugDetails.Text, Assitantclass.imageConverter(pbPictureImages), txtCode1.Rtf, 2);
                if (result == true)
                {
                    MessageBox.Show("NEW BUG RECORD HAS BEEN UPDATED");
                    dgvRegisterBug.DataSource = rbc.getAllBugs();
                    Assitantclass.makeFieldsBlank(pnlManageBugInformation);
                    pbPictureImages.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN UPDATING BUG RECORD");
                    dgvRegisterBug.DataSource = rbc.getAllBugs();
                    Assitantclass.makeFieldsBlank(pnlManageBugInformation);
                    pbPictureImages.Image = null;
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Some fields cann't be null");
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
                if (cmbIdentityBy.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Provide the Identity By");
                    cmbIdentityBy.Focus();

                }
                else if (cmbProjectName.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Provide the Project Name");
                    cmbProjectName.Focus();
                }
                else if (txtClassLibrary.Text == "")
                {
                    MessageBox.Show("Please Provide the Class Libaray");
                    txtClassLibrary.Focus();
                }
                else if (txtClass.Text == "")
                {
                    MessageBox.Show("Please Provide the ClassName");
                    txtClass.Focus();
                }
                else if (txtMethod.Text == "")
                {
                    MessageBox.Show("Please Provide the Method");
                    txtMethod.Focus();
                }
                else if (txtBlock.Text == "")
                {
                    MessageBox.Show("Please provide the Block");
                    txtBlock.Focus();
                }
                else if (txtLineNumber.Text == "")
                {
                    MessageBox.Show("Please Provide the Line Number");
                    txtLineNumber.Focus();
                }
                else if (txtBugDetails.Text == "")
                {
                    MessageBox.Show("Please Provide the Bug Details");
                    txtBugDetails.Focus();
                }
                else if (pbPictureImages.Image == null)
                {
                    MessageBox.Show("Please Select The Picture from Gallary");
                    pbPictureImages.Focus();
                }
                else
                {
                    UpdateRegisterBug();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void DeleteRegBug()
        {
            try
            {

                bool result = blc.manageBugs(bugId, Convert.ToDateTime(dtpBugIdentityDate.Text), Convert.ToInt32(cmbIdentityBy.SelectedValue.ToString()), Convert.ToInt32(cmbProjectName.SelectedValue.ToString()), txtClassLibrary.Text, txtClass.Text, txtMethod.Text, txtBlock.Text, txtLineNumber.Text, txtBugDetails.Text, Assitantclass.imageConverter(pbPictureImages), txtCode1.Rtf, 3);
                if (result == true)
                {
                    MessageBox.Show("NEW BUG RECORD HAS BEEN SUCCESSFULLY DELETED");
                    dgvRegisterBug.DataSource = rbc.getAllBugs();
                    Assitantclass.makeFieldsBlank(pnlManageBugInformation);
                    pbPictureImages.Image = null;
                }
                else
                {
                    MessageBox.Show("ERROR IN ADDING BUG RECORD");
                    dgvRegisterBug.DataSource = rbc.getAllBugs();
                    Assitantclass.makeFieldsBlank(pnlManageBugInformation);
                    pbPictureImages.Image = null;
                }
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("Some fields cann't be null");
            }
            catch (Exception ex)
            {


                throw ex;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbIdentityBy.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Provide the Identity By");
                    cmbIdentityBy.Focus();

                }
                else if (cmbProjectName.SelectedIndex < 0)
                {
                    MessageBox.Show("Please Provide the Project Name");
                    cmbProjectName.Focus();
                }
                else if (txtClassLibrary.Text == "")
                {
                    MessageBox.Show("Please Provide the Class Libaray");
                    txtClassLibrary.Focus();
                }
                else if (txtClass.Text == "")
                {
                    MessageBox.Show("Please Provide the ClassName");
                    txtClass.Focus();
                }
                else if (txtMethod.Text == "")
                {
                    MessageBox.Show("Please Provide the Method");
                    txtMethod.Focus();
                }
                else if (txtBlock.Text == "")
                {
                    MessageBox.Show("Please provide the Block");
                    txtBlock.Focus();
                }
                else if (txtLineNumber.Text == "")
                {
                    MessageBox.Show("Please Provide the Line Number");
                    txtLineNumber.Focus();
                }
                else if (txtBugDetails.Text == "")
                {
                    MessageBox.Show("Please Provide the Bug Details");
                    txtBugDetails.Focus();
                }
                else if (pbPictureImages.Image == null)
                {
                    MessageBox.Show("Please Select The Picture from Gallary");
                    pbPictureImages.Focus();
                }
                else
                {
                    DeleteRegBug();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cmbIdentityBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvRegisterBug_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }


