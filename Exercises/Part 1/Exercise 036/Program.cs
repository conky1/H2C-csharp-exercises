using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      while (true){
            Console.Write("Give a number: ");
                int answer = Convert.ToInt32( Console.ReadLine());
                if(answer == 0){
                    Console.WriteLine("Bye!");
                break;
                }
                else if(answer < 0){
                Console.WriteLine("That's negative");
                Console.WriteLine();
                }
                else if(answer > 0){
                Console.WriteLine(answer * answer);
                }
            }
      Console.ReadLine();
    }
  }
}
