using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *Initialise an integer type variable to a random value. Write a switch statement containing four cases. 
 *One of the case values should match the integer variable you intialised. 
 *In each statement code segement, display different gifts. 
 *Display PS4 as a gift against the integer value you initialised. 
 */
namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 12;
            switch(num1){
                case 1:
                    Console.WriteLine("Xbone");
                    break;
                case 5:
                    Console.WriteLine("WiiU");
                    break;
                case 12:
                    Console.WriteLine("PS4");
                    break;
                case 16:
                    Console.WriteLine("PS Triple");
                    break;
            }

            Console.Read();
        }
    }
}
