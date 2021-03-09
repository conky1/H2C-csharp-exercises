using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.Write("Give the first string: ");
      string first = Console.ReadLine();
      Console.Write("Give the scond string: ");
      string second = Console.ReadLine();
            if(first == second){
            Console.WriteLine("Echo!");

            }
            else{
            Console.WriteLine("Nope!");
            }
      Console.ReadLine();
    }
  }
}
