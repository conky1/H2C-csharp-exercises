using System;

namespace exercise_59
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = GrEatest(2, 7, 13);
      Console.WriteLine("Greatest: " + answer);
            Console.ReadLine();
    }

    // Write your method here:
    public static int GrEatest(int number1, int number2, int number3){
        int great1 = number1;
        int great2 = number2;
        int great3 = number3;
            if(great1 > great2 && great1 > great3){
            return number1;
            }
            else if(great2>great1 && great2 > great3){
            return number2;
            }
            else{
            return number3;
            }

        
        }
  }
}
