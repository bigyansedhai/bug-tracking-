using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DataAccesslayer;

namespace MasterForm
{
    public partial class DatabaseBackupRestore : Form
    {
        public DatabaseBackupRestore()
        {
            InitializeComponent();
        }

        private Panel panel1;
        private Label label1;
        private Label label5;
        private Label label2;
        private TextBox txtLocation;
        private TextBox txtRestore;
        private Button btnBackupBrowse;
        private Button btnBackUp;
        private Button btnRestore;
        private Button btnRestoreBrowse;
        SqlConnection conn = new SqlConnection();
        private void btnRestoreBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BackUp File(*.bak)|*.bak|All Files(*.*)|(*.*)";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = ofd.FileName;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBackUp_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBrowse_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnBrowse_MouseLeave(object sender, EventArgs e)
        {
           
        }

        private void btnBackUp_MouseHover(object sender, EventArgs e)
        {
            btnBackUp.BackColor = Color.DarkGreen;
            btnBackUp.ForeColor = Color.White;
        }

        private void btnBackUp_MouseLeave(object sender, EventArgs e)
        {
            btnBackUp.BackColor = Color.White;
            btnBackUp.ForeColor = Color.DarkGreen;
        }

        private void btnRestoreBrowse_MouseHover(object sender, EventArgs e)
        {
            btnBackupBrowse.BackColor = Color.DarkGreen;
            btnBackupBrowse.ForeColor = Color.White;
        }

        private void btnRestoreBrowse_MouseLeave(object sender, EventArgs e)
        {
            btnBackupBrowse.BackColor = Color.White;
            btnBackupBrowse.ForeColor = Color.DarkGreen;
        }

        private void btnRestore_MouseLeave(object sender, EventArgs e)
        {
            btnRestore.BackColor = Color.White;
            btnRestore.ForeColor = Color.DarkGreen;
        }

        private void btnRestore_MouseHover(object sender, EventArgs e)
        {
            btnRestore.BackColor = Color.DarkGreen;
            btnRestore.ForeColor = Color.White;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtRestore = new System.Windows.Forms.TextBox();
            this.btnBackupBrowse = new System.Windows.Forms.Button();
            this.btnBackUp = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRestoreBrowse = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "BACKUP AND RESTORE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Restore :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 22);
            this.label2.TabIndex = 18;
            this.label2.Text = "Back Up Location :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(216, 186);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(447, 22);
            this.txtLocation.TabIndex = 20;
            this.txtLocation.TextChanged += new System.EventHandler(this.txtLocation_TextChanged);
            // 
            // txtRestore
            // 
            this.txtRestore.Location = new System.Drawing.Point(216, 136);
            this.txtRestore.Name = "txtRestore";
            this.txtRestore.Size = new System.Drawing.Size(447, 22);
            this.txtRestore.TabIndex = 21;
            this.txtRestore.TextChanged += new System.EventHandler(this.txtRestore_TextChanged);
            // 
            // btnBackupBrowse
            // 
            this.btnBackupBrowse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackupBrowse.Location = new System.Drawing.Point(468, 341);
            this.btnBackupBrowse.Name = "btnBackupBrowse";
            this.btnBackupBrowse.Size = new System.Drawing.Size(195, 47);
            this.btnBackupBrowse.TabIndex = 24;
            this.btnBackupBrowse.Text = "Backup Browse";
            this.btnBackupBrowse.UseVisualStyleBackColor = true;
            this.btnBackupBrowse.Click += new System.EventHandler(this.btnBackupBrowse_Click);
            this.btnBackupBrowse.MouseLeave += new System.EventHandler(this.btnBackupBrowse_MouseLeave);
            this.btnBackupBrowse.MouseHover += new System.EventHandler(this.btnBackupBrowse_MouseHover);
            // 
            // btnBackUp
            // 
            this.btnBackUp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackUp.Location = new System.Drawing.Point(468, 256);
            this.btnBackUp.Name = "btnBackUp";
            this.btnBackUp.Size = new System.Drawing.Size(195, 47);
            this.btnBackUp.TabIndex = 23;
            this.btnBackUp.Text = "Backup";
            this.btnBackUp.UseVisualStyleBackColor = true;
            this.btnBackUp.Click += new System.EventHandler(this.btnBackUp_Click_1);
            this.btnBackUp.MouseLeave += new System.EventHandler(this.btnBackUp_MouseLeave_1);
            this.btnBackUp.MouseHover += new System.EventHandler(this.btnBackUp_MouseHover_1);
            // 
            // btnRestore
            // 
            this.btnRestore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(205, 256);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(195, 47);
            this.btnRestore.TabIndex = 22;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click_1);
            this.btnRestore.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRestore_MouseClick);
            this.btnRestore.MouseLeave += new System.EventHandler(this.btnRestore_MouseLeave_1);
            this.btnRestore.MouseHover += new System.EventHandler(this.btnRestore_MouseHover_1);
            // 
            // btnRestoreBrowse
            // 
            this.btnRestoreBrowse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreBrowse.Location = new System.Drawing.Point(205, 341);
            this.btnRestoreBrowse.Name = "btnRestoreBrowse";
            this.btnRestoreBrowse.Size = new System.Drawing.Size(195, 47);
            this.btnRestoreBrowse.TabIndex = 25;
            this.btnRestoreBrowse.Text = "Restore Browse";
            this.btnRestoreBrowse.UseVisualStyleBackColor = true;
            this.btnRestoreBrowse.Click += new System.EventHandler(this.btnRestoreBrowse_Click_2);
            this.btnRestoreBrowse.MouseLeave += new System.EventHandler(this.btnRestoreBrowse_MouseLeave_2);
            this.btnRestoreBrowse.MouseHover += new System.EventHandler(this.btnRestoreBrowse_MouseHover_2);
            // 
            // DatabaseBackupRestore
            // 
            this.ClientSize = new System.Drawing.Size(729, 572);
            this.Controls.Add(this.btnRestoreBrowse);
            this.Controls.Add(this.btnBackupBrowse);
            this.Controls.Add(this.btnBackUp);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.txtRestore);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "DatabaseBackupRestore";
            this.Load += new System.EventHandler(this.DatabaseBackupRestore_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DatabaseBackupRestore_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtRestore_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRestore_Click_1(object sender, EventArgs e)
        {
            String Sql = "";
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
                conn.Open();
                string UseMaster = "USE master";
                SqlCommand UseMasterCommand = new SqlCommand(UseMaster, conn);
                UseMasterCommand.ExecuteNonQuery();
                Sql = "alter Database Bugtracker set Single_User with Rollback immediate;";
                Sql += "Restore Database Bugtracker from Disk='" + txtRestore.Text + "' with Replace;";
                SqlCommand cmd = new SqlCommand(Sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Database Successfully Restored");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnBackUp_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectionClass.ConnectionString);
                conn.Open();
                String Sql = "BackUp database Bugtracker to disk ='" + txtLocation.Text + "\\" + "Bugtracker.bak '";

                SqlCommand cmd = new SqlCommand(Sql, conn);
                int rs = cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
                MessageBox.Show("Database backup has been taken to the specified location");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void btnRestoreBrowse_MouseHover_1(object sender, EventArgs e)
        {
        }

        private void btnRestoreBrowse_MouseLeave_1(object sender, EventArgs e)
        {
           
        }

        private void btnRestoreBrowse_Click_2(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "BackUp File(*.bak)|*.bak|All Files(*.*)|(*.*)";
            ofd.FilterIndex = 0;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtRestore.Text = ofd.FileName;
            }
        }

        private void btnBackupBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtLocation.Text = fbd.SelectedPath;
            }
        }

        private void btnRestore_MouseClick(object sender, MouseEventArgs e)
        {

           
        }

        private void btnRestore_MouseLeave_1(object sender, EventArgs e)
        {
            btnRestore.BackColor = Color.White;
            btnRestore.ForeColor = Color.DarkGreen;
        }

        private void btnRestore_MouseHover_1(object sender, EventArgs e)
        {
            btnRestore.BackColor = Color.DarkGreen;
            btnRestore.ForeColor = Color.White;
        }

        private void btnBackUp_MouseHover_1(object sender, EventArgs e)
        {
            btnBackUp.BackColor = Color.DarkGreen;
            btnBackUp.ForeColor = Color.White;
        }

        private void btnBackUp_MouseLeave_1(object sender, EventArgs e)
        {
            btnBackUp.BackColor = Color.DarkGreen;
            btnBackUp.ForeColor = Color.White;
        }

        private void btnRestoreBrowse_MouseHover_2(object sender, EventArgs e)
        {
            btnRestoreBrowse.BackColor = Color.DarkGreen;
            btnRestoreBrowse.ForeColor = Color.White;
        }

        private void btnRestoreBrowse_MouseLeave_2(object sender, EventArgs e)
        {
            btnRestoreBrowse.BackColor = Color.DarkGreen;
            btnRestoreBrowse.ForeColor = Color.White;
        }

        private void btnBackupBrowse_MouseHover(object sender, EventArgs e)
        {

            btnBackupBrowse.BackColor = Color.DarkGreen;
            btnBackupBrowse.ForeColor = Color.White;
        }

        private void btnBackupBrowse_MouseLeave(object sender, EventArgs e)
        {
            btnBackupBrowse.BackColor = Color.DarkGreen;
            btnBackupBrowse.ForeColor = Color.White;
        }
    }
}
