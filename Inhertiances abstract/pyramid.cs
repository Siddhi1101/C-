//0
//  1 2
//  345
//  6789
using System;
class Program
    {
        static void Main(string[] args)
        {
            int p,q = 1;
            Console.WriteLine("Enter The Number : ");
            p = int.Parse(Console.ReadLine());
            for (int i = 0; i <=p; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(q++);
                }
                Console.WriteLine();
            }
            Console.ReadLine();

 

        }
    }