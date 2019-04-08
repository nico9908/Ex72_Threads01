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
        public delegate void ThreadStart();
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteHello);
            Thread t2 = new Thread((Object msg) => 
            { WriteHello(msg);
            });
            Thread t3 = new Thread(delegate(Object msg) 
            { WriteHello(msg);
            }); 
            t.Start("Hello World!");
            t2.Start("Hello Lambda!");
            t3.Start("Hello delegate!");
        }
        static void WriteHello(Object msg)
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(msg.ToString());
            }
            Console.ReadKey();
        }
    }
}
