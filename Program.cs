using System;

namespace C__Project
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Menu.menu();
            var grades = new Grades();
            Classes.SubMenuClass();
            grades.ListGrades();
            GPA.SubMenuGPA();  
        }
    }

    class Classes : Program
    {
        public static string[] classNames; 
        public static int[] classCredits;
        public static int arraySize;

        public static void SubMenuClass()
        {
            ListClass();
            SetClassNames();
            GetCredits();
        }
        
        static void SetClassNames()
        {
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Please enter the {0} class name: ", arraySize);
                string singleClassName = Console.ReadLine();
                classNames[i] = singleClassName;
            }
        }

        static void GetCredits()
        {
            classCredits = new int[arraySize];
            Console.WriteLine("Please enter how many credits the class is worth.");
            
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Please enter the credit amount for class {0}: ", classNames[i]);
                int creditAmount = Convert.ToInt32(Console.ReadLine());
                classCredits[i] = creditAmount;
            }
        }

        // Eventually this will be a listArray, but a single array will work for now.
        static void ListClass()
        {
            Console.WriteLine("How many classes would you like to add to your profile?");
            string addClassAmount = Console.ReadLine();
            arraySize = Convert.ToInt32(addClassAmount);

            Console.WriteLine("You want to add {0} classes, is this correct? Y/N", arraySize);
            string correct = Console.ReadLine().ToUpper();

            if (correct == "Y")
            {
                classNames = new string[arraySize];
            } else 
            {
                ListClass();
            }
        }
    }

    class Grades : Classes
    {
        public static string[] grades;

        public void ListGrades()
        {
            grades = new string[arraySize];
            Console.WriteLine("From here, please enter the grades you have received.");
            Console.WriteLine("For right now, please only enter A, B, C, D, or F.");
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Please enter the grade you received for {0}: ", (i+1));
                string gradeForClass = Console.ReadLine().ToUpper();
                grades[i] = gradeForClass;
            }
        }
    }

    class GPA : Grades
    {
        static double[] gpa;
        static double gpaGrades;
        static double GPAScore = 0;

        public static void SubMenuGPA()
        {
            ListGPA();
            CalculateGPA();
            ShowGPA();
        }

        static void ListGPA()
        {
            gpa = new double[arraySize];
            Console.WriteLine("Your GPA will now be calculated.");
            for (int i = 0; i < arraySize; i++)
            {
                if (grades[i] == "A")
                {
                    gpa[i] = classCredits[i] * 4;
                } else if (grades[i] == "B")
                {
                    gpa[i] = classCredits[i] * 3;
                } else if (grades[i] == "C")
                {
                    gpa[i] = classCredits[i] * 2;
                } else if (grades[i] == "D")
                {
                    gpa[i] = classCredits[i] * 1;
                } else if (grades[i] == "F")
                {
                    gpa[i] = classCredits[i] * 0;
                }
            }

        }

        static void CalculateGPA()
        {
            int creditTotal = 0;
            for (int i = 0; i < arraySize; i++)
            {
                creditTotal += classCredits[i];
                gpaGrades += gpa[i];
            }
            Console.WriteLine(creditTotal + " total credits");
            Console.WriteLine(gpaGrades + " is your total grade points.");
            GPAScore = gpaGrades/creditTotal;
        }

        static void ShowGPA()
        {
            Console.WriteLine("Your GPA is {0}.", GPAScore.ToString("#.00"));
        }
    }
}
