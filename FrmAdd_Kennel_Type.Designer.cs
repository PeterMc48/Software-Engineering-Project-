namespace KennelSys
{
    partial class FrmAdd_Kennel_Type
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
            this.txtType = new System.Windows.Forms.TextBox();
            this.lblKennel_type = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.grpAddKennelType = new System.Windows.Forms.GroupBox();
            this.mnuTypeAdd = new System.Windows.Forms.MenuStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.grpAddKennelType.SuspendLayout();
            this.mnuTypeAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(94, 30);
            this.txtType.MaxLength = 4;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(40, 20);
            this.txtType.TabIndex = 1;
            // 
            // lblKennel_type
            // 
            this.lblKennel_type.AutoSize = true;
            this.lblKennel_type.Location = new System.Drawing.Point(-3, 33);
            this.lblKennel_type.Name = "lblKennel_type";
            this.lblKennel_type.Size = new System.Drawing.Size(70, 13);
            this.lblKennel_type.TabIndex = 2;
            this.lblKennel_type.Text = "Kennel Type:";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(94, 84);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 3;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(4, 87);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(63, 13);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Description:";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(94, 130);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 5;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(-2, 133);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(69, 13);
            this.lblRate.TabIndex = 6;
            this.lblRate.Text = "Kennel Rate:";
            // 
            // grpAddKennelType
            // 
            this.grpAddKennelType.Controls.Add(this.lblKennel_type);
            this.grpAddKennelType.Controls.Add(this.txtRate);
            this.grpAddKennelType.Controls.Add(this.lblRate);
            this.grpAddKennelType.Controls.Add(this.txtType);
            this.grpAddKennelType.Controls.Add(this.lblDesc);
            this.grpAddKennelType.Controls.Add(this.txtDesc);
            this.grpAddKennelType.Location = new System.Drawing.Point(178, 88);
            this.grpAddKennelType.Name = "grpAddKennelType";
            this.grpAddKennelType.Size = new System.Drawing.Size(245, 192);
            this.grpAddKennelType.TabIndex = 7;
            this.grpAddKennelType.TabStop = false;
            this.grpAddKennelType.Text = "Add Kennel Type";
            // 
            // mnuTypeAdd
            // 
            this.mnuTypeAdd.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.mnuTypeAdd.Location = new System.Drawing.Point(0, 0);
            this.mnuTypeAdd.Name = "mnuTypeAdd";
            this.mnuTypeAdd.Size = new System.Drawing.Size(800, 24);
            this.mnuTypeAdd.TabIndex = 8;
            this.mnuTypeAdd.Text = "menuStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(44, 20);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(272, 313);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 33);
            this.btnConfirm.TabIndex = 9;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FrmAdd_Kennel_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpAddKennelType);
            this.Controls.Add(this.mnuTypeAdd);
            this.MainMenuStrip = this.mnuTypeAdd;
            this.Name = "FrmAdd_Kennel_Type";
            this.Text = "KennelSYS-[AddKennelType]";
            this.grpAddKennelType.ResumeLayout(false);
            this.grpAddKennelType.PerformLayout();
            this.mnuTypeAdd.ResumeLayout(false);
            this.mnuTypeAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Label lblKennel_type;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.GroupBox grpAddKennelType;
        private System.Windows.Forms.MenuStrip mnuTypeAdd;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnConfirm;
    }
}