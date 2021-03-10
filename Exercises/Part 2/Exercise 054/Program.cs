using System;

namespace exercise_54
{
  class Program
  {
    public static void Main(String[] args)
    {
      // Call your method here:
      DivisibleByThreeInRange(2,10);
            Console.ReadLine();
    }

    // Write your method here:
    public static void DivisibleByThreeInRange(int beginning, int end){
       
            for (beginning  = 3; beginning <= end; beginning++){
               if(beginning %3==0){
                 
                Console.WriteLine(beginning);
                    }
                
            }
            
                }
            }
    }
            
            
           
  
