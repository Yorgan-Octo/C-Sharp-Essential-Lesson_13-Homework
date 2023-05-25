using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        public static void MyMethod()
        {
            int idThread = Thread.CurrentThread.GetHashCode();
            Console.WriteLine("Thread - {0}", idThread);
            Thread.Sleep(5);
            Start();
        }
        public static void Start()
        {
            Thread thread = new Thread(MyMethod);
            thread.Start();
        }

        static void Main()
        {
            MyMethod();

        }
    }
}
