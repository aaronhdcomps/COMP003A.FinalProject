using System.Collections;
using System.Diagnostics;
using static System.Collections.Specialized.BitVector32;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        //------------------------Main Start---------------------------------//
        static void Main(string[] args)
        {
            /*
            SectionSeparator("***Welcome to the Department of Interplanetary Customs and Travel***");
            SectionSeparator("\t\t\tPersonal Info");
            PersonalInfo();
            */
            SectionSeparator("\t\t\tQuestionairre");
            Questions();
            /*
            SectionSeparator("\t\t\tReview");
            */
        }
        //-------------------------End Main---------------------------------//


        //----------------------Module Section------------------------------//
        /// <summary>
        /// Creates seperator for each section
        /// </summary>
        /// <param name="section">Name or message of new section.</param>
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(68, '*') + $"\n{section}\n" + "".
           PadRight(68, '*'));
        }

        static int AgeCalc(string DOB)
        {
            int age = 0;


            return age;
        }
        /// <summary>
        /// Method to ask questions and receive answers from user.
        /// </summary>
        /// <returns></returns>
        static void PersonalInfo()
        {   
            string[] infoOnPerson = new string[4];
            Console.Write("What is your first name? ");
            infoOnPerson[0] = Convert.ToString(Console.ReadLine());
            Console.Write("What is your last name? ");
            infoOnPerson[1] = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"What is your gender:\nEnter M for Male | F for Female | O for Other");
            infoOnPerson[2] = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Please enter your date of birth: MM/DD/YYYY");
            infoOnPerson[3] = Convert.ToString(Console.ReadLine());
        }

        /// <summary>
        /// Method to ask questions and receive answers from user.
        /// </summary>
        /// <returns>answerKey for questions</returns>
        static void Questions() 
        {
            string[] answerKey = new string[10];
            Console.Write($"Thank you!\n\nWe have a questionairre for you to fill out before we approve of your visit.\n\n");
            Console.Write($"Question 1: What color is your blood? ");
            answerKey[0] = Convert.ToString(Console.ReadLine());
            Console.Write($"Question 2: Are you a plant? ");
            answerKey[1] = Convert.ToString(Console.ReadLine());
            Console.Write($"Question 3: Have you ever had inter-species relations with a broom? ");
            answerKey[2] = Convert.ToString(Console.ReadLine());
            Console.Write($"Question 4: Do you exist in a hive state? ");
            answerKey[3] = Convert.ToString(Console.ReadLine());
            Console.Write($"Question 5: How many years since your species went to war? ");
            answerKey[4] = Convert.ToString(Console.ReadLine());
            Console.Write($"Question 6: Do you have any illegal pollen? ");
            answerKey[5] = Convert.ToString(Console.ReadLine());
            Console.Write($"Question 7: When was the last time you spoke in yezctlize to a member of the Spud race? ");
            answerKey[6] = Convert.ToString(Console.ReadLine());
            Console.Write($"Question 8: What is life? ");
            answerKey[7] = Convert.ToString(Console.ReadLine());
            Console.Write($"Question 9: Do you identify as subterranean? ");
            answerKey[8] = Convert.ToString(Console.ReadLine());
            Console.Write($"Question 9: Were you ever too cool for school? ");
            answerKey[9] = Convert.ToString(Console.ReadLine());

            foreach (string answer in answerKey)
            {
                Console.Write($"{answer}\n");
            }

        }

    }
}