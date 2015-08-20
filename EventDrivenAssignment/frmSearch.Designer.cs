namespace EventDrivenAssignment
{
    partial class frmSearch
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
            this.tblCarDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet = new EventDrivenAssignment.HireDataSet();
            this.searchGroupBox1 = new System.Windows.Forms.GroupBox();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.fieldLabel = new System.Windows.Forms.Label();
            this.cboOperator = new System.Windows.Forms.ComboBox();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.columnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tblCarTableAdapter = new EventDrivenAssignment.HireDataSetTableAdapters.tblCarTableAdapter();
            this.tableAdapterManager = new EventDrivenAssignment.HireDataSetTableAdapters.TableAdapterManager();
            this.tblCarBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblCarDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            this.searchGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCarDataGridView
            // 
            this.tblCarDataGridView.AutoGenerateColumns = false;
            this.tblCarDataGridView.BackgroundColor = System.Drawing.Color.Honeydew;
            this.tblCarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCarDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1});
            this.tblCarDataGridView.DataSource = this.tblCarBindingSource;
            this.tblCarDataGridView.Location = new System.Drawing.Point(12, 171);
            this.tblCarDataGridView.Name = "tblCarDataGridView";
            this.tblCarDataGridView.Size = new System.Drawing.Size(665, 155);
            this.tblCarDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "VehicleRegNo";
            this.dataGridViewTextBoxColumn1.HeaderText = "VehicleRegNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Make";
            this.dataGridViewTextBoxColumn2.HeaderText = "Make";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EngineSize";
            this.dataGridViewTextBoxColumn3.HeaderText = "EngineSize";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DateRegistered";
            this.dataGridViewTextBoxColumn4.HeaderText = "DateRegistered";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RentalPerDay";
            this.dataGridViewTextBoxColumn5.HeaderText = "RentalPerDay";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Available";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Available";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // tblCarBindingSource
            // 
            this.tblCarBindingSource.DataMember = "tblCar";
            this.tblCarBindingSource.DataSource = this.hireDataSet;
            // 
            // hireDataSet
            // 
            this.hireDataSet.DataSetName = "HireDataSet";
            this.hireDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchGroupBox1
            // 
            this.searchGroupBox1.Controls.Add(this.valueTextBox);
            this.searchGroupBox1.Controls.Add(this.operatorLabel);
            this.searchGroupBox1.Controls.Add(this.valueLabel);
            this.searchGroupBox1.Controls.Add(this.fieldLabel);
            this.searchGroupBox1.Controls.Add(this.cboOperator);
            this.searchGroupBox1.Controls.Add(this.cboField);
            this.searchGroupBox1.Location = new System.Drawing.Point(24, 29);
            this.searchGroupBox1.Name = "searchGroupBox1";
            this.searchGroupBox1.Size = new System.Drawing.Size(449, 100);
            this.searchGroupBox1.TabIndex = 2;
            this.searchGroupBox1.TabStop = false;
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(248, 54);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(181, 20);
            this.valueTextBox.TabIndex = 5;
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Location = new System.Drawing.Point(159, 20);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(48, 13);
            this.operatorLabel.TabIndex = 4;
            this.operatorLabel.Text = "Operator";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(245, 20);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(34, 13);
            this.valueLabel.TabIndex = 3;
            this.valueLabel.Text = "Value";
            // 
            // fieldLabel
            // 
            this.fieldLabel.AutoSize = true;
            this.fieldLabel.Location = new System.Drawing.Point(23, 20);
            this.fieldLabel.Name = "fieldLabel";
            this.fieldLabel.Size = new System.Drawing.Size(29, 13);
            this.fieldLabel.TabIndex = 2;
            this.fieldLabel.Text = "Field";
            // 
            // cboOperator
            // 
            this.cboOperator.FormattingEnabled = true;
            this.cboOperator.Items.AddRange(new object[] {
            "=",
            "<",
            ">",
            "<=",
            ">="});
            this.cboOperator.Location = new System.Drawing.Point(159, 54);
            this.cboOperator.Name = "cboOperator";
            this.cboOperator.Size = new System.Drawing.Size(60, 21);
            this.cboOperator.TabIndex = 1;
            // 
            // cboField
            // 
            this.cboField.FormattingEnabled = true;
            this.cboField.Items.AddRange(new object[] {
            "Make",
            "EngineSize",
            "RentalPerDay",
            "Available"});
            this.cboField.Location = new System.Drawing.Point(23, 54);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 21);
            this.cboField.TabIndex = 0;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // btnRun
            // 
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Location = new System.Drawing.Point(504, 41);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 40);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(504, 89);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tblCarTableAdapter
            // 
            this.tblCarTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblCarTableAdapter = this.tblCarTableAdapter;
            this.tableAdapterManager.UpdateOrder = EventDrivenAssignment.HireDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCarBindingSource1
            // 
            this.tblCarBindingSource1.DataMember = "tblCar";
            this.tblCarBindingSource1.DataSource = this.hireDataSet;
            // 
            // hireDataSetBindingSource
            // 
            this.hireDataSetBindingSource.DataSource = this.hireDataSet;
            this.hireDataSetBindingSource.Position = 0;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(710, 351);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.searchGroupBox1);
            this.Controls.Add(this.tblCarDataGridView);
            this.Name = "frmSearch";
            this.Text = "Task A Search Seosamh 20/08/2015";
            this.Load += new System.EventHandler(this.frmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCarDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            this.searchGroupBox1.ResumeLayout(false);
            this.searchGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private HireDataSetTableAdapters.tblCarTableAdapter tblCarTableAdapter;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tblCarDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox searchGroupBox1;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label fieldLabel;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.BindingSource tblCarBindingSource1;
        private System.Windows.Forms.BindingSource hireDataSetBindingSource;
        private System.Windows.Forms.BindingSource columnsBindingSource;
    }
}