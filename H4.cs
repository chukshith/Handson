using System;

public class Program     
{
  
    static void Main(string[] args) 
    {
        sbyte number = 125;
        Console.WriteLine("Value of number: " + number);
        number = sbyte.MaxValue;
        Console.WriteLine("Largest value stored in a signed byte : " + number);
    }
}
