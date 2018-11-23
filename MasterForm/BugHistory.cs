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
    public partial class BugHistory : Form
    {
        public BugHistory()
        {
            InitializeComponent();
        }


        BussinessLogicClass blc = new BussinessLogicClass();
        RegisterBugClass rbc = new RegisterBugClass();
        ProjectManagementClass pmc = new ProjectManagementClass();
        RegBugSolutionClass rbs = new RegBugSolutionClass();
        MemberClass mcl = new MemberClass();

      
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BugHistory_Load(object sender, EventArgs e)
        {
            
            cmbBugHistory.DataSource = rbc.getAllBugsforcombobox();
            cmbBugHistory.ValueMember = "bugId";
            cmbBugHistory.DisplayMember = "bugDetails";
            cmbBugHistory.SelectedIndex = -1;

        }

        private void cmbBugHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvBugHistory.DataSource = rbs.searchBugSolutionByBugDetails(cmbBugHistory.Text);

            }
            catch (Exception)
            {

                
            }
            


        }

        private void dgvBugHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
        }

        private void cmbBugHistory_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvBugHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
