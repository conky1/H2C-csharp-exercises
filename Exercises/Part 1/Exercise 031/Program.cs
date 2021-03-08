using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.Write("Give number: ");
      int num = Convert.ToInt32(Console.ReadLine());
      if((num % 2) == 0){
            Console.WriteLine("Number is even!");

            }
      else{
            Console.WriteLine("Number is odd!");
            }
      Console.ReadLine();
    }
  }
}
