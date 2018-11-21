namespace MasterForm
{
    partial class BugHistory
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvBugHistory = new System.Windows.Forms.DataGridView();
            this.cmbBugHistory = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search History :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dgvBugHistory);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 296);
            this.panel2.TabIndex = 3;
            // 
            // dgvBugHistory
            // 
            this.dgvBugHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBugHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBugHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvBugHistory.Name = "dgvBugHistory";
            this.dgvBugHistory.Size = new System.Drawing.Size(796, 292);
            this.dgvBugHistory.TabIndex = 0;
            this.dgvBugHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBugHistory_CellClick);
            // 
            // cmbBugHistory
            // 
            this.cmbBugHistory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBugHistory.FormattingEnabled = true;
            this.cmbBugHistory.Location = new System.Drawing.Point(158, 107);
            this.cmbBugHistory.Name = "cmbBugHistory";
            this.cmbBugHistory.Size = new System.Drawing.Size(337, 24);
            this.cmbBugHistory.TabIndex = 4;
            this.cmbBugHistory.SelectedIndexChanged += new System.EventHandler(this.cmbBugHistory_SelectedIndexChanged);
            this.cmbBugHistory.TextChanged += new System.EventHandler(this.cmbBugHistory_TextChanged);
            // 
            // BugHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbBugHistory);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "BugHistory";
            this.Text = "BugHistory";
            this.Load += new System.EventHandler(this.BugHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBugHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvBugHistory;
        private System.Windows.Forms.ComboBox cmbBugHistory;
    }
}