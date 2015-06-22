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
            /*if (comboBox1.Text == "Seo")
            {
                MessageBox.Show("You picked Seo");
                comboBox1.Text = "";
            }
            2. One line of code to be excuted doesn't need curly braces
            if (comboBox1.Text == "Seos")
                MessageBox.Show("You picked Seos");
            
            3. nested 'if statement
            if (comboBox1.Text != "Shozy")
            {
                if (comboBox1.Text == "Seo")
                {
                    MessageBox.Show("You picked Seo");
                    comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("I'm not sure who you picked.");
                }
            }
            else
            {
                MessageBox.Show("You picked shozy");
            }
            
             4. switch statement
            switch(listBox1.SelectedItem.ToString())
            {
                case "Foobar":
                    MessageBox.Show("You picked Foobar");
                    break;

                case "Bazquirk":
                    MessageBox.Show("You picked Bazquirk");
                    break;

                default:
                    MessageBox.Show("You picked something else.");
                    break;
            }
             arrays
            5. sized array, set the size
            string[] myArray = new string[2];
            myArray[0] = "Seo";
            myArray[1] = "Seos";
            myArray[2] = "Shozy"; //causes an out of bounds exception
            MessageBox.Show(myArray[1]);
            */
            //6. intialized array [0] = Seo, [1] = Seos, [2] = Shozy, [3] = Joe
            //string[] myArray = { "Seo", "Seos", "Shozy", "Joe" };
            //MessageBox.Show(myArray[1]);
            //foreach - shows all the names
            //foreach (var nickname in myArray)
            //{
            //    MessageBox.Show(nickname);
            //}
            //for(int i=0; i < myArray.Length; i++)
            //{
            //    MessageBox.Show(i.ToString());
            //}
            //int i = 0;
            //while (i < int.Parse(textBox1.Text))
            //{
            //    i++;
            //}
            //MessageBox.Show("The final value was: " + i.ToString());
            //6. intialized array [0] = Seo, [1] = Seos, [2] = Shozy, [3] = Joe
            //string[] myArray = { "Seo", "Seos", "Shozy", "Joe" };

            // for and foreach loop
            //for (int i=0; i <myArray.Length;)
            //{
            //    //temp value nickname
            //    foreach (var nickname in myArray)
            //    {
            //        MessageBox.Show(i++ + " " + nickname);
            //    }
            //}
            string[] myArray = { "Seo", "Seos", "Shozy", "Joe" };
            //combine for with if on array
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == "Shozy")
                {
                    MessageBox.Show("Found Shozy");
                }
            }
        }
    }
}
