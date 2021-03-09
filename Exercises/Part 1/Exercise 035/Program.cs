using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while (true){
            Console.Write("Give a number: ");
                int answer = Convert.ToInt32( Console.ReadLine());
                if(answer == 42){
                    Console.WriteLine("Bye!");
                break;
                }
            }
         
      
            
        Console.ReadLine();

    }
  }
}
