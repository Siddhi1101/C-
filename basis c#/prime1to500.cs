using System;  
  
namespace PrimeNumber  
{  
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 500; i++)
            {
                for (int j = 2; j <= 500; j++)
                {
 
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
 
                }
                if (isPrime)
                {
                    Console.Write("\t" +i);
                }
                isPrime = true;
            }
            Console.ReadKey();
        }
    }   
} 