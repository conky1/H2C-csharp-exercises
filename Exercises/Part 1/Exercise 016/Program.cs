using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {
        int day = 86400;
        Console.Write("Give days: ");
        int conv = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Days converted to seconds " + conv * day);
        Console.ReadLine();
        
      // Write your code here:

    }
  }
}
