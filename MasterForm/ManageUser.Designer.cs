namespace MasterForm
{
    partial class ManageUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvManageUser = new System.Windows.Forms.DataGridView();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.txtconfirmpassword = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.cmbfirstname = new System.Windows.Forms.ComboBox();
            this.cmbUserRole = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageUser)).BeginInit();
            this.pnlUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(895, 75);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGE  USER";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(697, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 171);
            this.panel2.TabIndex = 11;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(-2, 113);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(195, 47);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(-2, 60);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(195, 47);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(-2, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(195, 47);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvManageUser);
            this.panel3.Location = new System.Drawing.Point(2, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(895, 219);
            this.panel3.TabIndex = 12;
            // 
            // dgvManageUser
            // 
            this.dgvManageUser.AllowUserToDeleteRows = false;
            this.dgvManageUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvManageUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvManageUser.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvManageUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvManageUser.Location = new System.Drawing.Point(0, 0);
            this.dgvManageUser.Name = "dgvManageUser";
            this.dgvManageUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvManageUser.RowTemplate.Height = 24;
            this.dgvManageUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvManageUser.Size = new System.Drawing.Size(895, 219);
            this.dgvManageUser.TabIndex = 13;
            this.dgvManageUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageUser_CellClick);
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.txtconfirmpassword);
            this.pnlUserInfo.Controls.Add(this.txtpassword);
            this.pnlUserInfo.Controls.Add(this.txtusername);
            this.pnlUserInfo.Controls.Add(this.cmbfirstname);
            this.pnlUserInfo.Controls.Add(this.cmbUserRole);
            this.pnlUserInfo.Controls.Add(this.label6);
            this.pnlUserInfo.Controls.Add(this.label5);
            this.pnlUserInfo.Controls.Add(this.label4);
            this.pnlUserInfo.Controls.Add(this.label3);
            this.pnlUserInfo.Controls.Add(this.label2);
            this.pnlUserInfo.Location = new System.Drawing.Point(2, 75);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(663, 206);
            this.pnlUserInfo.TabIndex = 13;
            // 
            // txtconfirmpassword
            // 
            this.txtconfirmpassword.Location = new System.Drawing.Point(180, 162);
            this.txtconfirmpassword.Name = "txtconfirmpassword";
            this.txtconfirmpassword.PasswordChar = '*';
            this.txtconfirmpassword.Size = new System.Drawing.Size(278, 22);
            this.txtconfirmpassword.TabIndex = 20;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(180, 128);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(278, 22);
            this.txtpassword.TabIndex = 19;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(180, 93);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(278, 22);
            this.txtusername.TabIndex = 18;
            // 
            // cmbfirstname
            // 
            this.cmbfirstname.FormattingEnabled = true;
            this.cmbfirstname.Location = new System.Drawing.Point(180, 59);
            this.cmbfirstname.Name = "cmbfirstname";
            this.cmbfirstname.Size = new System.Drawing.Size(278, 24);
            this.cmbfirstname.TabIndex = 17;
            // 
            // cmbUserRole
            // 
            this.cmbUserRole.FormattingEnabled = true;
            this.cmbUserRole.Location = new System.Drawing.Point(180, 22);
            this.cmbUserRole.Name = "cmbUserRole";
            this.cmbUserRole.Size = new System.Drawing.Size(278, 24);
            this.cmbUserRole.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Confirm Password :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 14;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "User Name : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "User Role :";
            // 
            // ManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 502);
            this.Controls.Add(this.pnlUserInfo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ManageUser";
            this.Text = "ManageUser";
            this.Load += new System.EventHandler(this.ManageUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageUser)).EndInit();
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvManageUser;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.TextBox txtconfirmpassword;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.ComboBox cmbfirstname;
        private System.Windows.Forms.ComboBox cmbUserRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}