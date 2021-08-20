using System;
using System.IO;
namespace FileHandling
{
  
  public class Employee
  {
    public string Name;
    public string MailID;
    public int Salary;
    public int Experience;
    public int ID;
    
    public Employee(int ID_, string Name_, string MailID_, int Salary_, int Experience_)
    {
      ID = ID_;
      Name = Name_;
      MailID = MailID_;
      Salary = Salary_;
      Experience = Experience_;
    }
  }
  
  public class Database
  {
    public void GetData()
    {
      FileStream fs = new FileStream("Database.txt", FileMode.Open, FileAccess.Read);  
      StreamReader sr = new StreamReader(fs);
      string str = sr.ReadLine();
     
      while(str != null)
      {
        Console.WriteLine(str);
        str = sr.ReadLine();
      }
      
      sr.Close();
      fs.Close();
     
    }
    
    public void SetData(Employee e)
    {
      FileStream fs = new FileStream("Database.txt", FileMode.Append, FileAccess.Write);  
      StreamWriter sw = new StreamWriter(fs);
      
      sw.WriteLine("ID :- " + e.ID);
      sw.WriteLine("Name :- " + e.Name);
      sw.WriteLine("MailID :-" + e.MailID);
      sw.WriteLine("Salary :- " + e.Salary);
      sw.WriteLine("Experience :- " + e.Experience + "years" + "\n");
      
      sw.Flush();
      
      sw.Close();
      fs.Close();
    }
  }
  
	public class Program
	{
		public static void Main(string[] args)
		{
		  Database db = new Database();
			Console.WriteLine("Welcome to Employee Mangement System");
			
			Employee E1 = new Employee(1, "Ramesh Mate", "R123@gmail.com", 20000, 4);
			Employee E2 = new Employee(2, "Gouri Patil", "G344@gmail.com", 25000, 6);
			
			db.SetData(E1);
			db.SetData(E2);
			db.GetData();
		}
	}
}