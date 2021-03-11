using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
            Console.ReadLine();
    }

    // Write your method here:
    public static int Smallest(int number1, int number2){
            int smallest1 = number1;
            int smallest2 = number2;
            if(smallest1 < smallest2){
                return smallest1;
            }
            else{
                return smallest2;
            }
        
     
        
        }
  }
}
