using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex72_Threads01
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteHello);
            Thread t2 = new Thread(WriteHello2);
            Thread t3 = new Thread(WriteHello3);
            t.Start();
            t2.Start();
            t3.Start();
        }
        static void WriteHello()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }
        static void WriteHello2()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }
        static void WriteHello3()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Hello World!");
            }
            Console.ReadKey();
        }
    }
}
