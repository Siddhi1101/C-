using System;
 
public class Student
{
    private string sname;
    private int sid;
    private static int count=0;
    public Student()
    {
        count=count+1;
        Console.WriteLine("Enter Name Of Student"+count);
        sname=Console.ReadLine();
        sid=count;

 

    }
    public void Display()
    {
        Console.WriteLine("\n\nName--:"+sname+"Sid--:"+sid);
    }
    public void assesment()
    {
        int marks=0;
        Console.WriteLine("\n\nWhat is 8+21");
        Console.Write("a) 30 \t");
        Console.Write("b) 15 \n");
        Console.Write("c) 15 \t");
        Console.Write("d) 29\n");
        Console.Write("Enter Your Option--:");
        string ch=Console.ReadLine();
        if(ch=="D" || ch=="d")
        {
            marks=marks+1;
        }
        Console.WriteLine("\n\nwhat is 45-2");
        Console.Write("a)44 \t");
        Console.Write("b) 25 \n");
        Console.Write("c)15 \t");
        Console.Write("d) 43 \n");
        Console.Write("Enter Your Option--:");
         ch=Console.ReadLine();
        if(ch=="D" || ch=="d")
        {
            marks=marks+1;
        }
        Console.WriteLine("\n\nWhat is 2^4");
        Console.Write("a) 8 \t");
        Console.Write("b) 16 \n");
        Console.Write("c) 32 \t");
        Console.Write("d) 64 \n");
        Console.Write("Enter Your Option--:");
        ch=Console.ReadLine();
        if(ch=="B" || ch=="b")
        {
            marks=marks+1;
        }
        Console.WriteLine("\n\nwhat is 100/5");
        Console.Write("a)30\t");
        Console.Write("b)25 \n");
        Console.Write("c) 0\t");
        Console.Write("d) 100\n");
        Console.Write("Enter Your Option--:");
        ch=Console.ReadLine();
        if(ch=="B" || ch=="b")
        {
            marks=marks+1;
        }
        Console.WriteLine("\n\nWhat is the 1+2*3");
        Console.Write("a) 2 \t");
        Console.Write("b) 7 \n");
        Console.Write("c) 21 \t");
        Console.Write("d) None of this\n");
        Console.Write("Enter Your Option--:");
        ch=Console.ReadLine();
        if(ch=="B" || ch=="b")
        {
            marks=marks+1;
        }
        this.Display();
        Console.WriteLine("Marks-:"+marks);
    }

 

public class Program
{
    public static void Main()
    {
        Student[] stud=new Student[5];
        int i=0;
        for(i=0;i<5;i++)
        {
            stud[i]=new Student();
        }
        for(i=0;i<5;i++)
        {
            stud[i].assesment();
        }

 

    }
}
 
}

 
//assesment function