using System;

class Program
{
    static void Main()
    {
        var matematika = 92;
        var informatika = 94;
        var russkiy = 90;

        var sum = matematika + informatika + russkiy;

        if (sum >= 274)
            Console.WriteLine("Ura!");
        else
            Console.WriteLine("Ohh...");
    }
}