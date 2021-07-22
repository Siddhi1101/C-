//Insertion Sort
using System;
public class insertionsort  
{  
    class Program  
    {  
        static int InsertionSorting()  
        {  
             
            Console.Write("\n\nEnter number of elements: ");  
            int max = Convert.ToInt32(Console.ReadLine());  
            int[] numarray = new int[max];  
            for (int i = 0; i < max; i++)  
            {  
                Console.Write("\nEnter  element: ");  
                numarray[i] = Convert.ToInt32(Console.ReadLine());  
            }  
             
            for (int k = 0; k < max; k++)  
                Console.Write(numarray[k] + " ");  
            Console.Write("\n");  
            for (int i = 1; i < max; i++)  
            {  
                int j = i;  
                while (j > 0)  
                {  
                    if (numarray[j - 1] > numarray[j])  
                    {  
                        int temp = numarray[j - 1];  
                        numarray[j - 1] = numarray[j];  
                        numarray[j] = temp;  
                        j--;  
                    }  
                    else  
                        break;  
                }  
                
                for (int k = 0; k < max; k++)  
                    Console.Write(numarray[k] + " ");  
                Console.Write("\n");  

            }  
            
            for (int i = 0; i < max; i++)  
            {  
                Console.Write("Sorted  element: ");  
                Console.Write(numarray[i]);  
                Console.Write("\n");  
            }  
            return 0;  
        }  
        static void Main(string[] args)  
        {  
            InsertionSorting();  
            Console.ReadLine();  
        }  
    }  
}
