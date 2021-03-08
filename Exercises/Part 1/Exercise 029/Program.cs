using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.Write("Give a number: ");
      double num1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Give a number: ");
      double num2 = Convert.ToDouble(Console.ReadLine());
      
      if (num1 < num2){
            
            Console.WriteLine("Larger number is: " + num2);
     
                    }
      else if(num1 == num2){
            Console.WriteLine("They are equal!");
            
            }
      else{
            Console.WriteLine("Larger number is: " + num1);
            }

      Console.ReadLine();

    }
  }
}
