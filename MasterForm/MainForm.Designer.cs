namespace MasterForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.BtnClone = new System.Windows.Forms.Button();
            this.btnBugHis = new System.Windows.Forms.Button();
            this.btnBugSol = new System.Windows.Forms.Button();
            this.btnNewbug = new System.Windows.Forms.Button();
            this.btnProjectManage = new System.Windows.Forms.Button();
            this.btnProjectMember = new System.Windows.Forms.Button();
            this.btnManageMember = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnManageUserRole = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbldate = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageUserRoleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMemberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewBugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerBugSolutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bugHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cloneToBitBucketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalFixed = new System.Windows.Forms.Label();
            this.lblTotalBugResigter = new System.Windows.Forms.Label();
            this.lbltmem = new System.Windows.Forms.Label();
            this.lblTotalProject = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 60);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 57);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Algerian", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(1228, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 25);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug Tracking System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.BtnClone);
            this.panel2.Controls.Add(this.btnBugHis);
            this.panel2.Controls.Add(this.btnBugSol);
            this.panel2.Controls.Add(this.btnNewbug);
            this.panel2.Controls.Add(this.btnProjectManage);
            this.panel2.Controls.Add(this.btnProjectMember);
            this.panel2.Controls.Add(this.btnManageMember);
            this.panel2.Controls.Add(this.btnManageUser);
            this.panel2.Controls.Add(this.btnManageUserRole);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 734);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.BackgroundImage")));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.Location = new System.Drawing.Point(-2, 648);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(144, 85);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.button11_Click);
            // 
            // BtnClone
            // 
            this.BtnClone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnClone.BackgroundImage")));
            this.BtnClone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnClone.Location = new System.Drawing.Point(0, 573);
            this.BtnClone.Name = "BtnClone";
            this.BtnClone.Size = new System.Drawing.Size(141, 72);
            this.BtnClone.TabIndex = 8;
            this.BtnClone.UseVisualStyleBackColor = true;
            // 
            // btnBugHis
            // 
            this.btnBugHis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBugHis.BackgroundImage")));
            this.btnBugHis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBugHis.Location = new System.Drawing.Point(-3, 495);
            this.btnBugHis.Name = "btnBugHis";
            this.btnBugHis.Size = new System.Drawing.Size(145, 77);
            this.btnBugHis.TabIndex = 8;
            this.btnBugHis.UseVisualStyleBackColor = true;
            this.btnBugHis.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnBugSol
            // 
            this.btnBugSol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBugSol.BackgroundImage")));
            this.btnBugSol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBugSol.Location = new System.Drawing.Point(0, 427);
            this.btnBugSol.Name = "btnBugSol";
            this.btnBugSol.Size = new System.Drawing.Size(142, 67);
            this.btnBugSol.TabIndex = 7;
            this.btnBugSol.UseVisualStyleBackColor = true;
            this.btnBugSol.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnNewbug
            // 
            this.btnNewbug.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewbug.BackgroundImage")));
            this.btnNewbug.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewbug.Location = new System.Drawing.Point(0, 355);
            this.btnNewbug.Name = "btnNewbug";
            this.btnNewbug.Size = new System.Drawing.Size(142, 71);
            this.btnNewbug.TabIndex = 6;
            this.btnNewbug.UseVisualStyleBackColor = true;
            this.btnNewbug.Click += new System.EventHandler(this.button7_Click);
            // 
            // btnProjectManage
            // 
            this.btnProjectManage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProjectManage.BackgroundImage")));
            this.btnProjectManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProjectManage.Location = new System.Drawing.Point(0, 287);
            this.btnProjectManage.Name = "btnProjectManage";
            this.btnProjectManage.Size = new System.Drawing.Size(142, 67);
            this.btnProjectManage.TabIndex = 5;
            this.btnProjectManage.UseVisualStyleBackColor = true;
            this.btnProjectManage.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnProjectMember
            // 
            this.btnProjectMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProjectMember.BackgroundImage")));
            this.btnProjectMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProjectMember.Location = new System.Drawing.Point(0, 219);
            this.btnProjectMember.Name = "btnProjectMember";
            this.btnProjectMember.Size = new System.Drawing.Size(142, 68);
            this.btnProjectMember.TabIndex = 4;
            this.btnProjectMember.UseVisualStyleBackColor = true;
            this.btnProjectMember.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnManageMember
            // 
            this.btnManageMember.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageMember.BackgroundImage")));
            this.btnManageMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageMember.Location = new System.Drawing.Point(0, 143);
            this.btnManageMember.Name = "btnManageMember";
            this.btnManageMember.Size = new System.Drawing.Size(140, 77);
            this.btnManageMember.TabIndex = 3;
            this.btnManageMember.UseVisualStyleBackColor = true;
            this.btnManageMember.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageUser.BackgroundImage")));
            this.btnManageUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageUser.Location = new System.Drawing.Point(0, 72);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(142, 72);
            this.btnManageUser.TabIndex = 2;
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnManageUserRole
            // 
            this.btnManageUserRole.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnManageUserRole.BackgroundImage")));
            this.btnManageUserRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManageUserRole.Location = new System.Drawing.Point(-3, 1);
            this.btnManageUserRole.Name = "btnManageUserRole";
            this.btnManageUserRole.Size = new System.Drawing.Size(145, 72);
            this.btnManageUserRole.TabIndex = 1;
            this.btnManageUserRole.UseVisualStyleBackColor = true;
            this.btnManageUserRole.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Controls.Add(this.lbldate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(142, 706);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 88);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(1083, 33);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(0, 23);
            this.lbldate.TabIndex = 5;
            this.lbldate.Click += new System.EventHandler(this.label10_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.menuStrip1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(142, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1350, 43);
            this.panel4.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUserRoleToolStripMenuItem,
            this.manageUserToolStripMenuItem,
            this.manageMemberToolStripMenuItem,
            this.manageProjectToolStripMenuItem,
            this.registerNewBugToolStripMenuItem,
            this.registerBugSolutionToolStripMenuItem,
            this.bugHistoryToolStripMenuItem,
            this.cloneToBitBucketToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.logOutToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1327, 25);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // manageUserRoleToolStripMenuItem
            // 
            this.manageUserRoleToolStripMenuItem.MergeIndex = 0;
            this.manageUserRoleToolStripMenuItem.Name = "manageUserRoleToolStripMenuItem";
            this.manageUserRoleToolStripMenuItem.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.manageUserRoleToolStripMenuItem.Size = new System.Drawing.Size(152, 21);
            this.manageUserRoleToolStripMenuItem.Text = "Manage User Role";
            this.manageUserRoleToolStripMenuItem.Click += new System.EventHandler(this.manageUserRoleToolStripMenuItem_Click);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(109, 21);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            this.manageUserToolStripMenuItem.Click += new System.EventHandler(this.manageUserToolStripMenuItem_Click);
            // 
            // manageMemberToolStripMenuItem
            // 
            this.manageMemberToolStripMenuItem.Name = "manageMemberToolStripMenuItem";
            this.manageMemberToolStripMenuItem.Size = new System.Drawing.Size(134, 21);
            this.manageMemberToolStripMenuItem.Text = "Manage Member";
            this.manageMemberToolStripMenuItem.Click += new System.EventHandler(this.manageMemberToolStripMenuItem_Click);
            // 
            // manageProjectToolStripMenuItem
            // 
            this.manageProjectToolStripMenuItem.Name = "manageProjectToolStripMenuItem";
            this.manageProjectToolStripMenuItem.Size = new System.Drawing.Size(132, 21);
            this.manageProjectToolStripMenuItem.Text = "Project  Member";
            this.manageProjectToolStripMenuItem.Click += new System.EventHandler(this.manageProjectToolStripMenuItem_Click);
            // 
            // registerNewBugToolStripMenuItem
            // 
            this.registerNewBugToolStripMenuItem.Name = "registerNewBugToolStripMenuItem";
            this.registerNewBugToolStripMenuItem.Size = new System.Drawing.Size(161, 21);
            this.registerNewBugToolStripMenuItem.Text = "Project  Management";
            this.registerNewBugToolStripMenuItem.Click += new System.EventHandler(this.registerNewBugToolStripMenuItem_Click);
            // 
            // registerBugSolutionToolStripMenuItem
            // 
            this.registerBugSolutionToolStripMenuItem.Name = "registerBugSolutionToolStripMenuItem";
            this.registerBugSolutionToolStripMenuItem.Size = new System.Drawing.Size(141, 21);
            this.registerBugSolutionToolStripMenuItem.Text = "Register New Bug";
            this.registerBugSolutionToolStripMenuItem.Click += new System.EventHandler(this.registerBugSolutionToolStripMenuItem_Click);
            // 
            // bugHistoryToolStripMenuItem
            // 
            this.bugHistoryToolStripMenuItem.Name = "bugHistoryToolStripMenuItem";
            this.bugHistoryToolStripMenuItem.Size = new System.Drawing.Size(165, 21);
            this.bugHistoryToolStripMenuItem.Text = "Register Bug Solution";
            this.bugHistoryToolStripMenuItem.Click += new System.EventHandler(this.bugHistoryToolStripMenuItem_Click);
            // 
            // cloneToBitBucketToolStripMenuItem
            // 
            this.cloneToBitBucketToolStripMenuItem.Name = "cloneToBitBucketToolStripMenuItem";
            this.cloneToBitBucketToolStripMenuItem.Size = new System.Drawing.Size(100, 21);
            this.cloneToBitBucketToolStripMenuItem.Text = "Bug History";
            this.cloneToBitBucketToolStripMenuItem.Click += new System.EventHandler(this.cloneToBitBucketToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(152, 21);
            this.logOutToolStripMenuItem.Text = "Clone To BitBucket";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem1
            // 
            this.logOutToolStripMenuItem1.Name = "logOutToolStripMenuItem1";
            this.logOutToolStripMenuItem1.Size = new System.Drawing.Size(75, 21);
            this.logOutToolStripMenuItem1.Text = "Log Out";
            this.logOutToolStripMenuItem1.Click += new System.EventHandler(this.logOutToolStripMenuItem1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Maroon;
            this.panel5.Controls.Add(this.lblTotalFixed);
            this.panel5.Controls.Add(this.lblTotalBugResigter);
            this.panel5.Controls.Add(this.lbltmem);
            this.panel5.Controls.Add(this.lblTotalProject);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(142, 103);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1350, 287);
            this.panel5.TabIndex = 4;
            // 
            // lblTotalFixed
            // 
            this.lblTotalFixed.AutoSize = true;
            this.lblTotalFixed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFixed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalFixed.Location = new System.Drawing.Point(789, 147);
            this.lblTotalFixed.Name = "lblTotalFixed";
            this.lblTotalFixed.Size = new System.Drawing.Size(20, 23);
            this.lblTotalFixed.TabIndex = 8;
            this.lblTotalFixed.Text = "0";
            // 
            // lblTotalBugResigter
            // 
            this.lblTotalBugResigter.AutoSize = true;
            this.lblTotalBugResigter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBugResigter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalBugResigter.Location = new System.Drawing.Point(789, 73);
            this.lblTotalBugResigter.Name = "lblTotalBugResigter";
            this.lblTotalBugResigter.Size = new System.Drawing.Size(20, 23);
            this.lblTotalBugResigter.TabIndex = 7;
            this.lblTotalBugResigter.Text = "0";
            // 
            // lbltmem
            // 
            this.lbltmem.AutoSize = true;
            this.lbltmem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltmem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltmem.Location = new System.Drawing.Point(304, 147);
            this.lbltmem.Name = "lbltmem";
            this.lbltmem.Size = new System.Drawing.Size(20, 23);
            this.lbltmem.TabIndex = 6;
            this.lbltmem.Text = "0";
            // 
            // lblTotalProject
            // 
            this.lblTotalProject.AutoSize = true;
            this.lblTotalProject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalProject.Location = new System.Drawing.Point(304, 73);
            this.lblTotalProject.Name = "lblTotalProject";
            this.lblTotalProject.Size = new System.Drawing.Size(20, 23);
            this.lblTotalProject.TabIndex = 5;
            this.lblTotalProject.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(660, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Total Fixed :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Member :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Bug Resigter :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(141, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Project :";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1492, 794);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bug Tracking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManageUserRole;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button BtnClone;
        private System.Windows.Forms.Button btnBugHis;
        private System.Windows.Forms.Button btnBugSol;
        private System.Windows.Forms.Button btnNewbug;
        private System.Windows.Forms.Button btnProjectManage;
        private System.Windows.Forms.Button btnProjectMember;
        private System.Windows.Forms.Button btnManageMember;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageUserRoleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMemberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerNewBugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerBugSolutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cloneToBitBucketToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalFixed;
        private System.Windows.Forms.Label lblTotalBugResigter;
        private System.Windows.Forms.Label lbltmem;
        private System.Windows.Forms.Label lblTotalProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}