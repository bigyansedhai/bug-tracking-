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
    public partial class RegisterBugSearch : Form
    {
        public RegisterBugSearch()
        {
            InitializeComponent();
        }
        BussinessLogicClass blc = new BussinessLogicClass();
        RegisterBugClass rbc = new RegisterBugClass();


        private void cmbBugSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvBugSearch.DataSource = rbc.getBugsInProjectByProjectId(Convert.ToInt32(cmbBugSearch.Text));

            }
            catch (Exception)
            {


            }
        }

        private void RegisterBugSearch_Load(object sender, EventArgs e)
        {
            cmbBugSearch.DataSource = rbc.getAllBugsforcombobox();
            cmbBugSearch.ValueMember = "bugId";
            cmbBugSearch.DisplayMember = "projectId";
            cmbBugSearch.SelectedIndex = -1;
        }
    }
}
