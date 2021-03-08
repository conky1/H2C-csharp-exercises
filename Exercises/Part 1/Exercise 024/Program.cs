using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.Write("Give your speed: ");
      double speed = Convert.ToDouble(Console.ReadLine());
      
      if (speed > 120){
            
            Console.WriteLine("Your speed " + speed + "\n" + "speeding!");
     
                    }
      else{
            Console.WriteLine("Your speed " + speed);
            }

      Console.ReadLine();
    }
  }
}
