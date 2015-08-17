using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsharpMockAssignment
{
    public partial class frmBikes : Form
    {
        public frmBikes()
        {
            InitializeComponent();
        }

        private void frmBikes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bikesDataSet.mcycles' table. You can move, or remove it, as needed.
            this.mcyclesTableAdapter.Fill(this.bikesDataSet.mcycles);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.mcyclesBindingSource.EndEdit();
                this.mcyclesTableAdapter.Update(this.bikesDataSet.mcycles);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed" + ex);
            }
        }
        // An error in the data occurred.
        private void mcyclesBindingSource_DataError(object sender,
            DataGridViewDataErrorEventArgs e)
        {
            // Don't throw an exception when we're done.
            e.ThrowException = false;

            // Display an error message.
            string txt = "Error with " +
                //mcycles.Columns[e.ColumnIndex].HeaderText +
                "\n\n" + e.Exception.Message;
            MessageBox.Show(txt, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            // If this is true, then the user is trapped in this cell.
            e.Cancel = false;
        }
        private void cancelChangesButton_Click(object sender, EventArgs e)
        {
            try
            {
                //this.mcyclesBindingSource.CancelEdit();
                this.mcyclesTableAdapter.Fill(this.bikesDataSet.mcycles);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("DATA ERROR  " + ex);
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.mcyclesBindingSource.MoveNext();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            this.mcyclesBindingSource.MovePrevious();
        }

        private void moveFirstButton_Click(object sender, EventArgs e)
        {
            this.mcyclesBindingSource.MoveFirst();
        }

        private void moveLastButton_Click(object sender, EventArgs e)
        {
            this.mcyclesBindingSource.MoveLast();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.mcyclesTableAdapter.SelectAll(this.bikesDataSet.mcycles);
        }

        private void showAllForSaleButton_Click(object sender, EventArgs e)
        {
            this.mcyclesTableAdapter.SelectUnsold(this.bikesDataSet.mcycles);
        }

        private void show500ccOrLessButton_Click(object sender, EventArgs e)
        {
            this.mcyclesTableAdapter.Select500Less(this.bikesDataSet.mcycles);
        }

        private void show500ccOrMoreButton_Click(object sender, EventArgs e)
        {
            this.mcyclesTableAdapter.Select500Plus(this.bikesDataSet.mcycles);
        }

        private void showSoldButton_Click(object sender, EventArgs e)
        {
            this.mcyclesTableAdapter.SelectSold(this.bikesDataSet.mcycles);
        }

       

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            //place your own dialog or do nonthing here
            MessageBox.Show("Data error: " + e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DateTime aDate = new DateTime(2007, 5, 1, 8, 30, 52);
            this.mcyclesTableAdapter.Insert(100, "2001", "mak", 400, "col", new DateTime(2007, 12, 13, 8, 30, 52), true, 10);
        }
    }
}
