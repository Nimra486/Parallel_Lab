using System;
using System.Threading;
class Program
{
    static void mythread() {
        Console.WriteLine("This is starting of thread constructor");
        Thread.Sleep(1000);
    }
    static void Main()
    {
        Thread thread = new Thread(mythread);
        Console.WriteLine("Thread State=" + thread.ThreadState);
        thread.Start();
        Console.WriteLine("Thread State=" + thread.ThreadState);
        thread.Join();
        Console.WriteLine("Thread State=" + thread.ThreadState);
    }
}