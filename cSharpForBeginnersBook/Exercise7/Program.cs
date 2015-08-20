using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Create a class named "Car". Create two variables named "name" and "speed" inside the class. 
 * Initialise these variables using a parameterised constructor. Create a method inside the "Car" class. 
 * This method should accept an integer balue and decrease the speed of the car by that balue. 
 * The method should return the decreased speed to the calling function. 
 * In the "Program" class, display the decreased speed on console.
 */
namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Car red = new Car("bimmah", 120);
            Console.WriteLine(red.name + " is going " + red.speed + "Km/h");
            red.Brake(10);
            Console.WriteLine(red.name + " is going " + red.speed + "Km/h");
            Console.Read();
        }
    }
}
