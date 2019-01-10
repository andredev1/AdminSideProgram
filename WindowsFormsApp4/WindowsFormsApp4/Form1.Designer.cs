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
            this.tblClockInBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dVchocDataSet = new WindowsFormsApp4.DVchocDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbl_ClockInTableAdapter = new WindowsFormsApp4.DVchocDataSetTableAdapters.tbl_ClockInTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.dVchocDataSet1 = new WindowsFormsApp4.DVchocDataSet1();
            this.tblClockInBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ClockInTableAdapter1 = new WindowsFormsApp4.DVchocDataSet1TableAdapters.tbl_ClockInTableAdapter();
            this.flddateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldlongitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldlatitudeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldbrowserVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldbrowserNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldosVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldosNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldpersonalIDnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldlastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fldfirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockInBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVchocDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVchocDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockInBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.button1.Text = "Big list";
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
            this.button2.Size = new System.Drawing.Size(180, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "DV pods clock in list";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dVchocDataSet1
            // 
            this.dVchocDataSet1.DataSetName = "DVchocDataSet1";
            this.dVchocDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblClockInBindingSource1
            // 
            this.tblClockInBindingSource1.DataMember = "tbl_ClockIn";
            this.tblClockInBindingSource1.DataSource = this.dVchocDataSet1;
            // 
            // tbl_ClockInTableAdapter1
            // 
            this.tbl_ClockInTableAdapter1.ClearBeforeFill = true;
            // 
            // flddateTimeDataGridViewTextBoxColumn
            // 
            this.flddateTimeDataGridViewTextBoxColumn.DataPropertyName = "fld_dateTime";
            this.flddateTimeDataGridViewTextBoxColumn.HeaderText = "fld_dateTime";
            this.flddateTimeDataGridViewTextBoxColumn.Name = "flddateTimeDataGridViewTextBoxColumn";
            // 
            // fldlongitudeDataGridViewTextBoxColumn
            // 
            this.fldlongitudeDataGridViewTextBoxColumn.DataPropertyName = "fld_longitude";
            this.fldlongitudeDataGridViewTextBoxColumn.HeaderText = "fld_longitude";
            this.fldlongitudeDataGridViewTextBoxColumn.Name = "fldlongitudeDataGridViewTextBoxColumn";
            // 
            // fldlatitudeDataGridViewTextBoxColumn
            // 
            this.fldlatitudeDataGridViewTextBoxColumn.DataPropertyName = "fld_latitude";
            this.fldlatitudeDataGridViewTextBoxColumn.HeaderText = "fld_latitude";
            this.fldlatitudeDataGridViewTextBoxColumn.Name = "fldlatitudeDataGridViewTextBoxColumn";
            // 
            // fldbrowserVersionDataGridViewTextBoxColumn
            // 
            this.fldbrowserVersionDataGridViewTextBoxColumn.DataPropertyName = "fld_browserVersion";
            this.fldbrowserVersionDataGridViewTextBoxColumn.HeaderText = "fld_browserVersion";
            this.fldbrowserVersionDataGridViewTextBoxColumn.Name = "fldbrowserVersionDataGridViewTextBoxColumn";
            // 
            // fldbrowserNameDataGridViewTextBoxColumn
            // 
            this.fldbrowserNameDataGridViewTextBoxColumn.DataPropertyName = "fld_browserName";
            this.fldbrowserNameDataGridViewTextBoxColumn.HeaderText = "fld_browserName";
            this.fldbrowserNameDataGridViewTextBoxColumn.Name = "fldbrowserNameDataGridViewTextBoxColumn";
            // 
            // fldosVersionDataGridViewTextBoxColumn
            // 
            this.fldosVersionDataGridViewTextBoxColumn.DataPropertyName = "fld_osVersion";
            this.fldosVersionDataGridViewTextBoxColumn.HeaderText = "fld_osVersion";
            this.fldosVersionDataGridViewTextBoxColumn.Name = "fldosVersionDataGridViewTextBoxColumn";
            // 
            // fldosNameDataGridViewTextBoxColumn
            // 
            this.fldosNameDataGridViewTextBoxColumn.DataPropertyName = "fld_osName";
            this.fldosNameDataGridViewTextBoxColumn.HeaderText = "fld_osName";
            this.fldosNameDataGridViewTextBoxColumn.Name = "fldosNameDataGridViewTextBoxColumn";
            // 
            // fldpersonalIDnumberDataGridViewTextBoxColumn
            // 
            this.fldpersonalIDnumberDataGridViewTextBoxColumn.DataPropertyName = "fld_personalIDnumber";
            this.fldpersonalIDnumberDataGridViewTextBoxColumn.HeaderText = "fld_personalIDnumber";
            this.fldpersonalIDnumberDataGridViewTextBoxColumn.Name = "fldpersonalIDnumberDataGridViewTextBoxColumn";
            // 
            // fldlastNameDataGridViewTextBoxColumn
            // 
            this.fldlastNameDataGridViewTextBoxColumn.DataPropertyName = "fld_lastName";
            this.fldlastNameDataGridViewTextBoxColumn.HeaderText = "fld_lastName";
            this.fldlastNameDataGridViewTextBoxColumn.Name = "fldlastNameDataGridViewTextBoxColumn";
            // 
            // fldfirstNameDataGridViewTextBoxColumn
            // 
            this.fldfirstNameDataGridViewTextBoxColumn.DataPropertyName = "fld_firstName";
            this.fldfirstNameDataGridViewTextBoxColumn.HeaderText = "fld_firstName";
            this.fldfirstNameDataGridViewTextBoxColumn.Name = "fldfirstNameDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fldfirstNameDataGridViewTextBoxColumn,
            this.fldlastNameDataGridViewTextBoxColumn,
            this.fldpersonalIDnumberDataGridViewTextBoxColumn,
            this.fldosNameDataGridViewTextBoxColumn,
            this.fldosVersionDataGridViewTextBoxColumn,
            this.fldbrowserNameDataGridViewTextBoxColumn,
            this.fldbrowserVersionDataGridViewTextBoxColumn,
            this.fldlatitudeDataGridViewTextBoxColumn,
            this.fldlongitudeDataGridViewTextBoxColumn,
            this.flddateTimeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblClockInBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(972, 380);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblClockInBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVchocDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVchocDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClockInBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private DVchocDataSet dVchocDataSet;
        private System.Windows.Forms.BindingSource tblClockInBindingSource;
        private DVchocDataSetTableAdapters.tbl_ClockInTableAdapter tbl_ClockInTableAdapter;
        private System.Windows.Forms.Button button2;
        private DVchocDataSet1 dVchocDataSet1;
        private System.Windows.Forms.BindingSource tblClockInBindingSource1;
        private DVchocDataSet1TableAdapters.tbl_ClockInTableAdapter tbl_ClockInTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn flddateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlongitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlatitudeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldbrowserVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldbrowserNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldosVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldosNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldpersonalIDnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldlastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fldfirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

