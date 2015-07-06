using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseBooking
{
    public partial class TestFileManipulation : Form
    {
        public TestFileManipulation()
        {
            InitializeComponent();
        }

        private string[] text = File.ReadAllLines("courses.txt");
        List<string> courseName = new List<string>();
        List<string> courseBookedState = new List<string>();
        List<string> courseDate = new List<string>();
        List<string> courseCost = new List<string>();
        
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < text.Length; i++)
            {
                text[i] = text[i].Trim('"'); 
                //remove " from beginning and end of each line
            }

            for (int i = 0; i < text.Length; i += 4)
            {
                courseName.Add(text[i]);  
                //add just the course titles into courseNames list                
            }

            courseName = courseName.Distinct().ToList<String>(); 
            //remove any duplicate course titles

            listBox1.Items.Clear(); 
            //Ensures that the button doesn't keep adding to 
            //the listbox everytime it's pressed

            foreach (string item in courseName)
            {
                listBox1.Items.Add(item); 
                //add the course titles to the listbox
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter starks = new StreamWriter("Values.txt");
                starks.WriteLine("\"" + textBox1.Text + "\"");
                starks.WriteLine("\"" + textBox2.Text + "\"");
                starks.WriteLine("\"" + textBox3.Text + "\"");
                starks.WriteLine("\"FFFFFFFFFFFF\"");
                starks.Close();
                MessageBox.Show("done");
            }
            catch (Exception)
            {
                MessageBox.Show("File save error");
            }
            var test = new TestFileManipulation();
            test.Show();
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.InitialDirectory = "C:\\Users\\blue16\\Documents\\vsprojects\\Csharp-Basics\\Assignment\\CourseBooking\\bin\\Debug\\";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //Code to create a new file
                }
                catch (Exception)
                {
                    MessageBox.Show("File save error");
                }
            }
            else if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("File incorrect format or missing or dialog cancelled");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "C:\\Users\\blue16\\Documents\\vsprojects\\Csharp-Basics\\Assignment\\CourseBooking\\bin\\Debug\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using ( StreamReader courseStream = new StreamReader(myStream))
                        {
                            string line;
                            int linenumber = 0;

                            while ((line = courseStream.ReadLine()) != null)
                            {
                                if(linenumber%4 == 3)
                                {
                                    courseBookedState.Add(line);
                                }
                                if (linenumber % 4 == 2)
                                {
                                    courseDate.Add(line);
                                }
                                if(linenumber%4 == 1)
                                {
                                    courseCost.Add(line);
                                }
                                if (linenumber % 4 == 1)
                                {
                                    courseCost.Add(line);
                                }
                                if (linenumber % 4 == 0)
                                {
                                    courseName.Add(line);
                                }
                                linenumber++;               
                            }
                            foreach (string item in courseBookedState)
                            {
                                foreach (char booked in item)
                                {
                                    if (booked == 'B')
                                    {
                                        //change checked state of first checkButton
                                    }
                                    else if (booked == 'F' || booked == '"')
                                    {
                                        //Do nothing, the default state is unchecked
                                    }
                                    else
                                    {
                                        MessageBox.Show("Error: file format error");
                                    }
                                }
                            }
                            foreach (string cDate in courseDate)
                            {
                                try
                                {
                                    //cDate.DateCheck();
                                    //DateCheck validates the date
                                    //change the date label's Text to cDate
                                }
                                catch (Exception)
                                {
                                    MessageBox.Show("Error: Invalid Date");
                                }
                            }
                            foreach (string cName in courseName)
                            {
                                //no particular error handling needed
                                //change the value of the label
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
