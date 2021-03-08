using System;

namespace exercise_18
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
        Console.Write("Give thir number number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The sum is: " + (num1 + num2 + num3));
        Console.ReadLine();

    }
  }
}
