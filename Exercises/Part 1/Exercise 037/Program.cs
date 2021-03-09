using System;

namespace exercise_37
{
  class Program
  {
    public static void Main(string[] args)
    {
      int sum = 0;
      // Write your code here:
      while (true){
            Console.Write("Give a number: ");
                int answer = Convert.ToInt32( Console.ReadLine());
                if(answer == 0){
                    Console.WriteLine("Total amount of numbers " + sum);
                break;
                }
                else if(answer < 0 || answer > 0){
                sum +=1;
                Console.WriteLine();
                }
            }
      Console.ReadLine();

    }
  }
}
