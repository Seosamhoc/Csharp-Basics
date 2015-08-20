using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PatsClothesShop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.database1DataSet.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerBindingSource.EndEdit();

            int result = 0;
            result = customerTableAdapter.Update(database1DataSet.Customer);
            MessageBox.Show(result.ToString());
        }



        
    } 
}
  