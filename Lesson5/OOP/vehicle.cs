using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Vehicle
    {
        //fields for vehicles
        protected string _make;
        protected string _model;
        protected int _elapsedMilage;

        public Vehicle()
        {
            _make = "DEFAULT";
            _model = "DEFAULT";
            _elapsedMilage = 0;

            System.Windows.Forms.MessageBox.Show("Called Constructor");
        }
        public Vehicle(string make, string model, int elapsedMilage)
        {
            _make = make;
            _model = model;
            _elapsedMilage = elapsedMilage;
            System.Windows.Forms.MessageBox.Show("Make: " + _make + " Model: " + _model + " Milage: " + _elapsedMilage);
        }
    }
}
