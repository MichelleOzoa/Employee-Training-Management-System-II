using System;

namespace Employee_Training_Management_System_II
{
    class ProgramBsit
    {
        static void Main(string[] args)

        {

            // the training member username is admin and the password is passoword//
            // the employee username are toffer, kristel and vanissa.//

            String toffer = ("Employee Name: toffer\n practice_1: completed\n practice_2: completed\n practice_3: completed");
            String kristel = ("Employee Name: kristel\n practice_1: completed\n practice_2: completed\n practice_3: completed");
            String vanissa = ("Employee Name: vanissa\n practice_1: completed\n practice_2: completed\n practice_3: completed");


            String employeemenu = "Welcome to the Employee Menu: Press A to view the Completed Exercise or Press B to view the Training Schedule";
            String adminmenu = "Welcome to the Admin Menu: Press A to view Employee's Status Press B to view the Training Schedule";
            String schedule = ("Training Schedule:\n exercise#1: December 15,2021\n Exercise#2: December 16,2021\n Exercise#3: December 17,2021");

            Console.WriteLine("Welcome to BSIT 2-1 Employee Training System.");
            Console.WriteLine("..........");
            Console.WriteLine("If you are a Training member Press A and Press B If you are a employee.");
            String letter = Console.ReadLine().ToUpper();


            if (letter.Equals("A"))
            {

                Console.WriteLine(".........");
                Console.WriteLine("Welcome Employee: Please Input your Username:");
                String username = Console.ReadLine();

                if (username.Equals("admin"))
                {
                    Console.WriteLine("Please Input your password:");
                    String password = Console.ReadLine();

                    if (password.Equals("password"))
                    {

                        Console.WriteLine(adminmenu);
                        String adminselection = Console.ReadLine().ToUpper();

                        if (adminselection.Equals("A"))
                        {
                            Console.WriteLine("Employee Status");
                            Console.WriteLine(".......");
                            Console.WriteLine(toffer);
                            Console.WriteLine(".......");
                            Console.WriteLine(kristel);
                            Console.WriteLine(".......");
                            Console.WriteLine(vanissa);
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                        }
                        else if (adminselection.Equals("B"))
                        {
                            Console.WriteLine(schedule);
                            Console.WriteLine("Press key to exit.");
                            Console.ReadKey();

                        }

                        else
                        {
                            Console.WriteLine("Invalid Input!");
                            Console.WriteLine("Press key to exit.");
                            Console.ReadKey();
                        }


                    }
                    else
                    {
                        Console.WriteLine("Invalid Password!");
                        Console.WriteLine("Press key to exit.");
                        Console.ReadKey();
                    }

                }

                else
                {
                    Console.WriteLine("Invalid username!.");
                    Console.WriteLine("Press key to exit.");
                    Console.ReadKey();
                }

            }


            if (letter.Equals("B"))
            {

                Console.WriteLine(".........");
                Console.WriteLine(employeemenu);

                Console.WriteLine("Please choose a key:");
                String empselection = Console.ReadLine().ToLower();

                if (empselection.Equals("a"))
                {
                    Console.WriteLine(".......");
                    Console.WriteLine("Please Input username:");
                    String employeeselectionII = Console.ReadLine().ToLower();

                    if (employeeselectionII.Equals("toffer"))
                    {
                        Console.WriteLine(toffer);
                        Console.WriteLine("Press key to exit.");
                        Console.ReadKey();
                    }
                    else if (employeeselectionII.Equals("kristel"))
                    {
                        Console.WriteLine(kristel);
                        Console.WriteLine("Press key to exit.");
                        Console.ReadKey();
                    }
                    else if (employeeselectionII.Equals("vanissa"))
                    {
                        Console.WriteLine(vanissa);
                        Console.WriteLine("Press key to exit.");
                        Console.ReadKey();
                    }



                }
                if (empselection.Equals("b"))
                {
                    Console.WriteLine(schedule); Console.WriteLine("Press key to exit.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                    Console.WriteLine("Press key to exit.");
                    Console.ReadKey();
                }



                }
                else
                {
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("Press key to exit.");
                    Console.ReadKey();
            }



        }
    }
}