using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Initialise three integers with random numbers. If the first integer is equal to the second integer and 
 *both the first and second integers are greater than the third integer, multiply the three. Otherwise, 
 *add the three. Display the result on console.
 */
namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 5;
            int num3 = 6;

            if (num1 == num2 && num1 > num3)
            {
                Console.WriteLine(num1 * num2 * num3); 
            }
            else
            {
                Console.WriteLine(num1 + num2 + num3);
            }
            Console.Read();
        }
    }
}
