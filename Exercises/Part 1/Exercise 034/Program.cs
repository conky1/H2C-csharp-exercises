using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      
      while (true){
            Console.Write("Do you want to quit? Yes/No: ");
                string answer = Console.ReadLine();
                if(answer.ToUpper() == "YES"){
                    Console.WriteLine("Bye!");
                break;
                }
            }
         
      
            
        Console.ReadLine();
    }
  }
}
