using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
        Console.Write("Give number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Give second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
        Console.WriteLine(num1 + " * " + num2 + " = " + (num1 * num2));
        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2));
        Console.ReadLine();
        

    }
  }
}
