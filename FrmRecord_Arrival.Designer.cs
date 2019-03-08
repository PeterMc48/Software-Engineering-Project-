namespace KennelSys
{
    partial class FrmRecord_Arrival
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
            this.lblSearchLastName = new System.Windows.Forms.Label();
            this.txtSearchLastName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpBookingDetails = new System.Windows.Forms.GroupBox();
            this.grdCustDetails = new System.Windows.Forms.DataGridView();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.mnuNavBar = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBookingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustDetails)).BeginInit();
            this.mnuNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSearchLastName
            // 
            this.lblSearchLastName.AutoSize = true;
            this.lblSearchLastName.Location = new System.Drawing.Point(220, 61);
            this.lblSearchLastName.Name = "lblSearchLastName";
            this.lblSearchLastName.Size = new System.Drawing.Size(61, 13);
            this.lblSearchLastName.TabIndex = 0;
            this.lblSearchLastName.Text = "Last Name:";
            // 
            // txtSearchLastName
            // 
            this.txtSearchLastName.Location = new System.Drawing.Point(309, 58);
            this.txtSearchLastName.Name = "txtSearchLastName";
            this.txtSearchLastName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchLastName.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(309, 106);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grpBookingDetails
            // 
            this.grpBookingDetails.Controls.Add(this.grdCustDetails);
            this.grpBookingDetails.Controls.Add(this.btnConfirm);
            this.grpBookingDetails.Location = new System.Drawing.Point(61, 158);
            this.grpBookingDetails.Name = "grpBookingDetails";
            this.grpBookingDetails.Size = new System.Drawing.Size(622, 236);
            this.grpBookingDetails.TabIndex = 4;
            this.grpBookingDetails.TabStop = false;
            this.grpBookingDetails.Text = "Last Name";
            this.grpBookingDetails.Visible = false;
            // 
            // grdCustDetails
            // 
            this.grdCustDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustDetails.Location = new System.Drawing.Point(6, 30);
            this.grdCustDetails.Name = "grdCustDetails";
            this.grdCustDetails.Size = new System.Drawing.Size(587, 150);
            this.grdCustDetails.TabIndex = 7;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(248, 197);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 23);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            // FrmRecord_Arrival
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 689);
            this.Controls.Add(this.mnuNavBar);
            this.Controls.Add(this.grpBookingDetails);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchLastName);
            this.Controls.Add(this.lblSearchLastName);
            this.Name = "FrmRecord_Arrival";
            this.Text = "KennelSYS-[RecordArrival]";
            this.grpBookingDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdCustDetails)).EndInit();
            this.mnuNavBar.ResumeLayout(false);
            this.mnuNavBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchLastName;
        private System.Windows.Forms.TextBox txtSearchLastName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpBookingDetails;
        private System.Windows.Forms.MenuStrip mnuNavBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView grdCustDetails;
    }
}