using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.Write("Give your percent [0-100]: ");
      int value = Convert.ToInt32(Console.ReadLine());
      if(value < 0){
            Console.WriteLine("Impossible!");
            }
      else if(value < 49){
            Console.WriteLine("Fail!");
            }
      else if(value == 50 || value < 60){
            Console.WriteLine("1");
            }
      else if(value == 60 || value < 70){
            Console.WriteLine("2");
            }
      else if(value == 70 || value < 80){
            Console.WriteLine("3");
            }
      else if(value == 80 || value < 90){
            Console.WriteLine("4");
            }
      else if(value == 90 || value < 101){
            Console.WriteLine("5");
            }
      else if(value >100){
            Console.WriteLine("Outstanding!");
            }
      Console.ReadLine();





      
    }
  }
}
