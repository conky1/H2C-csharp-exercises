using System;

namespace exercise_53
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      Division(7,2);
            Console.ReadLine();


    }

    // Write your method here:
    public static void Division(int numerator, int denominator){
        double divide = Convert.ToDouble(numerator)/Convert.ToDouble(denominator);
            Console.WriteLine(divide);
        }
  }
}
