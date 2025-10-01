using System;
using System.Threading;

class Fruits
{
    string name;
    int sleeptime;

    public Fruits(string name, int sleeptime)
    {
        this.name = name;
        this.sleeptime = sleeptime;
    }

    public void Run()
    {
        for (int i = 1; i <= 3; i++)
        {
            Console.WriteLine($"{DateTime.Now:T} - {name} - Loop {i}");
            Thread.Sleep(sleeptime * 1000); // Convert seconds to milliseconds
        }
    }

    static void Main()
    {
        Fruits apple = new Fruits("Apple", 1);   // Sleep 1 second
        Fruits mango = new Fruits("Mango", 2);   // Sleep 2 seconds
        Fruits guava = new Fruits("Guava", 3);   // Sleep 3 seconds

        Thread t1 = new Thread(apple.Run);
        Thread t2 = new Thread(mango.Run);
        Thread t3 = new Thread(guava.Run);

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine("All Threads finished....");
    }
}
