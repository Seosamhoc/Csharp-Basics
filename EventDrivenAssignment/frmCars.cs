using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventDrivenAssignment
{
    public partial class frmCars : Form
    {
        public frmCars()
        {
            InitializeComponent();
        }
        private void frmCars_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            rentalPerDayTextBox.Text = "£" + rentalPerDayTextBox.Text;
            this.firstButton.Enabled = false;
            this.previousButton.Enabled = false;
            this.positionTextBox.Text = this.tblCarBindingSource.Position + 1 + " of " + this.tblCarBindingSource.Count;
            this.toolTip1.SetToolTip(vehicleRegNoTextBox, "Enter the registration number of the vehicle");
            this.toolTip1.SetToolTip(makeTextBox, "Enter the make of the vehicle");
            this.toolTip1.SetToolTip(engineSizeTextBox, "Enter the engine size of the vehicle");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            if (this.tblCarBindingSource.Position != 0)
            {
                this.tblCarBindingSource.MoveFirst();
                rentalPerDayTextBox.Text = "£" + rentalPerDayTextBox.Text;
            }
            this.nextButton.Enabled = true;
            this.lastButton.Enabled = true;
            this.firstButton.Enabled = false;
            this.previousButton.Enabled = false;
            this.positionTextBox.Text = this.tblCarBindingSource.Position + 1 + " of " + this.tblCarBindingSource.Count;
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (this.tblCarBindingSource.Position != 0)
            {
                this.tblCarBindingSource.MovePrevious();
                rentalPerDayTextBox.Text = "£" + rentalPerDayTextBox.Text;
            }
            else
            {
                this.firstButton.Enabled = false;
                this.previousButton.Enabled = false;
            }
            this.nextButton.Enabled = true;
            this.lastButton.Enabled = true;
            this.positionTextBox.Text = this.tblCarBindingSource.Position + 1 + " of " + this.tblCarBindingSource.Count;
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if(this.tblCarBindingSource.Position != this.tblCarBindingSource.Count-1)
            { 
                this.tblCarBindingSource.MoveNext();
                rentalPerDayTextBox.Text = "£" + rentalPerDayTextBox.Text;
            }
            else
            {
                this.nextButton.Enabled = false;
                this.lastButton.Enabled = false;
            }
            this.firstButton.Enabled = true;
            this.previousButton.Enabled = true;
            this.positionTextBox.Text = this.tblCarBindingSource.Position + 1 + " of " + this.tblCarBindingSource.Count;
        }

        private void lastButton_Click(object sender, EventArgs e)
        {
            if (this.tblCarBindingSource.Position != this.tblCarBindingSource.Count-1)
            {
                this.tblCarBindingSource.MoveLast();
                rentalPerDayTextBox.Text = "£" + rentalPerDayTextBox.Text;
            }
            this.firstButton.Enabled = true;
            this.previousButton.Enabled = true;
            this.nextButton.Enabled = false;
            this.lastButton.Enabled = false;
            this.positionTextBox.Text = this.tblCarBindingSource.Position + 1 + " of " + this.tblCarBindingSource.Count;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tblCarBindingSource.EndEdit();
                this.tblCarTableAdapter.Update(this.hireDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed" + ex);
            }
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            this.tblCarBindingSource.AddNew();
            this.positionTextBox.Text = this.tblCarBindingSource.Position + 1 + " of " + this.tblCarBindingSource.Count;
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            this.tblCarBindingSource.RemoveCurrent();
            this.positionTextBox.Text = this.tblCarBindingSource.Position + 1 + " of " + this.tblCarBindingSource.Count;
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            frmSearch form2 = new frmSearch();
            form2.Show();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.tblCarBindingSource.CancelEdit();
            this.positionTextBox.Text = this.tblCarBindingSource.Position + 1 + " of " + this.tblCarBindingSource.Count;
        }
    }
}
