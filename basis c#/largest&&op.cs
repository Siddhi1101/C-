using System;
namespace Demo {
   class largestNumber {
      static void Main(string[] args) {
         int num1, num2, num3;
         
         Console.Write("Enter Three Numbers:");
         num1 = Convert.ToInt32(Console.ReadLine());
        num2 = Convert.ToInt32(Console.ReadLine());
       num3 = Convert.ToInt32(Console.ReadLine());
         if (num1 > num2 && num1>num3)
           { 
               Console.Write("first number is the largest!\n");
            } else if(num2 > num1 && num2>num3) {
               Console.Write("second Number is the largest!\n");
         }
      
      else if(num3 > num1 && num3>num2){
         Console.Write("third Number is the largest!\n");
      }
      }
   }
}