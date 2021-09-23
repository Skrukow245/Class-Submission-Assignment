using System;



class Program
{
    public static void Main(string[] args)
    {
        var Math = new Math();
        Console.WriteLine("Enter a number");
        int input1 = Convert.ToInt32(Console.ReadLine());
        int result;
        Math.Divide(input1, out result);
        Console.WriteLine("Divided by 2: " + result);      //outputs void method with a integer / 2
        Console.ReadLine();
    }
}

