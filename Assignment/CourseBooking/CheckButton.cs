using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseBooking
{
    /// <summary>
    /// Provides a "CheckBox" with the appearance of a size 30x30 button 
    /// </summary>
    class CheckButton:CheckBox
    {
        //used by CheckedChanged method to store the inital value of the Text 
        //on the button
        private string initialText;

        public CheckButton()  
        {
            this.Appearance = System.Windows.Forms.Appearance.Button;
            //We always want the button size to be 30 x 30 but autosize takes 
            //over unless min and max are set
            //this.MaximumSize = new System.Drawing.Size(30, 30);
            //this.MinimumSize = new System.Drawing.Size(30, 30);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckedChanged += new System.EventHandler(this.CheckChanged);
        }

        /// <summary>
        /// When the Checked property changes this changes the style and 
        /// text of the button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckChanged(object sender, EventArgs e)
        { 
            
            if (this.Checked)
            {
                initialText = this.Text;
                this.Text = "B";
                this.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                this.Text = initialText;
                this.BackColor = System.Drawing.SystemColors.Control;
                this.UseVisualStyleBackColor = true;
            }
        }
    }
}
