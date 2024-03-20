using System;
    namespace MethodsChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintThousand();
            Threes();
            IsEqual(2, 8);
            EvenOdd();
            PosNeg();
            AgeVote();

        }
        //Write a method that will print to the console numbers 1000 through -1000
        public static void PrintThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //write a method that will print to the console numbers 3 through 999 by 3 each time.'

        
        public static void Threes()
        {
            for (int k = 3; k <= 999; k += 3)
            {
                Console.WriteLine(k);
            }
        }


        //write a method to accept two integers as parameters and check whether they are equal
        public static void IsEqual(int a, int b)
        {
            if (a == b)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }

        //write a method to check whether given number is even or odd.
        public static void EvenOdd(int c = 11)
        {
            if(c % 2 == 0)
            {
                Console.WriteLine($"Even");
            }
            else
            {
                Console.WriteLine($"Odd");
            }
        }
        //write a method to check whether a given number is positive or negative

        public static void PosNeg(int d = 12)
        {
            if (d > 0)
            {
                Console.WriteLine("Positive Number");
            }
            else
            {
                Console.WriteLine("Negative Number");
            }
        }

        //This methodchecks voter age eligibility
        public static void AgeVote(int f = 23)
        {
            if (f <= 21)
            {
                Console.WriteLine("Sorry, You Cannot Vote.");
            }
            else
            {
                Console.WriteLine("You Can Vote!");
            }
        }
    }


}