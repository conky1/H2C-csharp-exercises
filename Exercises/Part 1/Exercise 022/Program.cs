using System;

namespace exercise_22
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
        Console.Write("Give second number: ");
        double num3 = Convert.ToDouble(Console.ReadLine());
        double average = ((num1 + num2 + num3) / 3);
        Console.WriteLine("The average is: " + average);
        Console.ReadLine();

        
    }
  }
}
