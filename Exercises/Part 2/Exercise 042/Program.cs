using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.Write("Give a number: ");
        double first = Convert.ToDouble(Console.ReadLine());
      Console.Write("Give a second number: ");
        double second = Convert.ToDouble(Console.ReadLine());
            double sum = first + second;
            double sqrt = Math.Sqrt(sum);
            Console.WriteLine(sqrt);

        


            Console.ReadLine();
    
    }
  }
}
