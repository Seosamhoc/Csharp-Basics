using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Using a "while" loop, display the sum of all the even numbers between 0 and 100 (inclusive).
 */
namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int whileNum = 0;
            int result = 0;
            while(whileNum<=100)
            {
                if(whileNum%2 == 0)
                {
                    result += whileNum;
                }
                whileNum++;
            }
            Console.WriteLine(result);
            Console.Read();
        }
    }
}
