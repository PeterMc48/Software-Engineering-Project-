namespace KennelSys
{
    partial class FrmKennelEnquiry
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
            this.rabAll = new System.Windows.Forms.RadioButton();
            this.radAvailable = new System.Windows.Forms.RadioButton();
            this.radDecommissioned = new System.Windows.Forms.RadioButton();
            this.grdKennels = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mnuBack = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdKennels)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.Location = new System.Drawing.Point(307, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kennel Enquiry";
            // 
            // rabAll
            // 
            this.rabAll.AutoSize = true;
            this.rabAll.Checked = true;
            this.rabAll.Location = new System.Drawing.Point(193, 111);
            this.rabAll.Name = "rabAll";
            this.rabAll.Size = new System.Drawing.Size(36, 17);
            this.rabAll.TabIndex = 1;
            this.rabAll.TabStop = true;
            this.rabAll.Text = "All";
            this.rabAll.UseVisualStyleBackColor = true;
            this.rabAll.CheckedChanged += new System.EventHandler(this.rabAll_CheckedChanged);
            // 
            // radAvailable
            // 
            this.radAvailable.AutoSize = true;
            this.radAvailable.Location = new System.Drawing.Point(337, 111);
            this.radAvailable.Name = "radAvailable";
            this.radAvailable.Size = new System.Drawing.Size(68, 17);
            this.radAvailable.TabIndex = 2;
            this.radAvailable.Text = "Available";
            this.radAvailable.UseVisualStyleBackColor = true;
            this.radAvailable.CheckedChanged += new System.EventHandler(this.radAvailable_CheckedChanged);
            // 
            // radDecommissioned
            // 
            this.radDecommissioned.AutoSize = true;
            this.radDecommissioned.Location = new System.Drawing.Point(518, 111);
            this.radDecommissioned.Name = "radDecommissioned";
            this.radDecommissioned.Size = new System.Drawing.Size(105, 17);
            this.radDecommissioned.TabIndex = 3;
            this.radDecommissioned.Text = "Decommissioned";
            this.radDecommissioned.UseVisualStyleBackColor = true;
            this.radDecommissioned.CheckedChanged += new System.EventHandler(this.radDecommissioned_CheckedChanged);
            // 
            // grdKennels
            // 
            this.grdKennels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKennels.Location = new System.Drawing.Point(227, 166);
            this.grdKennels.Name = "grdKennels";
            this.grdKennels.Size = new System.Drawing.Size(328, 149);
            this.grdKennels.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBack});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mnuBack
            // 
            this.mnuBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.mnuBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(36, 22);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // FrmKennelEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grdKennels);
            this.Controls.Add(this.radDecommissioned);
            this.Controls.Add(this.radAvailable);
            this.Controls.Add(this.rabAll);
            this.Controls.Add(this.label1);
            this.Name = "FrmKennelEnquiry";
            this.Text = "KennelSYS-[KennelEnquiry]";
            this.Load += new System.EventHandler(this.FrmKennelEnquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdKennels)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rabAll;
        private System.Windows.Forms.RadioButton radAvailable;
        private System.Windows.Forms.RadioButton radDecommissioned;
        private System.Windows.Forms.DataGridView grdKennels;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton mnuBack;
    }
}