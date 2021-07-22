using System;
namespace Demo {
   class largestNumber {
      static void Main(string[] args) {
         int num1, num2, num3;
         
         Console.Write("Enter Three Numbers:");
         num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
       num3 = Convert.ToInt32(Console.ReadLine());
         if (num1 > num2) {
            if (num1 > num3) {
               Console.Write("first number is the largest!\n");
            } else {
               Console.Write("Third Number is the largest!\n");
         }
      }
      else if (num2 > num3)
         Console.Write("Second Number is the largest!\n");
      else
         Console.Write("Third Number is the largest!\n");
      }
   }
}