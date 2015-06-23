using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //calling constructor without arguments
        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle myCar = new Vehicle();
        }

        //giving arguments
        private void button2_Click(object sender, EventArgs e)
        {
            Vehicle myCar2 = new Vehicle("BMW", "320i", 70000);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vehicle myCar3 = new Vehicle();
            myCar3.Make = textBox1.Text;
            myCar3.Model = textBox2.Text;
            myCar3.ElapsedMilage = int.Parse(textBox3.Text);
            MessageBox.Show("Make: " + myCar3.Make + "\nModel: " + myCar3.Model + "\nMilage: " + myCar3.ElapsedMilage);
        }
    }
}
