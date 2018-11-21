namespace MasterForm
{
    partial class RegisterBugSolution
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
            this.gbRegisterBugSolution = new System.Windows.Forms.Panel();
            this.txtCode = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtSolutionDetails = new System.Windows.Forms.TextBox();
            this.cmbBugDetails = new System.Windows.Forms.ComboBox();
            this.cmbProject = new System.Windows.Forms.ComboBox();
            this.cmbBugSolvedBy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbPictureIcon = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvRegBugSolution = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbRegisterBugSolution.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureIcon)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegBugSolution)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 84);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Bug Solution";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbRegisterBugSolution);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Location = new System.Drawing.Point(2, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 333);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register Bug Solution";
            // 
            // gbRegisterBugSolution
            // 
            this.gbRegisterBugSolution.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbRegisterBugSolution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gbRegisterBugSolution.Controls.Add(this.txtCode);
            this.gbRegisterBugSolution.Controls.Add(this.label7);
            this.gbRegisterBugSolution.Controls.Add(this.dtpDate);
            this.gbRegisterBugSolution.Controls.Add(this.txtSolutionDetails);
            this.gbRegisterBugSolution.Controls.Add(this.cmbBugDetails);
            this.gbRegisterBugSolution.Controls.Add(this.cmbProject);
            this.gbRegisterBugSolution.Controls.Add(this.cmbBugSolvedBy);
            this.gbRegisterBugSolution.Controls.Add(this.label6);
            this.gbRegisterBugSolution.Controls.Add(this.label5);
            this.gbRegisterBugSolution.Controls.Add(this.label4);
            this.gbRegisterBugSolution.Controls.Add(this.label3);
            this.gbRegisterBugSolution.Controls.Add(this.label2);
            this.gbRegisterBugSolution.Location = new System.Drawing.Point(-2, 22);
            this.gbRegisterBugSolution.Name = "gbRegisterBugSolution";
            this.gbRegisterBugSolution.Size = new System.Drawing.Size(577, 305);
            this.gbRegisterBugSolution.TabIndex = 11;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(176, 197);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(394, 101);
            this.txtCode.TabIndex = 21;
            this.txtCode.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 235);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "Code  :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(176, 40);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(306, 22);
            this.dtpDate.TabIndex = 19;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // txtSolutionDetails
            // 
            this.txtSolutionDetails.Location = new System.Drawing.Point(176, 146);
            this.txtSolutionDetails.Multiline = true;
            this.txtSolutionDetails.Name = "txtSolutionDetails";
            this.txtSolutionDetails.Size = new System.Drawing.Size(306, 45);
            this.txtSolutionDetails.TabIndex = 18;
            // 
            // cmbBugDetails
            // 
            this.cmbBugDetails.FormattingEnabled = true;
            this.cmbBugDetails.Location = new System.Drawing.Point(176, 116);
            this.cmbBugDetails.Name = "cmbBugDetails";
            this.cmbBugDetails.Size = new System.Drawing.Size(306, 24);
            this.cmbBugDetails.TabIndex = 17;
            this.cmbBugDetails.SelectedIndexChanged += new System.EventHandler(this.cmbBugDetails_SelectedIndexChanged);
            // 
            // cmbProject
            // 
            this.cmbProject.FormattingEnabled = true;
            this.cmbProject.Location = new System.Drawing.Point(176, 76);
            this.cmbProject.Name = "cmbProject";
            this.cmbProject.Size = new System.Drawing.Size(306, 24);
            this.cmbProject.TabIndex = 16;
            this.cmbProject.SelectedIndexChanged += new System.EventHandler(this.cmbProject_SelectedIndexChanged);
            // 
            // cmbBugSolvedBy
            // 
            this.cmbBugSolvedBy.FormattingEnabled = true;
            this.cmbBugSolvedBy.Location = new System.Drawing.Point(176, 9);
            this.cmbBugSolvedBy.Name = "cmbBugSolvedBy";
            this.cmbBugSolvedBy.Size = new System.Drawing.Size(306, 24);
            this.cmbBugSolvedBy.TabIndex = 15;
            this.cmbBugSolvedBy.SelectedIndexChanged += new System.EventHandler(this.cmbBugSolvedBy_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 22);
            this.label6.TabIndex = 14;
            this.label6.Text = "Solution Details :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Bug Details :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Project :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bug Solved By :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbPictureIcon);
            this.panel2.Location = new System.Drawing.Point(581, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 305);
            this.panel2.TabIndex = 10;
            // 
            // pbPictureIcon
            // 
            this.pbPictureIcon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbPictureIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPictureIcon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPictureIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPictureIcon.Location = new System.Drawing.Point(0, 0);
            this.pbPictureIcon.Name = "pbPictureIcon";
            this.pbPictureIcon.Size = new System.Drawing.Size(438, 305);
            this.pbPictureIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPictureIcon.TabIndex = 0;
            this.pbPictureIcon.TabStop = false;
            this.pbPictureIcon.Click += new System.EventHandler(this.pbPictureIcon_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Location = new System.Drawing.Point(2, 454);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1045, 55);
            this.panel3.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(614, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(197, 35);
            this.btnDelete.TabIndex = 32;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(20, 14);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 34);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(309, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(197, 35);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dgvRegBugSolution);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 513);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1049, 240);
            this.panel4.TabIndex = 3;
            // 
            // dgvRegBugSolution
            // 
            this.dgvRegBugSolution.AllowUserToAddRows = false;
            this.dgvRegBugSolution.AllowUserToDeleteRows = false;
            this.dgvRegBugSolution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegBugSolution.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegBugSolution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRegBugSolution.Location = new System.Drawing.Point(0, 0);
            this.dgvRegBugSolution.Name = "dgvRegBugSolution";
            this.dgvRegBugSolution.ReadOnly = true;
            this.dgvRegBugSolution.RowTemplate.Height = 24;
            this.dgvRegBugSolution.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegBugSolution.Size = new System.Drawing.Size(1045, 236);
            this.dgvRegBugSolution.TabIndex = 0;
            this.dgvRegBugSolution.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegBugSolution_CellClick);
            this.dgvRegBugSolution.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegBugSolution_CellContentClick);
            // 
            // RegisterBugSolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 753);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterBugSolution";
            this.Text = "RegisterBugSolution";
            this.Load += new System.EventHandler(this.RegisterBugSolution_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbRegisterBugSolution.ResumeLayout(false);
            this.gbRegisterBugSolution.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPictureIcon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegBugSolution)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbPictureIcon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvRegBugSolution;
        private System.Windows.Forms.Panel gbRegisterBugSolution;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbBugDetails;
        private System.Windows.Forms.ComboBox cmbProject;
        private System.Windows.Forms.ComboBox cmbBugSolvedBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSolutionDetails;
    }
}