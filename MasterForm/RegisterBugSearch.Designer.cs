namespace MasterForm
{
    partial class RegisterBugSearch
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBugSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBugSearch = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resigter Bug Search";
            // 
            // cmbBugSearch
            // 
            this.cmbBugSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBugSearch.FormattingEnabled = true;
            this.cmbBugSearch.Location = new System.Drawing.Point(148, 98);
            this.cmbBugSearch.Name = "cmbBugSearch";
            this.cmbBugSearch.Size = new System.Drawing.Size(339, 24);
            this.cmbBugSearch.TabIndex = 8;
            this.cmbBugSearch.SelectedIndexChanged += new System.EventHandler(this.cmbBugSearch_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Bug Search:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 79);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvBugSearch);
            this.panel2.Location = new System.Drawing.Point(12, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(839, 374);
            this.panel2.TabIndex = 9;
            // 
            // dgvBugSearch
            // 
            this.dgvBugSearch.AllowUserToAddRows = false;
            this.dgvBugSearch.AllowUserToDeleteRows = false;
            this.dgvBugSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBugSearch.Location = new System.Drawing.Point(0, 0);
            this.dgvBugSearch.Name = "dgvBugSearch";
            this.dgvBugSearch.ReadOnly = true;
            this.dgvBugSearch.RowTemplate.Height = 24;
            this.dgvBugSearch.Size = new System.Drawing.Size(839, 374);
            this.dgvBugSearch.TabIndex = 0;
            // 
            // RegisterBugSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 542);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbBugSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "RegisterBugSearch";
            this.Text = "RegisterBugSearch";
            this.Load += new System.EventHandler(this.RegisterBugSearch_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBugSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBugSearch;
    }
}