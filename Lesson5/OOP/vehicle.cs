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
            System.Windows.Forms.MessageBox.Show("Make: " + _make + "\nModel: " + _model + "\nMilage: " + _elapsedMilage);
        }

        public string Make
        {
            get { return _make; }
            set { _make = value; }
        }
        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int ElapsedMilage
        {
            get { return _elapsedMilage; }
            set { _elapsedMilage = value; }
        }
        public string Drive(int kilometers)
        {
            _elapsedMilage += kilometers;

            // could preform some additional calculations here
            // for determining fuel consumption and wear and tear
            // costs

            string result;
            result = "The " + Make + " " + _model + " now has " + _elapsedMilage + " kilometers.";
            return result;

        }
    }
}
