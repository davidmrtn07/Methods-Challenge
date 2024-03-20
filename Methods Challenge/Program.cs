using System;
    namespace MethodsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
        //Write a method that will print to the console numbers 1000 through -1000
        public static void PrintThousand()
        {
            for(int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}