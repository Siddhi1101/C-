using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1a
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int i     = 0;

            Console.WriteLine("Even Numbers :");
            for (i = 1; i <= 100; i++)
            {   
                if( i%2 == 0 )
                {
                    Console.Write(i + " ");
                }
            }


            Console.WriteLine();
        }
    }
}