using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.Write("Give your age: ");
      double age = Convert.ToDouble(Console.ReadLine());
      
      if (age < 18){
            
            Console.WriteLine("You're under age!");
     
                    }
      else{
            Console.WriteLine("You're an adult!");
            }

      Console.ReadLine();

    }
  }
}
