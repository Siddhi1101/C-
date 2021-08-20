//Common Element in two array
using System;
class program{
static void Main(string[] args)
{
    int[] a = new int[10];
    int[] b = new int[10];
    int[] c = new int[10];
    int i;
    int j;
    int k = 0;
    int x;
    int count;
    Console.Write("Enter 10 elements for array A: ");
    for (i = 0; i < 10; i++)
    {
        string tempVar = Console.ReadLine();
        if (tempVar != null)
        {
            a[i] = int.Parse(tempVar);
        }
    }
    Console.Write("Enter 10 elements for array B: ");
    for (i = 0; i < 10; i++)
    {
        string tempVar2 = Console.ReadLine();
        if (tempVar2 != null)
        {
            b[i] = int.Parse(tempVar2);
        }
    }
    for (i = 0; i < 10; i++)
    {
        for (j = 0; j < 10; j++)
        {
            if (a[i] == b[j])
            {
                count = 0;
                for (x = 0; x < k; x++)
                {
                    if (a[i] == c[x])
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    c[k] = a[i];
                    k++;
                }
            }
        }
    }
    Console.Write("\nArray C (Contains Common Elements from two given Array):\n");
    for (i = 0; i < k; i++)
    {
        Console.Write("{0:D} ", c[i]);
    }
    Console.ReadKey();
}
}