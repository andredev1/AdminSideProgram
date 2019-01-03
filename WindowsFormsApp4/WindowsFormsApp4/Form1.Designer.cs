namespace WindowsFormsApp4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fldidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldfirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldlastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldpersonalIDnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldosNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldosVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldbrowserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldbrowserVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldnavigatorUserAgentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldnavigatorAppVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldnavigatorPlatformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldnavigatorVendorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldlatitubeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldlongitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flddateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVchocDataSet = new WindowsFormsApp4.DVchocDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_ClockInTableAdapter = new WindowsFormsApp4.DVchocDataSetTableAdapters.tbl_ClockInTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVchocDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fldidDataGridViewTextBoxColumn,
            this.fldfirstNameDataGridViewTextBoxColumn,
            this.fldlastNameDataGridViewTextBoxColumn,
            this.fldpersonalIDnumberDataGridViewTextBoxColumn,
            this.fldosNameDataGridViewTextBoxColumn,
            this.fldosVersionDataGridViewTextBoxColumn,
            this.fldbrowserNameDataGridViewTextBoxColumn,
            this.fldbrowserVersionDataGridViewTextBoxColumn,
            this.fldnavigatorUserAgentDataGridViewTextBoxColumn,
            this.fldnavigatorAppVersionDataGridViewTextBoxColumn,
            this.fldnavigatorPlatformDataGridViewTextBoxColumn,
            this.fldnavigatorVendorDataGridViewTextBoxColumn,
            this.fldlatitubeDataGridViewTextBoxColumn,
            this.fldlongitudeDataGridViewTextBoxColumn,
            this.flddateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblClockInBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 380);
            this.dataGridView1.TabIndex = 0;
            // 
            // fldidDataGridViewTextBoxColumn
            // 
            this.fldidDataGridViewTextBoxColumn.DataPropertyName = "fld_id";
            this.fldidDataGridViewTextBoxColumn.HeaderText = "fld_id";
            this.fldidDataGridViewTextBoxColumn.Name = "fldidDataGridViewTextBoxColumn";
            this.fldidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fldfirstNameDataGridViewTextBoxColumn
            // 
            this.fldfirstNameDataGridViewTextBoxColumn.DataPropertyName = "fld_firstName";
            this.fldfirstNameDataGridViewTextBoxColumn.HeaderText = "fld_firstName";
            this.fldfirstNameDataGridViewTextBoxColumn.Name = "fldfirstNameDataGridViewTextBoxColumn";
            // 
            // fldlastNameDataGridViewTextBoxColumn
            // 
            this.fldlastNameDataGridViewTextBoxColumn.DataPropertyName = "fld_lastName";
            this.fldlastNameDataGridViewTextBoxColumn.HeaderText = "fld_lastName";
            this.fldlastNameDataGridViewTextBoxColumn.Name = "fldlastNameDataGridViewTextBoxColumn";
            // 
            // fldpersonalIDnumberDataGridViewTextBoxColumn
            // 
            this.fldpersonalIDnumberDataGridViewTextBoxColumn.DataPropertyName = "fld_personalIDnumber";
            this.fldpersonalIDnumberDataGridViewTextBoxColumn.HeaderText = "fld_personalIDnumber";
            this.fldpersonalIDnumberDataGridViewTextBoxColumn.Name = "fldpersonalIDnumberDataGridViewTextBoxColumn";
            // 
            // fldosNameDataGridViewTextBoxColumn
            // 
            this.fldosNameDataGridViewTextBoxColumn.DataPropertyName = "fld_osName";
            this.fldosNameDataGridViewTextBoxColumn.HeaderText = "fld_osName";
            this.fldosNameDataGridViewTextBoxColumn.Name = "fldosNameDataGridViewTextBoxColumn";
            // 
            // fldosVersionDataGridViewTextBoxColumn
            // 
            this.fldosVersionDataGridViewTextBoxColumn.DataPropertyName = "fld_osVersion";
            this.fldosVersionDataGridViewTextBoxColumn.HeaderText = "fld_osVersion";
            this.fldosVersionDataGridViewTextBoxColumn.Name = "fldosVersionDataGridViewTextBoxColumn";
            // 
            // fldbrowserNameDataGridViewTextBoxColumn
            // 
            this.fldbrowserNameDataGridViewTextBoxColumn.DataPropertyName = "fld_browserName";
            this.fldbrowserNameDataGridViewTextBoxColumn.HeaderText = "fld_browserName";
            this.fldbrowserNameDataGridViewTextBoxColumn.Name = "fldbrowserNameDataGridViewTextBoxColumn";
            // 
            // fldbrowserVersionDataGridViewTextBoxColumn
            // 
            this.fldbrowserVersionDataGridViewTextBoxColumn.DataPropertyName = "fld_browserVersion";
            this.fldbrowserVersionDataGridViewTextBoxColumn.HeaderText = "fld_browserVersion";
            this.fldbrowserVersionDataGridViewTextBoxColumn.Name = "fldbrowserVersionDataGridViewTextBoxColumn";
            // 
            // fldnavigatorUserAgentDataGridViewTextBoxColumn
            // 
            this.fldnavigatorUserAgentDataGridViewTextBoxColumn.DataPropertyName = "fld_navigatorUserAgent";
            this.fldnavigatorUserAgentDataGridViewTextBoxColumn.HeaderText = "fld_navigatorUserAgent";
            this.fldnavigatorUserAgentDataGridViewTextBoxColumn.Name = "fldnavigatorUserAgentDataGridViewTextBoxColumn";
            // 
            // fldnavigatorAppVersionDataGridViewTextBoxColumn
            // 
            this.fldnavigatorAppVersionDataGridViewTextBoxColumn.DataPropertyName = "fld_navigatorAppVersion";
            this.fldnavigatorAppVersionDataGridViewTextBoxColumn.HeaderText = "fld_navigatorAppVersion";
            this.fldnavigatorAppVersionDataGridViewTextBoxColumn.Name = "fldnavigatorAppVersionDataGridViewTextBoxColumn";
            // 
            // fldnavigatorPlatformDataGridViewTextBoxColumn
            // 
            this.fldnavigatorPlatformDataGridViewTextBoxColumn.DataPropertyName = "fld_navigatorPlatform";
            this.fldnavigatorPlatformDataGridViewTextBoxColumn.HeaderText = "fld_navigatorPlatform";
            this.fldnavigatorPlatformDataGridViewTextBoxColumn.Name = "fldnavigatorPlatformDataGridViewTextBoxColumn";
            // 
            // fldnavigatorVendorDataGridViewTextBoxColumn
            // 
            this.fldnavigatorVendorDataGridViewTextBoxColumn.DataPropertyName = "fld_navigatorVendor";
            this.fldnavigatorVendorDataGridViewTextBoxColumn.HeaderText = "fld_navigatorVendor";
            this.fldnavigatorVendorDataGridViewTextBoxColumn.Name = "fldnavigatorVendorDataGridViewTextBoxColumn";
            // 
            // fldlatitubeDataGridViewTextBoxColumn
            // 
            this.fldlatitubeDataGridViewTextBoxColumn.DataPropertyName = "fld_latitube";
            this.fldlatitubeDataGridViewTextBoxColumn.HeaderText = "fld_latitube";
            this.fldlatitubeDataGridViewTextBoxColumn.Name = "fldlatitubeDataGridViewTextBoxColumn";
            // 
            // fldlongitudeDataGridViewTextBoxColumn
            // 
            this.fldlongitudeDataGridViewTextBoxColumn.DataPropertyName = "fld_longitude";
            this.fldlongitudeDataGridViewTextBoxColumn.HeaderText = "fld_longitude";
            this.fldlongitudeDataGridViewTextBoxColumn.Name = "fldlongitudeDataGridViewTextBoxColumn";
            // 
            // flddateTimeDataGridViewTextBoxColumn
            // 
            this.flddateTimeDataGridViewTextBoxColumn.DataPropertyName = "fld_dateTime";
            this.flddateTimeDataGridViewTextBoxColumn.HeaderText = "fld_dateTime";
            this.flddateTimeDataGridViewTextBoxColumn.Name = "flddateTimeDataGridViewTextBoxColumn";
            // 
            // tblClockInBindingSource
            // 
            this.tblClockInBindingSource.DataMember = "tbl_ClockIn";
            this.tblClockInBindingSource.DataSource = this.dVchocDataSet;
            // 
            // dVchocDataSet
            // 
            this.dVchocDataSet.DataSetName = "DVchocDataSet";
            this.dVchocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Make an excel file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Clock In:";
            // 
            // tbl_ClockInTableAdapter
            // 
            this.tbl_ClockInTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Make an missing employee excel file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVchocDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private DVchocDataSet dVchocDataSet;
        private System.Windows.Forms.BindingSource tblClockInBindingSource;
        private DVchocDataSetTableAdapters.tbl_ClockInTableAdapter tbl_ClockInTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldfirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldpersonalIDnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldosNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldosVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldbrowserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldbrowserVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldnavigatorUserAgentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldnavigatorAppVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldnavigatorPlatformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldnavigatorVendorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlatitubeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlongitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flddateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}

