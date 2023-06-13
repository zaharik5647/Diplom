using System;

class Program
{
    static void Main()
    {
        var sum = MyTask.DoMagic();
        Console.WriteLine($"{{\"verdict\": \"OK\", \"output\": \"{sum}\"}}"); 
    }
}