using System;
using System.Threading;
namespace ThreadTutorials
{
    public static class Program
    {
        public static void Main()
        {
            bool stopped = false;

            // Thread 
            Thread t = new Thread(new ThreadStart(() =>
               {
                   do
                   {
                       Console.WriteLine("Running...");
                       Thread.Sleep(1000);
                   } while (!stopped);
                }
            ));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            stopped = true;
            Console.WriteLine("Thread Stopped");
            t.Join();
        }
    }
}