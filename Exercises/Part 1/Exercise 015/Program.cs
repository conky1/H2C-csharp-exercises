using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {
        Console.Write("Give a string: ");
        string str = Console.ReadLine();

        Console.Write("Give a number: ");
        string input1 = Console.ReadLine();
        int num1 = Convert.ToInt32(input1);
        
        Console.Write("Give a decimal number: ");
        string input2 = Console.ReadLine();
        double num2 = Convert.ToDouble(input2);
       
        string truth = "True";
        bool boolValue = Convert.ToBoolean(truth);
        Console.Write("Give boolean: ");
        string answer = Console.ReadLine();
            if (answer != "True"){
                Console.WriteLine();
                Console.WriteLine("Your string: " + str);
                Console.WriteLine("You gave number: " + num1);
                Console.WriteLine("You gave decimal number: " + num2);
                Console.WriteLine("Your boolean: " + false);
                Console.ReadLine();
            } 
                else{
            Console.WriteLine();
            Console.WriteLine("Your string: " + str);
            Console.WriteLine("You gave number: " + num1);
            Console.WriteLine("You gave decimal number: " + num2);
            Console.WriteLine("Your boolean: " + true);
            }
       
        Console.ReadLine();

    }
  }
}
