namespace MasterForm
{
    partial class RegisterBug
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnlManageBugInformation = new System.Windows.Forms.Panel();
            this.txtCode1 = new System.Windows.Forms.RichTextBox();
            this.txtcode = new System.Windows.Forms.Label();
            this.txtBugDetails = new System.Windows.Forms.TextBox();
            this.txtLineNumber = new System.Windows.Forms.TextBox();
            this.txtBlock = new System.Windows.Forms.TextBox();
            this.txtMethod = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtClassLibrary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProjectName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIdentityBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpBugIdentityDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbPictureImages = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvRegisterBug = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlManageBugInformation.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureImages)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterBug)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 83);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Bug";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnlManageBugInformation);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1088, 517);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Bug";
            // 
            // pnlManageBugInformation
            // 
            this.pnlManageBugInformation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnlManageBugInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlManageBugInformation.Controls.Add(this.txtCode1);
            this.pnlManageBugInformation.Controls.Add(this.txtcode);
            this.pnlManageBugInformation.Controls.Add(this.txtBugDetails);
            this.pnlManageBugInformation.Controls.Add(this.txtLineNumber);
            this.pnlManageBugInformation.Controls.Add(this.txtBlock);
            this.pnlManageBugInformation.Controls.Add(this.txtMethod);
            this.pnlManageBugInformation.Controls.Add(this.txtClass);
            this.pnlManageBugInformation.Controls.Add(this.label10);
            this.pnlManageBugInformation.Controls.Add(this.label9);
            this.pnlManageBugInformation.Controls.Add(this.label8);
            this.pnlManageBugInformation.Controls.Add(this.label7);
            this.pnlManageBugInformation.Controls.Add(this.label6);
            this.pnlManageBugInformation.Controls.Add(this.txtClassLibrary);
            this.pnlManageBugInformation.Controls.Add(this.label5);
            this.pnlManageBugInformation.Controls.Add(this.cmbProjectName);
            this.pnlManageBugInformation.Controls.Add(this.label4);
            this.pnlManageBugInformation.Controls.Add(this.cmbIdentityBy);
            this.pnlManageBugInformation.Controls.Add(this.label3);
            this.pnlManageBugInformation.Controls.Add(this.dtpBugIdentityDate);
            this.pnlManageBugInformation.Controls.Add(this.label2);
            this.pnlManageBugInformation.Location = new System.Drawing.Point(7, 16);
            this.pnlManageBugInformation.Name = "pnlManageBugInformation";
            this.pnlManageBugInformation.Size = new System.Drawing.Size(725, 501);
            this.pnlManageBugInformation.TabIndex = 42;
            // 
            // txtCode1
            // 
            this.txtCode1.Location = new System.Drawing.Point(185, 274);
            this.txtCode1.Name = "txtCode1";
            this.txtCode1.Size = new System.Drawing.Size(457, 111);
            this.txtCode1.TabIndex = 56;
            this.txtCode1.Text = "";
            // 
            // txtcode
            // 
            this.txtcode.AutoSize = true;
            this.txtcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcode.Location = new System.Drawing.Point(14, 303);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(63, 22);
            this.txtcode.TabIndex = 55;
            this.txtcode.Text = "Code :";
            // 
            // txtBugDetails
            // 
            this.txtBugDetails.Location = new System.Drawing.Point(185, 391);
            this.txtBugDetails.Multiline = true;
            this.txtBugDetails.Name = "txtBugDetails";
            this.txtBugDetails.Size = new System.Drawing.Size(457, 103);
            this.txtBugDetails.TabIndex = 54;
            // 
            // txtLineNumber
            // 
            this.txtLineNumber.Location = new System.Drawing.Point(185, 246);
            this.txtLineNumber.Name = "txtLineNumber";
            this.txtLineNumber.Size = new System.Drawing.Size(200, 22);
            this.txtLineNumber.TabIndex = 53;
            // 
            // txtBlock
            // 
            this.txtBlock.Location = new System.Drawing.Point(185, 218);
            this.txtBlock.Name = "txtBlock";
            this.txtBlock.Size = new System.Drawing.Size(200, 22);
            this.txtBlock.TabIndex = 52;
            // 
            // txtMethod
            // 
            this.txtMethod.Location = new System.Drawing.Point(185, 181);
            this.txtMethod.Name = "txtMethod";
            this.txtMethod.Size = new System.Drawing.Size(200, 22);
            this.txtMethod.TabIndex = 51;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(185, 148);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(200, 22);
            this.txtClass.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 22);
            this.label10.TabIndex = 49;
            this.label10.Text = "Bug Details :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 245);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 22);
            this.label9.TabIndex = 48;
            this.label9.Text = "Line Number :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 22);
            this.label8.TabIndex = 47;
            this.label8.Text = "Block :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 22);
            this.label7.TabIndex = 46;
            this.label7.Text = "Method :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 22);
            this.label6.TabIndex = 45;
            this.label6.Text = "Class :";
            // 
            // txtClassLibrary
            // 
            this.txtClassLibrary.Location = new System.Drawing.Point(185, 112);
            this.txtClassLibrary.Name = "txtClassLibrary";
            this.txtClassLibrary.Size = new System.Drawing.Size(200, 22);
            this.txtClassLibrary.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 43;
            this.label5.Text = "Class library :";
            // 
            // cmbProjectName
            // 
            this.cmbProjectName.FormattingEnabled = true;
            this.cmbProjectName.Location = new System.Drawing.Point(185, 77);
            this.cmbProjectName.Name = "cmbProjectName";
            this.cmbProjectName.Size = new System.Drawing.Size(200, 24);
            this.cmbProjectName.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 41;
            this.label4.Text = "Project Name :";
            // 
            // cmbIdentityBy
            // 
            this.cmbIdentityBy.FormattingEnabled = true;
            this.cmbIdentityBy.Location = new System.Drawing.Point(185, 43);
            this.cmbIdentityBy.Name = "cmbIdentityBy";
            this.cmbIdentityBy.Size = new System.Drawing.Size(200, 24);
            this.cmbIdentityBy.TabIndex = 40;
            this.cmbIdentityBy.SelectedIndexChanged += new System.EventHandler(this.cmbIdentityBy_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 22);
            this.label3.TabIndex = 39;
            this.label3.Text = "Identified By :";
            // 
            // dtpBugIdentityDate
            // 
            this.dtpBugIdentityDate.Location = new System.Drawing.Point(185, 14);
            this.dtpBugIdentityDate.Name = "dtpBugIdentityDate";
            this.dtpBugIdentityDate.Size = new System.Drawing.Size(200, 22);
            this.dtpBugIdentityDate.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 37;
            this.label2.Text = "BugIdentifiedDate :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.btnDelete);
            this.panel4.Controls.Add(this.btnUpdate);
            this.panel4.Location = new System.Drawing.Point(825, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 130);
            this.panel4.TabIndex = 41;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(6, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(221, 34);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(6, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(221, 35);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(6, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(221, 35);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(825, 232);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(163, 33);
            this.btnBrowse.TabIndex = 38;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.pbPictureImages);
            this.panel2.Location = new System.Drawing.Point(736, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 206);
            this.panel2.TabIndex = 37;
            // 
            // pbPictureImages
            // 
            this.pbPictureImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPictureImages.Location = new System.Drawing.Point(0, 0);
            this.pbPictureImages.Name = "pbPictureImages";
            this.pbPictureImages.Size = new System.Drawing.Size(342, 202);
            this.pbPictureImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPictureImages.TabIndex = 0;
            this.pbPictureImages.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dgvRegisterBug);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 638);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1112, 172);
            this.panel3.TabIndex = 2;
            // 
            // dgvRegisterBug
            // 
            this.dgvRegisterBug.AllowUserToAddRows = false;
            this.dgvRegisterBug.AllowUserToDeleteRows = false;
            this.dgvRegisterBug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegisterBug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegisterBug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegisterBug.Location = new System.Drawing.Point(0, 0);
            this.dgvRegisterBug.Name = "dgvRegisterBug";
            this.dgvRegisterBug.ReadOnly = true;
            this.dgvRegisterBug.RowTemplate.Height = 24;
            this.dgvRegisterBug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegisterBug.Size = new System.Drawing.Size(1108, 168);
            this.dgvRegisterBug.TabIndex = 41;
            this.dgvRegisterBug.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegisterBug_CellClick);
            this.dgvRegisterBug.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegisterBug_CellContentClick);
            // 
            // RegisterBug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 810);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterBug";
            this.Text = "RegisterBug";
            this.Load += new System.EventHandler(this.RegisterBug_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlManageBugInformation.ResumeLayout(false);
            this.pnlManageBugInformation.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureImages)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegisterBug)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbPictureImages;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvRegisterBug;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlManageBugInformation;
        private System.Windows.Forms.TextBox txtBugDetails;
        private System.Windows.Forms.TextBox txtLineNumber;
        private System.Windows.Forms.TextBox txtBlock;
        private System.Windows.Forms.TextBox txtMethod;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtClassLibrary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIdentityBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpBugIdentityDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtCode1;
        private System.Windows.Forms.Label txtcode;
    }
}