using System;

 


namespace InheritanceExample
{

 

 class Student
 { 
public string id,name;
public string DOB;

 

 public void Acceptid()
{
id = Console.ReadLine();
}

 

 public void Acceptname()
 {
 name=Console.ReadLine();
}
public void AcceptDOB()
{
 DOB=Console.ReadLine();
}

 

 class ClgStudent : Student
{
public string stream,semester;

 

 public void acceptstream()
{
stream = Console.ReadLine();
}
public void acceptsemester()
{
semester = Console.ReadLine();
}

 

}

 

 class SchoolStudent : Student 
{
public string TypeofStudent;

 

 public void AcceptstudentType()
{
TypeofStudent=Console.ReadLine();
}

 


}

 

class Program
{
static void Main(string[] args)
{
Student s1=new Student();
ClgStudent c1=new ClgStudent();
SchoolStudent sc1 =new SchoolStudent();

 

s1.Acceptid();
c1.Acceptid();
c1.Acceptname();
c1.AcceptDOB();
c1.acceptstream();
c1.acceptsemester();

 

sc1.Acceptid();
sc1.Acceptname();
sc1.AcceptDOB();
sc1.AcceptstudentType();

 


Console.WriteLine(c1.id +" "+c1.name+" "+c1.DOB+" "+c1.stream+" "+c1.semester);
Console.WriteLine(sc1.id +" "+sc1.name+" "+sc1.DOB+"  "+sc1.TypeofStudent);

 

 

 Console.ReadKey();

 


 

 

}
}
}}