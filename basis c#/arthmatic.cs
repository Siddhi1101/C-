using System;
public class operation
{
    public static void Main()
    {
        int x, y;
        char op;
         
        Console.Write("Input first number: ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input operation: ");
        op = Convert.ToChar(Console.ReadLine());
        Console.Write("Input second number: ");
        y = Convert.ToInt32(Console.ReadLine());
         
        if (op=='+')
            Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
        else if (op=='-')
            Console.WriteLine("{0} - {1} = {2}", x, y, x-y);
        else if (op=='*') 
            Console.WriteLine("{0} * {1} = {2}", x, y, x*y);
        else if (op=='/')
            Console.WriteLine("{0} / {1} = {2}", x, y, x/y);
        else{
            Console.WriteLine("wrong");
        }
    }
}