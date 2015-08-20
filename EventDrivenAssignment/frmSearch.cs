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
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void tblCarBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblCarBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hireDataSet);

        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);
            // TODO: This line of code loads data into the 'hireDataSet.tblCar' table. You can move, or remove it, as needed.
            this.tblCarTableAdapter.Fill(this.hireDataSet.tblCar);

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            switch (cboField.Text)
            {
                case "Make":
                    switch(cboOperator.Text)
                    {
                        case "=":
                            this.tblCarTableAdapter.FillByEqualMake(this.hireDataSet.tblCar, valueTextBox.Text);
                            break;
                        case "<":
                            this.tblCarTableAdapter.FillByGreaterMake(this.hireDataSet.tblCar, valueTextBox.Text);
                            break;
                        case ">":
                            this.tblCarTableAdapter.FillByLessMake(this.hireDataSet.tblCar, valueTextBox.Text);
                            break;
                        case "<=":
                            this.tblCarTableAdapter.FillByGreaterEqualMake(this.hireDataSet.tblCar, valueTextBox.Text);
                            break;
                        case ">=":
                            this.tblCarTableAdapter.FillByLessEqualMake(this.hireDataSet.tblCar, valueTextBox.Text);
                            break;
                    }
                    break;
                case "EngineSize":
                    switch(cboOperator.Text)
                    {
                        case "=":
                            this.tblCarTableAdapter.FillByEqualEngineSize(this.hireDataSet.tblCar, valueTextBox.Text);
                            break;
                        case "<":
                            this.tblCarTableAdapter.FillByGreaterEngineSize(this.hireDataSet.tblCar, valueTextBox.Text);
                            break;
                        case ">":
                            this.tblCarTableAdapter.FillByLessEngineSize(this.hireDataSet.tblCar, valueTextBox.Text);
                            break;
                        case "<=":
                            this.tblCarTableAdapter.FillByGreaterEqualEngineSize(this.hireDataSet.tblCar, valueTextBox.Text);
                            break;
                        case ">=":
                            this.tblCarTableAdapter.FillByLessEqualEngineSize(this.hireDataSet.tblCar, valueTextBox.Text);
                            break;
                    }
                    break;
                case "RentalPerDay":
                    Decimal dailyRent;
                    try
                    {
                        dailyRent = Convert.ToDecimal(valueTextBox.Text);
                    }
                    catch(FormatException)
                    {
                        MessageBox.Show("I didn't understand what you wrote for Value, try writting numbers without any currency symbols");
                        break;
                    }
                    switch (cboOperator.Text)
                    {
                        case "=":
                            this.tblCarTableAdapter.FillByEqualRentalPerDay(this.hireDataSet.tblCar, dailyRent);
                            break;
                        case "<":
                            this.tblCarTableAdapter.FillByGreaterRentalPerDay(this.hireDataSet.tblCar, dailyRent);
                            break;
                        case ">":
                            this.tblCarTableAdapter.FillByLessRentalPerDay(this.hireDataSet.tblCar, dailyRent);
                            break;
                        case "<=":
                            this.tblCarTableAdapter.FillByGreaterEqualRentalPerDay(this.hireDataSet.tblCar, dailyRent);
                            break;
                        case ">=":
                            this.tblCarTableAdapter.FillByLessEqualRentalPerDay(this.hireDataSet.tblCar, dailyRent );
                            break;
                    }
                    break;
                case "Available":
                    Boolean carAvailable;
                    try
                    {
                        carAvailable = Convert.ToBoolean(valueTextBox.Text);
                    }
                    catch (FormatException)
                    {
                        if (valueTextBox.Text.ToLower() == "yes" || valueTextBox.Text == "1")
                        {
                            carAvailable = true;
                        }
                        else if (valueTextBox.Text.ToLower() == "no" )
                        {
                            carAvailable = false;
                        }
                        else 
                        {
                            MessageBox.Show("I didn't understand what you wrote for Value, try 'true' or 'false'");
                            break;
                        }
                    }
                    if (cboOperator.Text == "=")
                        this.tblCarTableAdapter.FillByEqualAvailable(this.hireDataSet.tblCar, carAvailable);
                   
                    break;
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboField.Text == "Available")
            {
                cboOperator.Text = "=";
                cboOperator.Enabled = false;
            }
            else 
            {
                cboOperator.Enabled = true;
            }
        }

    }
}
