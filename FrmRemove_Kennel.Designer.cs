namespace KennelSys
{
    partial class FrmRemove_Kennel
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
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtKennelDetails = new System.Windows.Forms.TextBox();
            this.mnuNavBar = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpKennelDetails = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.mnuNavBar.SuspendLayout();
            this.grpKennelDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(182, 83);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(60, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Kennel ID: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(248, 80);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(59, 20);
            this.txtID.TabIndex = 1;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(45, 151);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(115, 23);
            this.btnupdate.TabIndex = 2;
            this.btnupdate.Text = "DECOMMISSION";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtKennelDetails
            // 
            this.txtKennelDetails.Enabled = false;
            this.txtKennelDetails.Location = new System.Drawing.Point(45, 38);
            this.txtKennelDetails.Multiline = true;
            this.txtKennelDetails.Name = "txtKennelDetails";
            this.txtKennelDetails.Size = new System.Drawing.Size(115, 77);
            this.txtKennelDetails.TabIndex = 3;
            this.txtKennelDetails.TextChanged += new System.EventHandler(this.txtKennelDetails_TextChanged);
            // 
            // mnuNavBar
            // 
            this.mnuNavBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuNavBar.Location = new System.Drawing.Point(0, 0);
            this.mnuNavBar.Name = "mnuNavBar";
            this.mnuNavBar.Size = new System.Drawing.Size(800, 24);
            this.mnuNavBar.TabIndex = 10;
            this.mnuNavBar.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpKennelDetails
            // 
            this.grpKennelDetails.Controls.Add(this.txtKennelDetails);
            this.grpKennelDetails.Controls.Add(this.btnupdate);
            this.grpKennelDetails.Location = new System.Drawing.Point(248, 143);
            this.grpKennelDetails.Name = "grpKennelDetails";
            this.grpKennelDetails.Size = new System.Drawing.Size(215, 219);
            this.grpKennelDetails.TabIndex = 11;
            this.grpKennelDetails.TabStop = false;
            this.grpKennelDetails.Text = "Kennel Details";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(354, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmRemove_Kennel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.grpKennelDetails);
            this.Controls.Add(this.mnuNavBar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "FrmRemove_Kennel";
            this.Text = "KennelSYS-[RemoveKennel]";
            this.Load += new System.EventHandler(this.FrmRemove_Kennel_Load);
            this.mnuNavBar.ResumeLayout(false);
            this.mnuNavBar.PerformLayout();
            this.grpKennelDetails.ResumeLayout(false);
            this.grpKennelDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtKennelDetails;
        private System.Windows.Forms.MenuStrip mnuNavBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpKennelDetails;
        private System.Windows.Forms.Button btnSearch;
    }
}