using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
        Console.Write("Speak friend and enter: \n");
        string pass = Console.ReadLine();
         
        if(pass.ToUpper() != "MELLON"){
            Console.WriteLine("They've got a cave troll!");

            }
        else{
            Console.WriteLine("Welcome friend!");
            }
        Console.ReadLine();
    }
  }
}
