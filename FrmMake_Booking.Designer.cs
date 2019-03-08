namespace KennelSys
{
    partial class FrmMake_Booking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpmake = new System.Windows.Forms.GroupBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookingID = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpDeparture = new System.Windows.Forms.DateTimePicker();
            this.dtpArrival = new System.Windows.Forms.DateTimePicker();
            this.cboKennelTypes = new System.Windows.Forms.ComboBox();
            this.mnuNavBar = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAvailableKennels = new System.Windows.Forms.GroupBox();
            this.btnPickedKennel = new System.Windows.Forms.Button();
            this.grdAvailableKennels = new System.Windows.Forms.DataGridView();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtDogName = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.lblDogName = new System.Windows.Forms.Label();
            this.lblDogBreed = new System.Windows.Forms.Label();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpmake.SuspendLayout();
            this.mnuNavBar.SuspendLayout();
            this.grpAvailableKennels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableKennels)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpmake
            // 
            this.grpmake.Controls.Add(this.lblSelect);
            this.grpmake.Controls.Add(this.label1);
            this.grpmake.Controls.Add(this.txtBookingID);
            this.grpmake.Controls.Add(this.btnConfirm);
            this.grpmake.Controls.Add(this.lblTo);
            this.grpmake.Controls.Add(this.lblFrom);
            this.grpmake.Controls.Add(this.dtpDeparture);
            this.grpmake.Controls.Add(this.dtpArrival);
            this.grpmake.Controls.Add(this.cboKennelTypes);
            this.grpmake.Location = new System.Drawing.Point(124, 36);
            this.grpmake.Name = "grpmake";
            this.grpmake.Size = new System.Drawing.Size(467, 293);
            this.grpmake.TabIndex = 0;
            this.grpmake.TabStop = false;
            this.grpmake.Text = "Make Booking";
            this.grpmake.Enter += new System.EventHandler(this.grpmake_Enter);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(40, 55);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(135, 13);
            this.lblSelect.TabIndex = 8;
            this.lblSelect.Text = "Please Select Kennel Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Booking ID";
            // 
            // txtBookingID
            // 
            this.txtBookingID.Enabled = false;
            this.txtBookingID.Location = new System.Drawing.Point(366, 19);
            this.txtBookingID.Name = "txtBookingID";
            this.txtBookingID.Size = new System.Drawing.Size(68, 20);
            this.txtBookingID.TabIndex = 6;
            this.txtBookingID.TextChanged += new System.EventHandler(this.txtBookingID_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(181, 248);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(121, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.Confirm_btn_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(103, 175);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 13);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(100, 113);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(30, 13);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "From";
            // 
            // dtpDeparture
            // 
            this.dtpDeparture.Location = new System.Drawing.Point(181, 175);
            this.dtpDeparture.MinDate = new System.DateTime(2019, 3, 5, 0, 0, 0, 0);
            this.dtpDeparture.Name = "dtpDeparture";
            this.dtpDeparture.Size = new System.Drawing.Size(200, 20);
            this.dtpDeparture.TabIndex = 2;
            // 
            // dtpArrival
            // 
            this.dtpArrival.Location = new System.Drawing.Point(181, 113);
            this.dtpArrival.MinDate = new System.DateTime(2019, 3, 5, 0, 0, 0, 0);
            this.dtpArrival.Name = "dtpArrival";
            this.dtpArrival.Size = new System.Drawing.Size(200, 20);
            this.dtpArrival.TabIndex = 1;
            // 
            // cboKennelTypes
            // 
            this.cboKennelTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKennelTypes.FormattingEnabled = true;
            this.cboKennelTypes.Location = new System.Drawing.Point(181, 52);
            this.cboKennelTypes.Name = "cboKennelTypes";
            this.cboKennelTypes.Size = new System.Drawing.Size(121, 21);
            this.cboKennelTypes.TabIndex = 0;
            this.cboKennelTypes.SelectedIndexChanged += new System.EventHandler(this.cboKennelTypes_SelectedIndexChanged);
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
            // grpAvailableKennels
            // 
            this.grpAvailableKennels.Controls.Add(this.btnPickedKennel);
            this.grpAvailableKennels.Controls.Add(this.grdAvailableKennels);
            this.grpAvailableKennels.Location = new System.Drawing.Point(124, 335);
            this.grpAvailableKennels.Name = "grpAvailableKennels";
            this.grpAvailableKennels.Size = new System.Drawing.Size(467, 177);
            this.grpAvailableKennels.TabIndex = 11;
            this.grpAvailableKennels.TabStop = false;
            this.grpAvailableKennels.Text = "Available Kennels";
            this.grpAvailableKennels.Visible = false;
            // 
            // btnPickedKennel
            // 
            this.btnPickedKennel.Location = new System.Drawing.Point(181, 142);
            this.btnPickedKennel.Name = "btnPickedKennel";
            this.btnPickedKennel.Size = new System.Drawing.Size(121, 23);
            this.btnPickedKennel.TabIndex = 1;
            this.btnPickedKennel.Text = "Confirm";
            this.btnPickedKennel.UseVisualStyleBackColor = true;
            this.btnPickedKennel.Click += new System.EventHandler(this.btnPickedKennel_Click);
            // 
            // grdAvailableKennels
            // 
            this.grdAvailableKennels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAvailableKennels.DefaultCellStyle = dataGridViewCellStyle7;
            this.grdAvailableKennels.Location = new System.Drawing.Point(74, 19);
            this.grdAvailableKennels.Name = "grdAvailableKennels";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.grdAvailableKennels.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.grdAvailableKennels.Size = new System.Drawing.Size(339, 81);
            this.grdAvailableKennels.TabIndex = 0;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnConfirmBooking);
            this.grpInfo.Controls.Add(this.txtEmail);
            this.grpInfo.Controls.Add(this.lblEmail);
            this.grpInfo.Controls.Add(this.txtDogName);
            this.grpInfo.Controls.Add(this.txtInfo);
            this.grpInfo.Controls.Add(this.lblInfo);
            this.grpInfo.Controls.Add(this.txtBreed);
            this.grpInfo.Controls.Add(this.lblDogName);
            this.grpInfo.Controls.Add(this.lblDogBreed);
            this.grpInfo.Controls.Add(this.txtPhoneNo);
            this.grpInfo.Controls.Add(this.txtLastName);
            this.grpInfo.Controls.Add(this.txtFirstName);
            this.grpInfo.Controls.Add(this.lbl);
            this.grpInfo.Controls.Add(this.txtCost);
            this.grpInfo.Controls.Add(this.lblLastName);
            this.grpInfo.Controls.Add(this.lblCost);
            this.grpInfo.Controls.Add(this.lblFirstName);
            this.grpInfo.Location = new System.Drawing.Point(124, 518);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(467, 352);
            this.grpInfo.TabIndex = 12;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Info";
            this.grpInfo.Visible = false;
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(152, 303);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(150, 32);
            this.btnConfirmBooking.TabIndex = 23;
            this.btnConfirmBooking.Text = "Confirm";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(117, 129);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 19;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email:";
            // 
            // txtDogName
            // 
            this.txtDogName.Location = new System.Drawing.Point(117, 181);
            this.txtDogName.MaxLength = 20;
            this.txtDogName.Name = "txtDogName";
            this.txtDogName.Size = new System.Drawing.Size(100, 20);
            this.txtDogName.TabIndex = 21;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(117, 211);
            this.txtInfo.MaxLength = 30;
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(214, 72);
            this.txtInfo.TabIndex = 22;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(42, 214);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(56, 13);
            this.lblInfo.TabIndex = 22;
            this.lblInfo.Text = "Info(if any)";
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(117, 155);
            this.txtBreed.MaxLength = 20;
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.Size = new System.Drawing.Size(100, 20);
            this.txtBreed.TabIndex = 20;
            // 
            // lblDogName
            // 
            this.lblDogName.AutoSize = true;
            this.lblDogName.Location = new System.Drawing.Point(41, 184);
            this.lblDogName.Name = "lblDogName";
            this.lblDogName.Size = new System.Drawing.Size(70, 13);
            this.lblDogName.TabIndex = 21;
            this.lblDogName.Text = "Name ofDog:";
            // 
            // lblDogBreed
            // 
            this.lblDogBreed.AutoSize = true;
            this.lblDogBreed.Location = new System.Drawing.Point(42, 158);
            this.lblDogBreed.Name = "lblDogBreed";
            this.lblDogBreed.Size = new System.Drawing.Size(41, 13);
            this.lblDogBreed.TabIndex = 20;
            this.lblDogBreed.Text = "Breed: ";
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(117, 103);
            this.txtPhoneNo.MaxLength = 15;
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNo.TabIndex = 18;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(117, 77);
            this.txtLastName.MaxLength = 30;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(117, 53);
            this.txtFirstName.MaxLength = 20;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 16;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(40, 106);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(55, 13);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "PhoneNo:";
            // 
            // txtCost
            // 
            this.txtCost.Enabled = false;
            this.txtCost.Location = new System.Drawing.Point(334, 13);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(79, 20);
            this.txtCost.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(40, 80);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 14;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(300, 16);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(31, 13);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Cost:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(40, 56);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "First Name:";
            // 
            // FrmMake_Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 882);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpAvailableKennels);
            this.Controls.Add(this.mnuNavBar);
            this.Controls.Add(this.grpmake);
            this.Name = "FrmMake_Booking";
            this.Text = "KennelSYS-[Make Booking]";
            this.Load += new System.EventHandler(this.FrmMake_Booking_Load);
            this.grpmake.ResumeLayout(false);
            this.grpmake.PerformLayout();
            this.mnuNavBar.ResumeLayout(false);
            this.mnuNavBar.PerformLayout();
            this.grpAvailableKennels.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdAvailableKennels)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpmake;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpDeparture;
        private System.Windows.Forms.DateTimePicker dtpArrival;
        private System.Windows.Forms.ComboBox cboKennelTypes;
        private System.Windows.Forms.MenuStrip mnuNavBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookingID;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.GroupBox grpAvailableKennels;
        private System.Windows.Forms.Button btnPickedKennel;
        private System.Windows.Forms.DataGridView grdAvailableKennels;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtDogName;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.Label lblDogName;
        private System.Windows.Forms.Label lblDogBreed;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnConfirmBooking;
    }
}