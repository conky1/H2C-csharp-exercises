using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      double sum = 0;
      double amount = 0;
      double even = 0;
      double odd = 0;
      
      while(true){
      Console.Write("Give numbers: ");
        int num = Convert.ToInt32(Console.ReadLine());
            if(num == -1){
             Console.WriteLine();
             Console.WriteLine("Thx! Bye!\n" + "Sum: " + sum +"\nNumbers: " + amount);
             Console.WriteLine("Average: " + sum/amount + "\nEven: " + even + "\nOdd: " + odd);
             break;
             
            }
            else if(num%2==0){
                    sum+=num;
                    amount++;
                    even++;
                    }
            else{
                sum+=num;
                amount ++;
                odd++;

                }
       
      }
       
       Console.ReadLine();
    }
  }
}
