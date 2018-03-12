namespace Organization.Organization
{
    partial class FmOrganization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmOrganization));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblRecords = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblRecordValue = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvEmployeeInfo = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlBtnTableMode = new System.Windows.Forms.ToolStripButton();
            this.tscbEmployeeStatus = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dgvEmployeeInfo);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(539, 377);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(539, 424);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblRecords,
            this.tslblRecordValue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 0);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(539, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // tslblRecords
            // 
            this.tslblRecords.Name = "tslblRecords";
            this.tslblRecords.Size = new System.Drawing.Size(54, 17);
            this.tslblRecords.Text = "Записей:";
            // 
            // tslblRecordValue
            // 
            this.tslblRecordValue.Name = "tslblRecordValue";
            this.tslblRecordValue.Size = new System.Drawing.Size(13, 17);
            this.tslblRecordValue.Text = "0";
            // 
            // dgvEmployeeInfo
            // 
            this.dgvEmployeeInfo.AllowUserToAddRows = false;
            this.dgvEmployeeInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployeeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEmployeeInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployeeInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployeeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEmployeeInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvEmployeeInfo.Name = "dgvEmployeeInfo";
            this.dgvEmployeeInfo.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployeeInfo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployeeInfo.Size = new System.Drawing.Size(539, 377);
            this.dgvEmployeeInfo.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlBtnTableMode,
            this.tscbEmployeeStatus});
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(149, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // tlBtnTableMode
            // 
            this.tlBtnTableMode.CheckOnClick = true;
            this.tlBtnTableMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlBtnTableMode.Image = ((System.Drawing.Image)(resources.GetObject("tlBtnTableMode.Image")));
            this.tlBtnTableMode.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlBtnTableMode.Name = "tlBtnTableMode";
            this.tlBtnTableMode.Size = new System.Drawing.Size(23, 22);
            this.tlBtnTableMode.Text = "toolStripButton1";
            // 
            // tscbEmployeeStatus
            // 
            this.tscbEmployeeStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbEmployeeStatus.Name = "tscbEmployeeStatus";
            this.tscbEmployeeStatus.Size = new System.Drawing.Size(121, 25);
            this.tscbEmployeeStatus.Sorted = true;
            // 
            // FmOrganization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 424);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "FmOrganization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Организация";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeInfo)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblRecords;
        private System.Windows.Forms.ToolStripStatusLabel tslblRecordValue;
        private System.Windows.Forms.DataGridView dgvEmployeeInfo;
        private System.Windows.Forms.ToolStripButton tlBtnTableMode;
        private System.Windows.Forms.ToolStripComboBox tscbEmployeeStatus;
    }
}

