using System;

namespace exercise_51
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      printUntilNumber(10);
            Console.ReadLine();
    }

    // Write your method here:
    public static void printUntilNumber(int number){
       int i = 0;
            while(i<number){
            Console.WriteLine(i+1);
            i++;
            }
        }
  }
}
