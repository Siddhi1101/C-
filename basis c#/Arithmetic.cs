using System;
public class Sumofnumber
{
    public static void Main()
    {
      float num1, num2;
               
               Console.WriteLine("Enter number 1 and number 2: ");
               num1 = float.Parse(Console.ReadLine());
               num2 = float.Parse(Console.ReadLine());

 

 

    

               Console.WriteLine("Number1 is:" + num1);
               Console.WriteLine("Number2 is: " + num2);
             Console.WriteLine("1.+");
              Console.WriteLine("2.-");
             Console.WriteLine("3.*");
             Console.WriteLine("4./");
             int choice;
            please_choice: Console.WriteLine("Enter your choice(+ - * /)");
              choice = Convert.ToInt16(Console.ReadLine());  
	
switch(choice)  
	
{  
	
case 1:  
	
   Console.WriteLine("Addition Of Two Numbers : "+(num1+num2));  
	
   break;  
	
case 2:  
	
   Console.WriteLine("Subtraction Of Two Numbers : " + (num1-num2));  
	
   break;  
	
case 3:  
	
    Console.WriteLine("Division Of Two Numbers : " + (num1*num2));  
	
    break;  
	
case 4:  
	
   Console.WriteLine("Multiplicaion Of Two Numbers : " + (num1/num2));  
	
   break; 
    default:
    Console.WriteLine("you are entring wrong choice please re-enter");
    goto please_choice;

 

              
    }
}
} 