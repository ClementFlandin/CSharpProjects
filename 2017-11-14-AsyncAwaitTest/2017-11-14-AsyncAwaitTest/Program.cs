using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_11_14_AsyncAwaitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start!");
            launchTask();
            Console.WriteLine("end");
            Console.ReadLine();
        }

        private static async void launchTask()
        {
            Console.WriteLine("Start Task");
            var msg = await Task.Run
            (() =>
            {
                System.Threading.Thread.Sleep(200);
                Console.WriteLine("task");
                return "return from task";
            }
            );
            Console.WriteLine("end task");
            Console.WriteLine(msg);
        }
    }
}
