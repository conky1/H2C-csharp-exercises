using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
        
        Console.Write("Give a number: ");
            int value = Convert.ToInt32(Console.ReadLine());
        while(value <= 100){
            Console.WriteLine(value);
            value++;
            }
        Console.ReadLine();

    }
  }
}
