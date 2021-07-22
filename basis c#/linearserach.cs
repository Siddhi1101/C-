//search number
using System;  
public class Array  
{  
    public static void Main() 
{
     int []arr=new int[10];
     int n ,i,n1,flag=0;
     Console.Write("enter size of array");
     n=int.Parse(Console.Readline());
     Console.WriteLine("element of array : ");
            for (i = 0; i <= n; i++)
            {
             
                arr[i] =int.Parse(Console.ReadLine());
            }
     
	Console.WriteLine("element of serach : ");
    n1=int.Parse(Console.ReadLine()); 	
     for(i=0;i<n;i++)
     {
         if(arr[i]==n1)
         {
             flag=1;
             Console.WriteLine("number "+ n1 + "position " + (i+1));
             break;
         }
         
     }
     if(flag==0)
     {
         Console.Write("Number not found" +n1);
         
     
     Console.ReadLine();
     }
       
  }
}
