using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Creat a class named "Product" with three properties: name, price, and category. 
 * Add a parameterized constructor which initialises these three properties. 
 * Add another constructor which intialises the first two properties. In the "Program" class, 
 * create two objects of the "Product" class by calling the two overloaded constructors of the "Player" class. 
 * Display the properties of both objects on the console.
 */
namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product jumper = new Product("Jumper", 5.4, "Clothes");
            Product socks = new Product("Socks", "Clothes");

            Console.WriteLine(jumper.name + " " + jumper.price + " " + jumper.category);
            Console.WriteLine(socks.name + " " + socks.category);
            Console.Read();
        }
    }
}
