using System;

namespace C__Project
{

    class Registration
    {
        public static void menu()
        {
            Console.WriteLine("Please choose what you would like to do: ");
            Console.WriteLine("1. Register as a student.");
            Console.WriteLine("2. Register as a teacher.");
            Console.WriteLine("3. Go back to login.");
            int registerMenu = Convert.ToInt32(Console.ReadLine());

            switch(registerMenu)
            {
                case 1:
                    StudentRegister.Register();
                    break;

                case 2:
                    TeacherRegister.Register();
                    break;

                case 3:
                    Menu.menu();
                    break;
                
                default:
                    Console.WriteLine("You have made an invalid choice. Please try again.");
                    break;

            }
        }
    }

    class TeacherRegister{

        static string teacherUser;
        static string teacherPass;

        static bool foundUser = false;
        static bool success = false;
        
        public static void Register()
        {
            while (foundUser == true)
            {
            Console.Write("Please enter your username: ");
            teacherUser = Console.ReadLine();
            UserInformation.SearchT(foundUser, teacherUser);
            }

            while (!success)
            {
                Console.Write("Please enter your password: ");
                teacherPass = Console.ReadLine();

                Console.Write("Please retype your password: ");
                string passRetype = Console.ReadLine();

                if (passRetype == teacherPass)
                    {
                        UserInformation.setTeacher(teacherUser, teacherPass);
                        Console.WriteLine("Registration was a success. Please log in!");
                        success = true;
                } else
                {
                    Console.WriteLine("The passwords do not match. Please try again.");
                }
            }

            TeacherLogin.LoginT();
        }        
    }

    class StudentRegister{

        static string studentUser;
        static string studentPass;

        static bool foundUser = false;
        static bool success = false;

        public static void Register()
        {
            while (!foundUser)
            {
            Console.Write("Please enter your username: ");
            studentUser = Console.ReadLine();
            UserInformation.SearchS(foundUser, studentUser);
            }

            while (!success)
            {
                Console.Write("Please enter your password: ");
                studentPass = Console.ReadLine();

                Console.Write("Please retype your password: ");
                string passRetype = Console.ReadLine();

                if (passRetype == studentPass)
                    {
                        UserInformation.setTeacher(studentUser, studentPass);
                        Console.WriteLine("Registration was a success. Please log in!");
                        success = true;
                } else
                {
                    Console.WriteLine("The passwords do not match. Please try again.");
                }
            }

            StudentLogin.LoginS();

        }   
    }    
}
