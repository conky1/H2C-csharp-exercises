using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      Console.Write("Where to? ");
            int value1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("Where from? ");
            int value2 = Convert.ToInt32(Console.ReadLine());
        while(value1 >= value2){
            Console.WriteLine(value2);
            value2++;
            }
        Console.ReadLine();
      
    }
  }
}
