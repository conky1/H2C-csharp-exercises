using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      
     
            string truth = "tRuE";
            bool boolValue = Convert.ToBoolean(truth);
            Console.Write("Give me the truth: ");
            string answer = Console.ReadLine();
            if (answer != "tRuE"){
                Console.WriteLine(false);
                Console.ReadLine();
            } 
              else{
            Console.WriteLine(true);
            }
            Console.ReadLine();
      // Write your code here:

    }
  }
}
