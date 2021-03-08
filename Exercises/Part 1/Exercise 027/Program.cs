using System;

namespace exercise_27
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.Write("Give a number: ");
      double num = Convert.ToDouble(Console.ReadLine());
      
      if (num < 0){
            
            Console.WriteLine("Value is negative.");
     
                    }
      else{
            Console.WriteLine("Value is positive.");
            }

      Console.ReadLine();
    }
  }
}
