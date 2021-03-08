using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
       Console.Write("Give a decimal number: ");
        string input = Console.ReadLine();
        double num = Convert.ToDouble(input);
        Console.WriteLine("You gave decimal number: " + num);
        Console.ReadLine();


    }
  }
}
