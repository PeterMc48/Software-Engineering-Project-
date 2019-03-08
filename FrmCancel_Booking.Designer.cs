namespace KennelSys
{
    partial class FrmCancel_Booking
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
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnConfirmCancel = new System.Windows.Forms.Button();
            this.mnuNavBar = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grdCustDetails = new System.Windows.Forms.DataGridView();
            this.mnuNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(166, 32);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(102, 13);
            this.lblsearch.TabIndex = 0;
            this.lblsearch.Text = "Customer last name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(283, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(283, 77);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(130, 32);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnConfirmCancel
            // 
            this.btnConfirmCancel.Location = new System.Drawing.Point(283, 392);
            this.btnConfirmCancel.Name = "btnConfirmCancel";
            this.btnConfirmCancel.Size = new System.Drawing.Size(130, 33);
            this.btnConfirmCancel.TabIndex = 8;
            this.btnConfirmCancel.Text = "Confirm";
            this.btnConfirmCancel.UseVisualStyleBackColor = true;
            this.btnConfirmCancel.Click += new System.EventHandler(this.btnConfirmCancel_Click);
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
            // grdCustDetails
            // 
            this.grdCustDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCustDetails.Location = new System.Drawing.Point(12, 131);
            this.grdCustDetails.Name = "grdCustDetails";
            this.grdCustDetails.Size = new System.Drawing.Size(776, 206);
            this.grdCustDetails.TabIndex = 11;
            this.grdCustDetails.Visible = false;
            // 
            // FrmCancel_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 649);
            this.Controls.Add(this.grdCustDetails);
            this.Controls.Add(this.mnuNavBar);
            this.Controls.Add(this.btnConfirmCancel);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblsearch);
            this.Name = "FrmCancel_Booking";
            this.Text = "KennelSYS-[CancelBooking]";
            this.mnuNavBar.ResumeLayout(false);
            this.mnuNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCustDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnConfirmCancel;
        private System.Windows.Forms.MenuStrip mnuNavBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DataGridView grdCustDetails;
    }
}