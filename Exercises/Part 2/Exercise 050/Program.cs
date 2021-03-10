using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Call your method here:
      int i = 0;
      Console.Write("How many times you want to print method: ");
            int num = Convert.ToInt32(Console.ReadLine());
     while(i<num){
                i++;
       PrintPhrase();
          
     
      
                }
        Console.ReadLine();
    }

    // Write your method here:
    public static void PrintPhrase() {
            Console.WriteLine("In a hole in the ground there lived a method");

    }
  }
}
