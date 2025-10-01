using System;
using System.Threading;
class Program
{
    static void Main()
    {
        Random number = new Random();
        int num = number.Next();
        Console.Write("\nInteger:" + num);
        if (num % 2 == 0)
        {
            num = num * num;
            Console.Write("\nThe integer is EVEN");
            Thread.Sleep(1000);
            Console.Write("\nSquare number=" + num);
        }
        if (num % 2 != 0)
        {
            num = num * num * num;
            Console.Write("\nThe integer is ODD");
            Thread.Sleep(1000);
            Console.Write("\nCube number=" + num);
        }
    }
}