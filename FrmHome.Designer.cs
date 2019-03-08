namespace KennelSys
{
    partial class FrmHome
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
            this.mnuNavBarar = new System.Windows.Forms.MenuStrip();
            this.mnuKennels = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTypeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddKennel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuremoveKennel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnukennelEnquiry = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubookings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnumakeBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnucancelBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.mnurecordArrival = new System.Windows.Forms.ToolStripMenuItem();
            this.mnurecordDeparture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuadmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnurevenueAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnukennelType = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuNavBarar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuNavBarar
            // 
            this.mnuNavBarar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKennels,
            this.mnubookings,
            this.mnuadmin});
            this.mnuNavBarar.Location = new System.Drawing.Point(0, 0);
            this.mnuNavBarar.Name = "mnuNavBarar";
            this.mnuNavBarar.Size = new System.Drawing.Size(800, 24);
            this.mnuNavBarar.TabIndex = 1;
            this.mnuNavBarar.Text = "menuStrip1";
            // 
            // mnuKennels
            // 
            this.mnuKennels.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTypeAdd,
            this.mnuUpdate,
            this.mnuAddKennel,
            this.mnuremoveKennel,
            this.mnukennelEnquiry});
            this.mnuKennels.Name = "mnuKennels";
            this.mnuKennels.Size = new System.Drawing.Size(60, 20);
            this.mnuKennels.Text = "Kennels";
            this.mnuKennels.Click += new System.EventHandler(this.mnuKennels_Click);
            // 
            // mnuTypeAdd
            // 
            this.mnuTypeAdd.Name = "mnuTypeAdd";
            this.mnuTypeAdd.Size = new System.Drawing.Size(180, 22);
            this.mnuTypeAdd.Text = "Add Kennel Type";
            this.mnuTypeAdd.Click += new System.EventHandler(this.mnuTypeAdd_Click);
            // 
            // mnuUpdate
            // 
            this.mnuUpdate.Name = "mnuUpdate";
            this.mnuUpdate.Size = new System.Drawing.Size(180, 22);
            this.mnuUpdate.Text = "UpDate Kennel Type";
            this.mnuUpdate.Click += new System.EventHandler(this.mnuUpdate_Click);
            // 
            // mnuAddKennel
            // 
            this.mnuAddKennel.Name = "mnuAddKennel";
            this.mnuAddKennel.Size = new System.Drawing.Size(180, 22);
            this.mnuAddKennel.Text = "Add Kennel";
            this.mnuAddKennel.Click += new System.EventHandler(this.mnuAddKennel_Click);
            // 
            // mnuremoveKennel
            // 
            this.mnuremoveKennel.Name = "mnuremoveKennel";
            this.mnuremoveKennel.Size = new System.Drawing.Size(180, 22);
            this.mnuremoveKennel.Text = "Remove Kennel";
            this.mnuremoveKennel.Click += new System.EventHandler(this.mnuremoveKennel_Click);
            // 
            // mnukennelEnquiry
            // 
            this.mnukennelEnquiry.Name = "mnukennelEnquiry";
            this.mnukennelEnquiry.Size = new System.Drawing.Size(180, 22);
            this.mnukennelEnquiry.Text = "Kennel Enquiry";
            this.mnukennelEnquiry.Click += new System.EventHandler(this.mnukennelEnquiry_Click);
            // 
            // mnubookings
            // 
            this.mnubookings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnumakeBooking,
            this.mnucancelBooking,
            this.mnurecordArrival,
            this.mnurecordDeparture});
            this.mnubookings.Name = "mnubookings";
            this.mnubookings.Size = new System.Drawing.Size(68, 20);
            this.mnubookings.Text = "Bookings";
            this.mnubookings.Click += new System.EventHandler(this.mnubookings_Click);
            // 
            // mnumakeBooking
            // 
            this.mnumakeBooking.Name = "mnumakeBooking";
            this.mnumakeBooking.Size = new System.Drawing.Size(166, 22);
            this.mnumakeBooking.Text = "Make Booking";
            this.mnumakeBooking.Click += new System.EventHandler(this.mnumakeBooking_Click);
            // 
            // mnucancelBooking
            // 
            this.mnucancelBooking.Name = "mnucancelBooking";
            this.mnucancelBooking.Size = new System.Drawing.Size(166, 22);
            this.mnucancelBooking.Text = "Cancel Booking";
            this.mnucancelBooking.Click += new System.EventHandler(this.mnucancelBooking_Click);
            // 
            // mnurecordArrival
            // 
            this.mnurecordArrival.Name = "mnurecordArrival";
            this.mnurecordArrival.Size = new System.Drawing.Size(166, 22);
            this.mnurecordArrival.Text = "Record Arrival";
            this.mnurecordArrival.Click += new System.EventHandler(this.mnurecordArrival_Click);
            // 
            // mnurecordDeparture
            // 
            this.mnurecordDeparture.Name = "mnurecordDeparture";
            this.mnurecordDeparture.Size = new System.Drawing.Size(166, 22);
            this.mnurecordDeparture.Text = "Record Departure";
            this.mnurecordDeparture.Click += new System.EventHandler(this.mnurecordDeparture_Click);
            // 
            // mnuadmin
            // 
            this.mnuadmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnurevenueAnalysis,
            this.mnukennelType});
            this.mnuadmin.Name = "mnuadmin";
            this.mnuadmin.Size = new System.Drawing.Size(55, 20);
            this.mnuadmin.Text = "Admin";
            // 
            // mnurevenueAnalysis
            // 
            this.mnurevenueAnalysis.Name = "mnurevenueAnalysis";
            this.mnurevenueAnalysis.Size = new System.Drawing.Size(184, 22);
            this.mnurevenueAnalysis.Text = "Revenue Analysis";
            this.mnurevenueAnalysis.Click += new System.EventHandler(this.mnurevenueAnalysis_Click);
            // 
            // mnukennelType
            // 
            this.mnukennelType.Name = "mnukennelType";
            this.mnukennelType.Size = new System.Drawing.Size(184, 22);
            this.mnukennelType.Text = "Kennel Type Analysis";
            this.mnukennelType.Click += new System.EventHandler(this.mnukennelType_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KennelSys.Properties.Resources.dog;
            this.pictureBox1.Location = new System.Drawing.Point(85, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 305);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuNavBarar);
            this.Name = "FrmHome";
            this.Text = "KennelSYS-[MainMenu]";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.mnuNavBarar.ResumeLayout(false);
            this.mnuNavBarar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuNavBarar;
        private System.Windows.Forms.ToolStripMenuItem mnuKennels;
        private System.Windows.Forms.ToolStripMenuItem mnuTypeAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdate;
        private System.Windows.Forms.ToolStripMenuItem mnuAddKennel;
        private System.Windows.Forms.ToolStripMenuItem mnuremoveKennel;
        private System.Windows.Forms.ToolStripMenuItem mnukennelEnquiry;
        private System.Windows.Forms.ToolStripMenuItem mnubookings;
        private System.Windows.Forms.ToolStripMenuItem mnumakeBooking;
        private System.Windows.Forms.ToolStripMenuItem mnucancelBooking;
        private System.Windows.Forms.ToolStripMenuItem mnurecordArrival;
        private System.Windows.Forms.ToolStripMenuItem mnurecordDeparture;
        private System.Windows.Forms.ToolStripMenuItem mnuadmin;
        private System.Windows.Forms.ToolStripMenuItem mnurevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnukennelType;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}