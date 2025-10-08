using System;
using System.Threading;
class Program
{
    static void FgBg(string name)
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"{name}thread working...{i}");
            Thread.Sleep(1000);
        }
    }
    static void Main()
    {
        //Foreground thread
        Thread fgThread = new Thread(() => FgBg("Foreground"));
        fgThread.IsBackground = false;
        //Background thread
        Thread bgThread = new Thread(() => FgBg("Backgound"));
        bgThread.IsBackground = true;
        fgThread.Start();
        bgThread.Start();
        Console.WriteLine("Main threads ends here!");
    }
}
    