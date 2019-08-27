using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Project
{
    class UserInformation
    {
        public static ArrayList teacherUsername = new ArrayList();
        static ArrayList teacherPassword = new ArrayList();
        public static ArrayList studentUsername = new ArrayList();
        static ArrayList studentPassword = new ArrayList();
        static int verify;

        public static void setTeacher(String TUser, String TPass)
        {
            teacherUsername.Add(TUser);
            teacherPassword.Add(TPass);
        }

        public static bool SearchT(bool found, string user)
        {
            for (int i = 0; i < teacherUsername.Count; i++)
            {
                if (teacherUsername[i].ToString() == user)
                {
                    Console.WriteLine("This username has already been used. Please try again.");
                    found = true;
                    verify = i;
                }
            }

            return found;
        }

        public static bool VerifyT(bool foundPass, string teacherPass)
        {
            if (teacherPassword[verify].ToString() == teacherPass)
            {
                foundPass = true;
            }

            return foundPass;
        }
        public static void setStudent(String SUser, String SPass)
        {
            studentUsername.Add(SUser);
            studentPassword.Add(SPass);
        }

        public static bool SearchS(bool found, string user)
        {
            for (int i = 0; i < studentUsername.Count; i++)
            {
                if (studentUsername[i].ToString() == user)
                {
                    Console.WriteLine("This username has already been used. Please try again.");
                    found = true;
                    verify = i;
                }
            }

            return found;
        }

        public static bool VerifyS(bool foundPass, string studentPass)
        {
            if (studentPassword[verify].ToString() == studentPass)
            {
                foundPass = true;
            }

            return foundPass;
        }
    }

}

