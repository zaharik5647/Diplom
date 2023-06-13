using System;

public static class MyTask
{
    public static string DoMagic()
    {
        var matematika = 92;
        var informatika = 94;
        var russkiy = 90;

        var sum = matematika + informatika + russkiy;

        if (sum >= 274)
            return "Ura!";
        else
            return "Ohh...";
    }
}