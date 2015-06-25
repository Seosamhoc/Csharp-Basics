using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CourseBooking
{
    class CheckButton:CheckBox
    {
        private string initialText;

        public CheckButton()
        {
            this.Appearance = System.Windows.Forms.Appearance.Button;
            this.MaximumSize = new System.Drawing.Size(30, 30);
            this.MinimumSize = new System.Drawing.Size(30, 30);
            this.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CheckedChanged += new System.EventHandler(this.CheckChanged);
        }
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
