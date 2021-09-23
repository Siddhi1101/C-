
using System;
 
class Program
{
 
    static void Main(string[] args)
    {
 
        char choice;
 
       please_choice: Console.WriteLine("Enter any alphabet: ");
        choice = Convert.ToChar(Console.ReadLine());
 
 
    
    
        switch (choice)
        {
            case 'a': Console.WriteLine("it's vowel");
                break;
            case 'e': Console.WriteLine("it's vowel");
                break;
            case 'i': Console.WriteLine("it's vowel");
                break;
            case 'o': Console.WriteLine("it's vowel");
                break;
            case 'u': Console.WriteLine("it's vowel");
                break;
            case 'A': Console.WriteLine("it's vowel");
                break;
            case 'E': Console.WriteLine("it's vowel");
                break;
            case 'I': Console.WriteLine("it's vowel");
                break;
            case 'O': Console.WriteLine("it's vowel");
                break;
            case 'U': Console.WriteLine("it's vowel");
                break;
            default: Console.WriteLine("it is not vowel");
                goto please_choice;
        }
 
        Console.ReadLine();
 
    }
 
}