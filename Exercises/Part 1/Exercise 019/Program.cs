using System;

namespace exercise_19
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
        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        Console.ReadLine();

    }
  }
}
