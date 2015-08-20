using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Create a delegate named "Calculations" which accepts two integer type parameters and returns one integer type value. 
 * In the "Program" class, create two methods, "sum" and "subtract", which have the same signature as the "Calculations" delegate. 
 *   Create and object of the "Calculation" delegate and hook both the "sum" and "subtract" methods to it. 
 * Perform "sum" and "subtraction" on two random integers using the object of "Calculation" delegate hooked to the "sum" and "subtract" methods.
 */
namespace Exercise9
{
    public delegate int Calculations(int numOne, int numTwo);
    class Program
    {
        static void Main(string[] args)
        {
            Calculations aCalc = sum;
            Console.WriteLine("5 + 6 = " + aCalc(5,6));
            aCalc += subtract;
            Console.WriteLine("6 - 1 = " + aCalc(6,1));
            Console.Read();
        }
        public static int sum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }
        public static int subtract(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }
    }
}
