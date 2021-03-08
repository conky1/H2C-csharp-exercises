using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.Write("Give a number: ");
        string input = Console.ReadLine();
        int num = Convert.ToInt32(input);
        Console.WriteLine("You gave number: " + num);
        Console.ReadLine();

    }
  }
}
