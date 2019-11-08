using System;

public class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("hello");
            //throw new Exception("Sorry ");
            //    Console.WriteLine(DivideXByY(0, 0));
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("bye");
    }

    private static decimal DivideXByY(int x, int y)
    {
        return x / y;
    }

}

