using System;

namespace exercise_56
{
  class Program
  {
    public static void Main(String[] args)
    {
            Console.WriteLine(Word());
            Console.ReadLine();
    }

    // Write your method here:
    public static string Word(){
            Console.Write("Say something: ");
           string say = Console.ReadLine();
            return say;
            }
  }
}
