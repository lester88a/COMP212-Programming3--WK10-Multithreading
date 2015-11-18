using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Multithreading
             *  ~execution path
             *  
             * 
             * Life cycle: multithreading 
             * Model
             * 
             * Abort:退出
             * 
             * Priority Levels:
             *  1.priority Highest
             *  2.above normal
             *  3.normal
             *  4.below normal
             *  5. lowest
             *  
             * 
             */

            ThreadStart testTHreadStart = new ThreadStart(new Program().testThread);

            Thread th = new Thread(testTHreadStart);

            th.Start();

            Console.ReadLine();
        }

        public void testThread()
        { 
            //executing the thread
            int count = 0;
            while (count++ <50 )
            {
                Console.WriteLine("Thread executed "+count+" times");
                Thread.Sleep(10);
            }
        }
    }
}
