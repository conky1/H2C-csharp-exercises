using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      int sum = 0;
      int num = 0;
      // Write your code here:
      while (true){
            Console.Write("Give a number: ");
                int answer = Convert.ToInt32( Console.ReadLine());
                if(answer == 0){
                    Console.WriteLine("Total sum of numbers " + sum +"\nTotal amount of numbers " + num);
                break;
                }
                else if(answer < 0 || answer > 0){
                sum +=answer;
                num +=1;
                
                }
            }
      Console.ReadLine();
    }
  }
}
