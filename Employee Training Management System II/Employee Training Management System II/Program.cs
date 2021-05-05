using System;
using System.Collections.Generic;
namespace Employee_Training_Management_System_II
{
    class ProgrammingBsit
    {
        static void Main(string[] args)
        {
            /*the trainee member username is admin and the password is passoword
             the employee username are toffer, kristel and vanissa.*/

            ProgrammingBsit obj = new ProgrammingBsit();
            obj.Intro();
            int EmployeeType = int.Parse(Console.ReadLine());
            if (EmployeeType == 1)
            {
                obj.TraineesLogin();
            }
            else if (EmployeeType == 2)
            {
                obj.EmployeesLogin();

            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Start the System Again....");
            }

        }

        public void Intro()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("Welcome to Mik's IT Employee Training System");
            Console.WriteLine("********************************************");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Press 1 If you are a Trainee");
            Console.WriteLine("Press 2 If you are a Employee");
        }
        public void TraineesLogin()
        {
            Console.WriteLine("Trainee's Login:");
            Console.WriteLine("Username:");
            String UserInput = Console.ReadLine();
            Console.WriteLine("Password:");
            String PassInput = Console.ReadLine();
            Console.WriteLine("The Trainee UserName is " + GetTrainee());  //Delete this Later
            Console.WriteLine("The Trainee Password is " + GetPassword()); //Delete this Later
            if (UserInput.Equals(GetTrainee()) && PassInput.Equals(GetPassword()))
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Trainee's Login Success");
            }
        }
        public void EmployeesLogin()
        {
            var Enames = new HashSet<string>() { "toffer", "kristel", "vanissa" };
            Console.WriteLine("Employee's Login:");
            Console.WriteLine("Username:");
            String UserInput = Console.ReadLine();
            Console.WriteLine("Password:");
            String PassInput = Console.ReadLine();
            if (Enames.Contains(UserInput) && PassInput.Equals(GetPassword()))
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Employee's Login Success");
            }
        }
        public String GetTrainee()
        {
            String UserName = "admin";
            return UserName;
        }
        public String GetPassword()
        {
            String Password = "password";
            return Password;
        }
    }
}