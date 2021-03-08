using System;

namespace exercise_17
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
        Console.Write("Give number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Give second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum is: " + (num1 + num2));
        Console.ReadLine();
    }
  }
}
