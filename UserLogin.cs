using System;

namespace C__Project
{
    public class Menu
    {
        public static void menu()
        {
            Console.WriteLine("Please choose what you would like to do: ");
            Console.WriteLine("1. Login as a student.");
            Console.WriteLine("2. Login as a teacher.");
            Console.WriteLine("3. Register.");
            int menuChoice = Convert.ToInt32(Console.ReadLine());

            switch(menuChoice)
            {
                case 1:
                    StudentLogin.LoginS();
                    break;

                case 2:
                    TeacherLogin.LoginT();
                    break;

                case 3:
                    Registration.menu();
                    break;

                default:
                    Console.WriteLine("You have made an invalid choice. Please try again.");
                    break;

            }
        }
    }
    class TeacherLogin{

        static string teacherUser;
        static string teacherPass;
        static bool foundUser = false;
        static bool foundPass = false;

        public static void LoginT()
        {
            while(foundUser)
            {
                Console.Write("Please enter your username: ");
                teacherUser = Console.ReadLine();
                UserInformation.SearchT(foundUser, teacherUser);
            }

            while (foundPass)
            {
                Console.Write("Please enter your password: ");
                teacherPass = Console.ReadLine();
                UserInformation.VerifyT(foundPass, teacherPass);
            }

            Console.WriteLine("You have successfully logged in, {0}.", teacherUser);

            Classes.SubMenuClass();
        }     
    }

    class StudentLogin{
        static string studentUser;
        static string studentPass;
        static bool foundUser = false;
        static bool foundPass = false;

        public static void LoginS()
        {
            while(foundUser)
            {
                Console.Write("Please enter your username: ");
                studentUser = Console.ReadLine();
                UserInformation.SearchS(foundUser, studentUser);
            }

            while (foundPass)
            {
                Console.Write("Please enter your password: ");
                studentPass = Console.ReadLine();
                UserInformation.VerifyS(foundPass, studentPass);
            }

            Console.WriteLine("You have successfully logged in, {0}.", studentUser);

            Classes.SubMenuClass();
        }
    }    
}
