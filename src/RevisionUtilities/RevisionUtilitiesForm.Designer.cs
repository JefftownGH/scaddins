﻿namespace SCaddins.RevisionUtilities
{
    partial class RevisionUtilitiesForm
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
            if (disposing && (components != null)) {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevisionUtilitiesForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonSelectNone = new System.Windows.Forms.Button();
            this.buttonScheduleRevisions = new System.Windows.Forms.Button();
            this.labelDataGridTitle = new System.Windows.Forms.Label();
            this.buttonAssignRevisons = new System.Windows.Forms.Button();
            this.buttonDeleteRevisions = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonClouds = new System.Windows.Forms.RadioButton();
            this.radioButtonRevisions = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 30);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(541, 448);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectAll.Location = new System.Drawing.Point(559, 304);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(161, 23);
            this.buttonSelectAll.TabIndex = 1;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.ButtonSelectAll_Click);
            // 
            // buttonSelectNone
            // 
            this.buttonSelectNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectNone.Location = new System.Drawing.Point(559, 333);
            this.buttonSelectNone.Name = "buttonSelectNone";
            this.buttonSelectNone.Size = new System.Drawing.Size(161, 23);
            this.buttonSelectNone.TabIndex = 2;
            this.buttonSelectNone.Text = "Select None";
            this.buttonSelectNone.UseVisualStyleBackColor = true;
            this.buttonSelectNone.Click += new System.EventHandler(this.ButtonSelectNone_Click);
            // 
            // buttonScheduleRevisions
            // 
            this.buttonScheduleRevisions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonScheduleRevisions.Location = new System.Drawing.Point(559, 455);
            this.buttonScheduleRevisions.Name = "buttonScheduleRevisions";
            this.buttonScheduleRevisions.Size = new System.Drawing.Size(160, 23);
            this.buttonScheduleRevisions.TabIndex = 3;
            this.buttonScheduleRevisions.Text = "Schedule Revision Clouds(s)";
            this.buttonScheduleRevisions.UseVisualStyleBackColor = true;
            this.buttonScheduleRevisions.Click += new System.EventHandler(this.ButtonScheduleRevisionsClick);
            // 
            // labelDataGridTitle
            // 
            this.labelDataGridTitle.Location = new System.Drawing.Point(12, 9);
            this.labelDataGridTitle.Name = "labelDataGridTitle";
            this.labelDataGridTitle.Size = new System.Drawing.Size(304, 18);
            this.labelDataGridTitle.TabIndex = 4;
            this.labelDataGridTitle.Text = "Choose Revision ";
            // 
            // buttonAssignRevisons
            // 
            this.buttonAssignRevisons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAssignRevisons.Enabled = false;
            this.buttonAssignRevisons.Location = new System.Drawing.Point(559, 426);
            this.buttonAssignRevisons.Name = "buttonAssignRevisons";
            this.buttonAssignRevisons.Size = new System.Drawing.Size(160, 23);
            this.buttonAssignRevisons.TabIndex = 6;
            this.buttonAssignRevisons.Text = "Assign Revision to Cloud(s)";
            this.buttonAssignRevisons.UseVisualStyleBackColor = true;
            this.buttonAssignRevisons.Click += new System.EventHandler(this.ButtonAssignRevisionsClick);
            // 
            // buttonDeleteRevisions
            // 
            this.buttonDeleteRevisions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteRevisions.Enabled = false;
            this.buttonDeleteRevisions.Location = new System.Drawing.Point(559, 397);
            this.buttonDeleteRevisions.Name = "buttonDeleteRevisions";
            this.buttonDeleteRevisions.Size = new System.Drawing.Size(160, 23);
            this.buttonDeleteRevisions.TabIndex = 7;
            this.buttonDeleteRevisions.Text = "Delete Revision Clouds(s)";
            this.buttonDeleteRevisions.UseVisualStyleBackColor = true;
            this.buttonDeleteRevisions.Click += new System.EventHandler(this.ButtonDeleteRevisionsClick);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.xls";
            this.saveFileDialog1.FileName = "ExportedClouds";
            this.saveFileDialog1.Filter = "Excel File|*.xls";
            this.saveFileDialog1.SupportMultiDottedExtensions = true;
            this.saveFileDialog1.Title = "Select Excel file name to export to";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.radioButtonClouds);
            this.groupBox1.Controls.Add(this.radioButtonRevisions);
            this.groupBox1.Location = new System.Drawing.Point(559, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 88);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Options";
            // 
            // radioButtonClouds
            // 
            this.radioButtonClouds.Location = new System.Drawing.Point(6, 49);
            this.radioButtonClouds.Name = "radioButtonClouds";
            this.radioButtonClouds.Size = new System.Drawing.Size(104, 24);
            this.radioButtonClouds.TabIndex = 1;
            this.radioButtonClouds.Text = "Display Clouds";
            this.radioButtonClouds.UseVisualStyleBackColor = true;
            this.radioButtonClouds.CheckedChanged += new System.EventHandler(this.RadioButtonCloudsCheckedChanged);
            // 
            // radioButtonRevisions
            // 
            this.radioButtonRevisions.Checked = true;
            this.radioButtonRevisions.Location = new System.Drawing.Point(6, 19);
            this.radioButtonRevisions.Name = "radioButtonRevisions";
            this.radioButtonRevisions.Size = new System.Drawing.Size(149, 24);
            this.radioButtonRevisions.TabIndex = 0;
            this.radioButtonRevisions.TabStop = true;
            this.radioButtonRevisions.Text = "Display Revisions";
            this.radioButtonRevisions.UseVisualStyleBackColor = true;
            this.radioButtonRevisions.CheckedChanged += new System.EventHandler(this.RadioButtonRevisionsCheckedChanged);
            // 
            // RevisionUtilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonDeleteRevisions);
            this.Controls.Add(this.buttonAssignRevisons);
            this.Controls.Add(this.labelDataGridTitle);
            this.Controls.Add(this.buttonScheduleRevisions);
            this.Controls.Add(this.buttonSelectNone);
            this.Controls.Add(this.buttonSelectAll);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RevisionUtilitiesForm";
            this.Text = "(SC) Cloud Scheduler";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonSelectNone;
        private System.Windows.Forms.Button buttonScheduleRevisions;
        private System.Windows.Forms.Label labelDataGridTitle;
        private System.Windows.Forms.Button buttonAssignRevisons;
        private System.Windows.Forms.Button buttonDeleteRevisions;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonClouds;
        private System.Windows.Forms.RadioButton radioButtonRevisions;

    }
}