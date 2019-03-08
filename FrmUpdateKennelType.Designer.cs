namespace KennelSys
{
    partial class FrmUpdateKennelType
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
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpUpdateKennelType = new System.Windows.Forms.GroupBox();
            this.mnuNavBar = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.cboKennel_Type = new System.Windows.Forms.ComboBox();
            this.grpUpdateKennelType.SuspendLayout();
            this.mnuNavBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(26, 87);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Description:";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(56, 156);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(33, 13);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Rate:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(100, 84);
            this.txtDesc.MaxLength = 20;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 2;
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(100, 153);
            this.txtRate.MaxLength = 5;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(100, 211);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 34);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpUpdateKennelType
            // 
            this.grpUpdateKennelType.Controls.Add(this.lblDesc);
            this.grpUpdateKennelType.Controls.Add(this.btnUpdate);
            this.grpUpdateKennelType.Controls.Add(this.lblRate);
            this.grpUpdateKennelType.Controls.Add(this.txtRate);
            this.grpUpdateKennelType.Controls.Add(this.txtDesc);
            this.grpUpdateKennelType.Location = new System.Drawing.Point(43, 82);
            this.grpUpdateKennelType.Name = "grpUpdateKennelType";
            this.grpUpdateKennelType.Size = new System.Drawing.Size(260, 284);
            this.grpUpdateKennelType.TabIndex = 6;
            this.grpUpdateKennelType.TabStop = false;
            this.grpUpdateKennelType.Text = "Update Kennel Type";
            this.grpUpdateKennelType.Visible = false;
            this.grpUpdateKennelType.Enter += new System.EventHandler(this.grpUpdateKennelType_Enter);
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
            // cboKennel_Type
            // 
            this.cboKennel_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKennel_Type.FormattingEnabled = true;
            this.cboKennel_Type.Location = new System.Drawing.Point(43, 46);
            this.cboKennel_Type.Name = "cboKennel_Type";
            this.cboKennel_Type.Size = new System.Drawing.Size(121, 21);
            this.cboKennel_Type.TabIndex = 11;
            this.cboKennel_Type.SelectedIndexChanged += new System.EventHandler(this.cboKennel_Type_SelectedIndexChanged);
            // 
            // FrmUpdateKennelType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboKennel_Type);
            this.Controls.Add(this.mnuNavBar);
            this.Controls.Add(this.grpUpdateKennelType);
            this.Name = "FrmUpdateKennelType";
            this.Text = "KennelSYS-[UpdateKennelType]";
            this.Load += new System.EventHandler(this.FrmUpdateKennelType_Load);
            this.grpUpdateKennelType.ResumeLayout(false);
            this.grpUpdateKennelType.PerformLayout();
            this.mnuNavBar.ResumeLayout(false);
            this.mnuNavBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpUpdateKennelType;
        private System.Windows.Forms.MenuStrip mnuNavBar;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.ComboBox cboKennel_Type;
    }
}