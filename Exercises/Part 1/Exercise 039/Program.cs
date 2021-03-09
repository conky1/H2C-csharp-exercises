using System;

namespace exercise_39
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
                    Console.WriteLine("Total sum of numbers " + sum);
                break;
                }
                else if(answer < 0 || answer > 0){
                sum += answer;
                Console.WriteLine();
                }
            }
      Console.ReadLine();
    }
  }
}
