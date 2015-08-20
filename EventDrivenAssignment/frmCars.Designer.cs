namespace EventDrivenAssignment
{
    partial class frmCars
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
            System.Windows.Forms.Label vehicleRegNoLabel;
            System.Windows.Forms.Label makeLabel;
            System.Windows.Forms.Label engineSizeLabel;
            System.Windows.Forms.Label dateRegisteredLabel;
            System.Windows.Forms.Label rentalPerDayLabel;
            System.Windows.Forms.Label availableLabel;
            this.vehicleRegNoTextBox = new System.Windows.Forms.TextBox();
            this.tblCarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hireDataSet = new EventDrivenAssignment.HireDataSet();
            this.makeTextBox = new System.Windows.Forms.TextBox();
            this.engineSizeTextBox = new System.Windows.Forms.TextBox();
            this.dateRegisteredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rentalPerDayTextBox = new System.Windows.Forms.TextBox();
            this.availableCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tblCarTableAdapter = new EventDrivenAssignment.HireDataSetTableAdapters.tblCarTableAdapter();
            this.tableAdapterManager = new EventDrivenAssignment.HireDataSetTableAdapters.TableAdapterManager();
            vehicleRegNoLabel = new System.Windows.Forms.Label();
            makeLabel = new System.Windows.Forms.Label();
            engineSizeLabel = new System.Windows.Forms.Label();
            dateRegisteredLabel = new System.Windows.Forms.Label();
            rentalPerDayLabel = new System.Windows.Forms.Label();
            availableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // vehicleRegNoLabel
            // 
            vehicleRegNoLabel.AutoSize = true;
            vehicleRegNoLabel.Location = new System.Drawing.Point(39, 90);
            vehicleRegNoLabel.Name = "vehicleRegNoLabel";
            vehicleRegNoLabel.Size = new System.Drawing.Size(144, 13);
            vehicleRegNoLabel.TabIndex = 1;
            vehicleRegNoLabel.Text = "Vehicle Registration Number:";
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new System.Drawing.Point(39, 116);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new System.Drawing.Size(37, 13);
            makeLabel.TabIndex = 3;
            makeLabel.Text = "Make:";
            // 
            // engineSizeLabel
            // 
            engineSizeLabel.AutoSize = true;
            engineSizeLabel.Location = new System.Drawing.Point(39, 142);
            engineSizeLabel.Name = "engineSizeLabel";
            engineSizeLabel.Size = new System.Drawing.Size(66, 13);
            engineSizeLabel.TabIndex = 5;
            engineSizeLabel.Text = "Engine Size:";
            // 
            // dateRegisteredLabel
            // 
            dateRegisteredLabel.AutoSize = true;
            dateRegisteredLabel.Location = new System.Drawing.Point(39, 169);
            dateRegisteredLabel.Name = "dateRegisteredLabel";
            dateRegisteredLabel.Size = new System.Drawing.Size(87, 13);
            dateRegisteredLabel.TabIndex = 7;
            dateRegisteredLabel.Text = "Date Registered:";
            // 
            // rentalPerDayLabel
            // 
            rentalPerDayLabel.AutoSize = true;
            rentalPerDayLabel.Location = new System.Drawing.Point(39, 194);
            rentalPerDayLabel.Name = "rentalPerDayLabel";
            rentalPerDayLabel.Size = new System.Drawing.Size(82, 13);
            rentalPerDayLabel.TabIndex = 9;
            rentalPerDayLabel.Text = "Rental Per Day:";
            // 
            // availableLabel
            // 
            availableLabel.AutoSize = true;
            availableLabel.Location = new System.Drawing.Point(39, 222);
            availableLabel.Name = "availableLabel";
            availableLabel.Size = new System.Drawing.Size(53, 13);
            availableLabel.TabIndex = 11;
            availableLabel.Text = "Available:";
            // 
            // vehicleRegNoTextBox
            // 
            this.vehicleRegNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "VehicleRegNo", true));
            this.vehicleRegNoTextBox.Location = new System.Drawing.Point(199, 87);
            this.vehicleRegNoTextBox.Name = "vehicleRegNoTextBox";
            this.vehicleRegNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.vehicleRegNoTextBox.TabIndex = 2;
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
            // makeTextBox
            // 
            this.makeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "Make", true));
            this.makeTextBox.Location = new System.Drawing.Point(199, 113);
            this.makeTextBox.Name = "makeTextBox";
            this.makeTextBox.Size = new System.Drawing.Size(200, 20);
            this.makeTextBox.TabIndex = 4;
            // 
            // engineSizeTextBox
            // 
            this.engineSizeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "EngineSize", true));
            this.engineSizeTextBox.Location = new System.Drawing.Point(199, 139);
            this.engineSizeTextBox.Name = "engineSizeTextBox";
            this.engineSizeTextBox.Size = new System.Drawing.Size(200, 20);
            this.engineSizeTextBox.TabIndex = 6;
            // 
            // dateRegisteredDateTimePicker
            // 
            this.dateRegisteredDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblCarBindingSource, "DateRegistered", true));
            this.dateRegisteredDateTimePicker.Location = new System.Drawing.Point(199, 165);
            this.dateRegisteredDateTimePicker.Name = "dateRegisteredDateTimePicker";
            this.dateRegisteredDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateRegisteredDateTimePicker.TabIndex = 8;
            // 
            // rentalPerDayTextBox
            // 
            this.rentalPerDayTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblCarBindingSource, "RentalPerDay", true));
            this.rentalPerDayTextBox.Location = new System.Drawing.Point(199, 191);
            this.rentalPerDayTextBox.Name = "rentalPerDayTextBox";
            this.rentalPerDayTextBox.Size = new System.Drawing.Size(200, 20);
            this.rentalPerDayTextBox.TabIndex = 10;
            this.rentalPerDayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // availableCheckBox
            // 
            this.availableCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.tblCarBindingSource, "Available", true));
            this.availableCheckBox.Location = new System.Drawing.Point(199, 217);
            this.availableCheckBox.Name = "availableCheckBox";
            this.availableCheckBox.Size = new System.Drawing.Size(200, 24);
            this.availableCheckBox.TabIndex = 12;
            this.availableCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bowman Car Hire";
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(444, 51);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 34);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "&Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(444, 91);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 34);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click_1);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(444, 131);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 34);
            this.deleteButton.TabIndex = 16;
            this.deleteButton.Text = "&Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(444, 171);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 34);
            this.searchButton.TabIndex = 17;
            this.searchButton.Text = "&Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // cancelButton
            // 
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(444, 211);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 34);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "&Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(444, 251);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 34);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstButton.Location = new System.Drawing.Point(13, 291);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(75, 34);
            this.firstButton.TabIndex = 20;
            this.firstButton.Text = "First";
            this.firstButton.UseVisualStyleBackColor = false;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Location = new System.Drawing.Point(94, 291);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(75, 34);
            this.previousButton.TabIndex = 21;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // positionTextBox
            // 
            this.positionTextBox.Location = new System.Drawing.Point(175, 299);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.Size = new System.Drawing.Size(100, 20);
            this.positionTextBox.TabIndex = 22;
            // 
            // nextButton
            // 
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Location = new System.Drawing.Point(281, 291);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 34);
            this.nextButton.TabIndex = 23;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastButton.Location = new System.Drawing.Point(362, 291);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(75, 34);
            this.lastButton.TabIndex = 24;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = false;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
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
            // frmCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(571, 343);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.positionTextBox);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(vehicleRegNoLabel);
            this.Controls.Add(this.vehicleRegNoTextBox);
            this.Controls.Add(makeLabel);
            this.Controls.Add(this.makeTextBox);
            this.Controls.Add(engineSizeLabel);
            this.Controls.Add(this.engineSizeTextBox);
            this.Controls.Add(dateRegisteredLabel);
            this.Controls.Add(this.dateRegisteredDateTimePicker);
            this.Controls.Add(rentalPerDayLabel);
            this.Controls.Add(this.rentalPerDayTextBox);
            this.Controls.Add(availableLabel);
            this.Controls.Add(this.availableCheckBox);
            this.Name = "frmCars";
            this.Text = "Task A Seosamh 20/08/2015";
            this.Load += new System.EventHandler(this.frmCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblCarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hireDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HireDataSet hireDataSet;
        private System.Windows.Forms.BindingSource tblCarBindingSource;
        private HireDataSetTableAdapters.tblCarTableAdapter tblCarTableAdapter;
        private HireDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox vehicleRegNoTextBox;
        private System.Windows.Forms.TextBox makeTextBox;
        private System.Windows.Forms.TextBox engineSizeTextBox;
        private System.Windows.Forms.DateTimePicker dateRegisteredDateTimePicker;
        private System.Windows.Forms.TextBox rentalPerDayTextBox;
        private System.Windows.Forms.CheckBox availableCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.TextBox positionTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

