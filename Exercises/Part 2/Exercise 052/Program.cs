using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
    printUntilToOne(10);
            Console.ReadLine();
    }

    // Write your method here:
    public static void printUntilToOne(int number){
       int i = 0;
            while(number > i){
            Console.WriteLine(number);
                number--;
                
            }
    }
  }
}
