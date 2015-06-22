using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace selection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1. Basic 'if' statement
            if (comboBox1.Text == "Seo")
            {
                MessageBox.Show("You picked Seo");
                comboBox1.Text = "";
            }
            //2. One line of code to be excuted doesn't need curly braces
            if (comboBox1.Text == "Seos")
                MessageBox.Show("You picked Seos");

        }
    }
}
