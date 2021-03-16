using System;

namespace exercise_60
{
  class Program
  {
        public static void Main(String[] args)
    {
            PrintStars(5);
            PrintStars(3);
            PrintStars(9);
            PrintSquare(4);
            PrintRectangle(17, 3);
            PrintTriangle(4);
            Console.ReadLine();
    }


    public static void PrintStars(int number)
    {
      // you can print one star with the command
      // Console.Write("*");
      // call the print command n times
      // in the end print a line break with the comand
      // Console.WriteLine("");
      int counter1 = 1;
      while (counter1 <= number)
            {
                counter1++;
             Console.Write("*");

            
            
            }
        Console.WriteLine("");
                }
    



    

    public static void PrintSquare(int size)      
    {
        
         int counter2 = 0;
      
      
      while (counter2 < size){
            
                counter2++;
             Console.Write("*");
        for(int n = 1; n<size; n++){
                    Console.Write("*");
             
                }
                
              Console.WriteLine("");
       }
       
       
    }

    public static void PrintRectangle(int width, int height)
    {
             int counter3 = 0;
      
      
      while (counter3 < height){
            
                counter3++;
             Console.Write("*");
        for(int n = 1; n<width; n++){
                    Console.Write("*");
             
                }
                
              Console.WriteLine("");}

    }

    public static void PrintTriangle(int size)
    {
            int row = 0;
          
      
      
      while (row < size ){
            
                row++;
             Console.Write("*");
       for(int n = 1; n <row ; n++)
            {
               Console.Write("*");
                     
            }
       Console.WriteLine("");
     
       
       
       
       
                
             
        }

    }
  }
    }

