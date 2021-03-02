using System;

namespace exercise_08
{
    class Program
    {
        public static void Main(string[] args)
        {
            string hi = "Hello ";
            string merkki = "!";
            Console.Write("Give input: ");
            string greet = Console.ReadLine();
            Console.WriteLine(hi + greet + merkki);
            Console.ReadLine();

        }
    }
}
