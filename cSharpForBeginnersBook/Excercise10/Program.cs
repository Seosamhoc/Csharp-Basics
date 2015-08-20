using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
/*
 * Create two threads inside the "Main" method. One thread should call a method which displays "+" on console one hundred times. 
 * The other method should display "X" on the screen one hundred times. 
 * The "Main" method should wait for the completion of both of these theads, and then it should display "#" on the screen 20 times. 
 * It should then wait for 3 seconds before displaying "#" again, this time 60 times. 
 * Finally, it should wait for 3 mores seconds before displying "#" 20 more times.
 */
namespace Excercise10
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Pluses);
            Thread t2 = new Thread(Xes);

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("");
            for(int i = 0; i<20; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
            Thread.Sleep(3000);
            for (int i = 0; i < 60; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine("");
            Thread.Sleep(3000);
            for (int i = 0; i < 20; i++)
            {
                Console.Write("#");
            }
            Console.Read();
        }

        static void Pluses()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.Write("+");
            }
        }
        static void Xes()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.Write("X");
            }
        }
    }
}
