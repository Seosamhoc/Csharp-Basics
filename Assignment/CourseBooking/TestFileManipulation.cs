using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseBooking
{
    public partial class TestFileManipulation : Form
    {
        public TestFileManipulation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\blue5.FASFG\Documents\vsprojects\Csharp-Basics\Assignment\courses.txt");
            MessageBox.Show(text);
        }
    }
}
