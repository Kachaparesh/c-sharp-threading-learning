using System;
using System.Threading;

namespace ThreadTutorials
{
    public static class Program
    {

        public static void ThreadDemoMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                NewMethod(i);
                Thread.Sleep(2000); // => 2000 miliseconds = 2 seconds, to make thread sleep
            }
        }

        private static void NewMethod(int i)
        {
            Console.WriteLine($"index of loop in thread {i}");
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(ThreadDemoMethod)); // Thread Object created with the method used in it.
            t.IsBackground = true; // This porperty runs thread in background, but it cant keep the app live
            t.Start(); // Thread starts here, without any stopping point until user terminate it.
        }

        //checked next example for better understanding.
    }
}
