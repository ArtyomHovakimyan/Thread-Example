
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mic.Volo.Thread_Example
{
    class Printer
    {
        public void PrintNumbers()
        {

            lock (this)
            {
                for (int i = 0; i < 10; i++)
                {
                    Random r = new Random();
                    Thread.Sleep(1000 * r.Next(5));
                    Console.Write("{0}, ", i);
                }
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        Thread t1, t2;
        static void Main(string[] args)
        {
            Program ob = new Program();
            ob.ff();
            Console.ReadKey();
        }
        void ff()
        {
            t1 = new Thread(new ThreadStart(ff1));
            t2 = new Thread(new ThreadStart(ff2));
            t1.Start();
            t2.Start();
        }
        void ff1()
        {
            Thread.Sleep(2000);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("increment: " + i);
            }
        }
        void ff2()
        {
            Thread.Sleep(2000);
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine("------decremnt: " + i);
            }
        }
    }
}
