using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int number = 0;
        Console.Write("Give a number: ");
            int value = Convert.ToInt32(Console.ReadLine());
        while(number <= value){
            Console.WriteLine(number);
            number++;
            }
        Console.ReadLine();

    }
  }
}
