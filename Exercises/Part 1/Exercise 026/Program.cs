using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
       Console.Write("Give your birth year: ");
      double age = Convert.ToDouble(Console.ReadLine());
      
      if (age < 1900){
            
            Console.WriteLine("You're old!");
     
                    }
      else{
            Console.WriteLine();
            }

      Console.ReadLine();

    }
  }
}
