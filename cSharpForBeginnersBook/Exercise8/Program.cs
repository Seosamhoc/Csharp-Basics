using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Create a class named "Shape". Add one member variable, "name", to this class. 
 *Add a method called "DisplayName" which displays the variable name on console screen with the appropriate statement. 
 *Create two calasses, "Triangle" and "Pentagon". 
 *Create parameterised constructors which initialise variable names in bot the "Triangle" and "Pentagon" classes. 
 *These blasses will implement their own "DisplayName" method. 
 *Using a test class, such as Program.cs, show how polymorphism can be achieved in this scenario. 
 */
namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape karl = new Shape();
            Triangle jim = new Triangle();
            Pentagon alexander = new Pentagon();
            karl.DisplayName();
            jim.DisplayName();
            alexander.DisplayName();
            Console.Read();
        }
    }
}
