using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

 

 


namespace sql { 

 

    public class EmpMaster
    {
        private int EmpId;
        private string EmpName, EmpDob, EmpEmail;

 


        public void input()
        {
            Console.WriteLine("Enter the employee id :");
            EmpId = Convert.ToInt32(Console.ReadLine());

 

            Console.WriteLine("Enter the employee name :");
            EmpName = Console.ReadLine();

 

            Console.WriteLine("Enter the employee date of birth:");
            EmpDob = Console.ReadLine();

 

            Console.WriteLine("Enter the employee email :");
            EmpEmail = Console.ReadLine();
        }

 

        public void output()
        {
            Console.WriteLine("\n Employee id is:" + "" + EmpId);
            Console.WriteLine("\n Employee name is :" + "" + EmpName);
            Console.WriteLine("\n  Employee date of birth is:" + "" + EmpDob);
            Console.WriteLine("\n Employee email is :" + "" + EmpEmail);
        }

 


    }

 

 


    public class ProjectMaster
    {

 

        private int ManegerId, ProId;
        private string ProName;

 

        public void input()
        {
            Console.WriteLine("Enter the maneger id :");
            ManegerId = Convert.ToInt32(Console.ReadLine());

 


            Console.WriteLine("Enter the Project id:");
            ProId = Convert.ToInt32(Console.ReadLine());

 


            Console.WriteLine("Enter the project name :");
            ProName = Console.ReadLine();
        }

 

        public void output()
        {
            Console.WriteLine("\n Maneger id is :" + "" + ManegerId);
            Console.WriteLine("\n Project id is :" + "" + ProId);
            Console.WriteLine("\n Project name is :" + "" + ProName);
        }

 


    }

 

    public class EmployeeDetails
    {

 

        private int EmpId, ProId, DateofJoin;

 

        public void input()
        {
            Console.WriteLine("Enter the Employee id:");
            EmpId = Convert.ToInt32(Console.ReadLine());

 

            Console.WriteLine("Enter the Project id:");
            ProId = Convert.ToInt32(Console.ReadLine());

 

            Console.WriteLine("Enter the date of join:");
            DateofJoin = Convert.ToInt32(Console.ReadLine());
        }

 

        public void output()
        {
            Console.WriteLine("\n Employee id is :" + "" + EmpId);
            Console.WriteLine("\n Project id is :" + "" + ProId);
            Console.WriteLine("\n Date of joining is :" + "" + DateofJoin);
        }

 


    }

 

 

 

 

    class MainProgram
    {
        static void Main(string[] args)
        {
            EmpMaster employee = new EmpMaster();
            ProjectMaster project = new ProjectMaster();
            EmployeeDetails empdetail = new EmployeeDetails();

 

            Console.WriteLine("\nWelcome to Pragmasys Solutions");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Which details you want to enter :");
            Console.WriteLine("\n1. Employee Master");
            Console.WriteLine("\n2. Project Master");
            Console.WriteLine("\n3. Employee details");

 

            Console.WriteLine("Enter your choice :");

 

            int choice = Convert.ToInt32(Console.ReadLine());
            bool a = true;
            while (a)
            {
            switch (choice)
               {case1: employee.input();
                    employee.output();
                    break;
                case2:
                    project.input();
                    project.output();
                    break;
                case3: empdetail.input();
                    empdetail.output();
                    break;
                Default: Console.WriteLine("please enter correct choice");
                    break;

 

                }
                    
                
                   
               }  
    
           
        }
    }

 

        
    }