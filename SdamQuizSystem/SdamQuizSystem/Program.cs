using System;

namespace SdamQuizSystem
{
    class Program
    {

        private static detailes detailes = new detailes();

        static void Main(string[] args)
        {
            bool Menu1 = true;
            while (Menu1)
            {

                Menu1 = UI();
            }
            

            static bool UI()
            {
                
               
                Console.ForegroundColor = ConsoleColor.Yellow;
               
                Console.WriteLine("\n.................Quiz Managment System.................\n\n");
                Console.WriteLine("Welcome To Main Menu, Please Enter Your Choice\n");
                Console.WriteLine("Press 1 for students\nPress 2 for teachers\nPress 3 for examiners\npress 4 for exit");
                Console.Write("\nEnter Your Choice : ");
                
                switch (Console.ReadLine())
                {
                   
                    case "1":
                        StudentUi();
                        return true;
                    case "2":
                        TutorUi();
                        return true;
                    case "3":
                        ExaminerUi();
                        return true;
                    case "4":
                        return false;
                    default:
                        Console.WriteLine("invalide choice.please Enter any key to countinue");
                        string v = Console.ReadLine();
                        return true;
                }

            }



            static bool StudentUi()
            {
                Console.WriteLine("\n Please choose a subject:\n\n");
                Console.WriteLine("1)Social Studies\n2)Math\n3)Back");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        StIdvalidation1();
                        return true;
                    case 2:
                        StIdvalidation2();
                        return true;
                    case 3:
                        return false;
                    default:
                        Console.WriteLine("invalide choice.please Enter any key to countinue");
                        string v = Console.ReadLine();
                        StudentUi();
                        return true;
                }

            }

            static bool ExaminerUi()
            {
                Console.WriteLine("\n Please choose a subject:\n\n");
                Console.WriteLine("1)Social Studies\n2)Math\n3)Back");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        examinerIdvalidation1();
                        return true;
                    case 2:
                        examinerIdvalidation2();
                        return true;
                    case 3:
                        return false;
                    default:
                        Console.WriteLine("invalide choice.please Enter any key to countinue");
                        string v = Console.ReadLine();
                        ExaminerUi();
                        return true;
                }

            }

            static void StIdvalidation1()
            {

                try
                {
                    detailes.StIdvalidation();
                }
                catch (Exception e)
                {
                    Console.WriteLine("something went wrong. maybe the index was out of range");
                }

            }

            static void StIdvalidation2()
            {

                try
                {
                    detailes.StIdvalidation1();
                }
                catch (Exception e)
                {
                    Console.WriteLine("something went wrong. maybe the index was out of range");
                }

            }

            static void TutorIdValidation1()
            {

                try
                {
                    detailes.TutorIdValidation();
                }
                catch (Exception e)
                {
                    Console.WriteLine("something went wrong. maybe the index was out of range");
                }

            }

            static void TutorIdValidation2()
            {

                try
                {
                    detailes.TutorIdValidation1();
                }
                catch (Exception e)
                {
                    Console.WriteLine("something went wrong. maybe the index was out of range");
                }

            }

            static void examinerIdvalidation1()
            {

                try
                {
                    detailes.examinerIdValidation();
                }
                catch (Exception e)
                {
                    Console.WriteLine("something went wrong. maybe the index was out of range");
                }

            }

            static void examinerIdvalidation2()
            {

                try
                {
                    detailes.examinerIdValidation1();
                }
                catch (Exception e)
                {
                    Console.WriteLine("something went wrong. maybe the index was out of range");
                }

            }



            static bool TutorUi()
            {
                Console.WriteLine("\n Please choose a subject:\n\n");
                Console.WriteLine("1)Social Studies\n2)Math\n3)Back");
                int choice2 = Convert.ToInt32(Console.ReadLine());
                switch (choice2)
                {
                    case 1:
                        TutorIdValidation1();
                        return true;
                    case 2:
                        TutorIdValidation2();
                        return true;
                    case 3:
                        return false;
                    default:
                        Console.WriteLine("invalide choice.please Enter any key to countinue");
                        string v = Console.ReadLine();
                        TutorUi();
                        return true;
                }

            }
        }
    }
}
