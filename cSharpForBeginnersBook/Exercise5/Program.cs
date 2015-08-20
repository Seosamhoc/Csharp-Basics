using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Using nested "for" loops, store the table of 2,3,4 and 5 in a two dimensional array and the display the elements of the array on screen.
 */
namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] tables = new int[4,12];
            for(int i = 2; i<6; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    tables[i - 2, j] = i*(j+1);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 12; j++)
                {
                    Console.WriteLine((i + 2) + "x" + (j + 1) + "=" + tables[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
 