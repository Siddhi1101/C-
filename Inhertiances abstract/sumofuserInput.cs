//SumOf user Input
using System;

public class Program
{
  public static int Sum(string input)
  {
    int sum = 0;
    string[] nums = input.Split(' ');
    
    foreach(var num in nums)
    {
      sum += Convert.ToInt32(num);
    }
    
    return sum;
    
  }
  
	public static void Main(string[] args)
  {
    Console.WriteLine("Input the Numbers");
    string input = Console.ReadLine();
    int sum = Sum(input);
    Console.WriteLine("The Sum is = " + sum);
	}
}