namespace KennelSys
{
    partial class FrmAdd_Kennel
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
            this.grpAddKennel = new System.Windows.Forms.GroupBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.txtKennelId = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cboKennelTypes = new System.Windows.Forms.ComboBox();
            this.mnuNavBar = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddKennel.SuspendLayout();
            this.mnuNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Kennel Id";
            // 
            // grpAddKennel
            // 
            this.grpAddKennel.Controls.Add(this.lblSelect);
            this.grpAddKennel.Controls.Add(this.txtKennelId);
            this.grpAddKennel.Controls.Add(this.btnConfirm);
            this.grpAddKennel.Controls.Add(this.cboKennelTypes);
            this.grpAddKennel.Controls.Add(this.lblID);
            this.grpAddKennel.Location = new System.Drawing.Point(202, 80);
            this.grpAddKennel.Name = "grpAddKennel";
            this.grpAddKennel.Size = new System.Drawing.Size(362, 272);
            this.grpAddKennel.TabIndex = 1;
            this.grpAddKennel.TabStop = false;
            this.grpAddKennel.Text = "Add Kennel";
            this.grpAddKennel.Enter += new System.EventHandler(this.grpAddKennel_Enter);
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(78, 70);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(141, 13);
            this.lblSelect.TabIndex = 3;
            this.lblSelect.Text = "Please Select Kennel Type!!";
            // 
            // txtKennelId
            // 
            this.txtKennelId.Enabled = false;
            this.txtKennelId.Location = new System.Drawing.Point(81, 16);
            this.txtKennelId.Name = "txtKennelId";
            this.txtKennelId.Size = new System.Drawing.Size(58, 20);
            this.txtKennelId.TabIndex = 2;
            this.txtKennelId.TextChanged += new System.EventHandler(this.txtKennelId_TextChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(67, 180);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(93, 39);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cboKennelTypes
            // 
            this.cboKennelTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKennelTypes.FormattingEnabled = true;
            this.cboKennelTypes.Location = new System.Drawing.Point(81, 95);
            this.cboKennelTypes.Name = "cboKennelTypes";
            this.cboKennelTypes.Size = new System.Drawing.Size(121, 21);
            this.cboKennelTypes.Sorted = true;
            this.cboKennelTypes.TabIndex = 1;
            this.cboKennelTypes.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mnuNavBar
            // 
            this.mnuNavBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuNavBar.Location = new System.Drawing.Point(0, 0);
            this.mnuNavBar.Name = "mnuNavBar";
            this.mnuNavBar.Size = new System.Drawing.Size(800, 24);
            this.mnuNavBar.TabIndex = 9;
            this.mnuNavBar.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // FrmAdd_Kennel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuNavBar);
            this.Controls.Add(this.grpAddKennel);
            this.Name = "FrmAdd_Kennel";
            this.Text = "KennelSYS-[AddKennel]";
            this.Load += new System.EventHandler(this.FrmAdd_Kennel_Load);
            this.grpAddKennel.ResumeLayout(false);
            this.grpAddKennel.PerformLayout();
            this.mnuNavBar.ResumeLayout(false);
            this.mnuNavBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.GroupBox grpAddKennel;
        private System.Windows.Forms.ComboBox cboKennelTypes;
        private System.Windows.Forms.TextBox txtKennelId;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.MenuStrip mnuNavBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Label lblSelect;
    }
}