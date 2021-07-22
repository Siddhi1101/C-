using System;

 
public class Studentdata
    {
        static void Main(string[] args)
        {
    double rollno,s1,s2,s3,total;
    double per;
    string name,grade;

    Console.Write("total, percentage and division to take marks of three subjects:\n");
    

    Console.Write("Input the Roll Number of the student :");
    rollno = Convert.ToInt32(Console.ReadLine());

    Console.Write("Input the Name of the Student :");
    name = Console.ReadLine();

    Console.Write("Input  the marks of s1 : ");
  s1= Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  the marks of  s2 : ");
 s2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input  the marks of s3 : ");
 s3= Convert.ToInt32(Console.ReadLine());

    total = s1+s2+s3;
    per = total/3.0;
    if (per>=90)
	 grade="A";
    else
	if (per<90&&per>=70)
	   grade="B";
	else
	    if (per<70&&per>=40)
	grade="C";
	     else
		grade="Fail";

       Console.Write("\nRoll No : {0}\nName of Student : {1}\n",rollno,name);
       Console.Write("Marks in S1 : {0}\nMarks in S2 : {1}\nMarks in S3 : {2}\n",s1,s2,s3);
       Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n",total,per,grade);
}
}
