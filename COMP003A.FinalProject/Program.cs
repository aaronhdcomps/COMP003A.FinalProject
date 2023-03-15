/*
 * Aaron Abramson
 * COMP003A
 * Final Project 
 * A form for interplanetary travel throughout the galaxy
 * Loose referece to the Hitchhikers Guide to the Galaxy
*/


using System.Security.Cryptography;

namespace COMP003A.FinalProject
{
    internal class Program
    {
        //------------------------Main Start---------------------------------//
        static void Main(string[] args)
        {
            //Integers for form application
            string firstName;
            string lastName;
            string gender;
            int yearOB;
            //Lists and arrays for application
            List<string> identityInfo = new List<string>();
            string[] questions = QuestionList();
            string[] answers = new string[10];

            //Beginning of form
            SectionSeparator("***Welcome to the Department of Interplanetary Customs and Travel***");

            //Personal Info Questions Section
            SectionSeparator("\t\t\tPersonal Info");

            //Get first name
            do
            {
                Console.Write("What is your first name? ");
                firstName = Console.ReadLine();
            } while (NullChecker(firstName) == true);
            identityInfo.Add(firstName);

            //Get last name
            do
            {
                Console.Write("What is your last name? ");
                lastName = Console.ReadLine();
            } while (NullChecker(lastName) == true);
            identityInfo.Add(lastName);
            
            //Get gender
            do {
                    do
                    {
                            Console.WriteLine($"What is your gender:\nEnter M for Male | F for Female | O for Other | N if not listed");
                            gender = Console.ReadLine();
                            gender = gender.ToUpper();
                    } while (NullChecker(gender) == true);
                
                    char genderAnswer = Convert.ToChar(gender);
                
                switch (genderAnswer)
                    {
                        case 'F':
                            identityInfo.Add("Female");
                            break;
                        case 'M':
                            identityInfo.Add("Male");
                            break;
                        case 'O':
                            identityInfo.Add("Other");
                            break;
                        case 'N':
                            identityInfo.Add("Not listed");
                            break;
                        default:
                            Console.WriteLine("Please submit a valid answer.");
                            break;
                    }

            } while (NullChecker(identityInfo[2]) == true);

            //Get year born
            do
            {
                Console.WriteLine($"What year were you born? ");
                yearOB = Convert.ToInt32(Console.ReadLine());
                if (yearOB <= 1900)
                {
                    Console.WriteLine("");
                }
            } while (yearOB <= 1900);

            //Questionnaire section
            SectionSeparator("\t\t\tQuestionnaire");
            Console.WriteLine("Thank you for that information.\n");
            
            //Questions to user and answers from user
            answers = AskQ(QuestionList());
            
            //Review section
            SectionSeparator("\t\t\tReview");
            
            //
            Console.WriteLine("\nHere is your information...");
            Console.WriteLine($"\n{identityInfo[1]}, {identityInfo[0]}");
            Console.WriteLine($"Gender is {identityInfo[2]}");
            Console.WriteLine($"Age: {AgeCalc(yearOB)} years old");

            //Array traversal for questions and answer review
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Question {i + 1} was\n{questions[i]}");
                Console.WriteLine($"Your response to Question {i + 1}.......{answers[i]}");
            }

            //Method to determine if you are held for further questioning
            HoldForFurtherQuestions();


        }
        //-------------------------Main End---------------------------------//


        //----------------------Module Section------------------------------//


        /// <summary>
        /// Checks for null or empty string responses
        /// </summary>
        /// <param name="response">Response from user to check if null or empty</param>
        /// <returns>True if null or empty</returns>
        static bool NullChecker(string response)
        {
            bool result;
            result = response == null || response == string.Empty;
            return result;
        }
        
        /// <summary>
        /// Creates seperator for each section
        /// </summary>
        /// <param name="section">Name or message of new section.</param>
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(68, '*') + $"\n{section}\n" + "".
           PadRight(68, '*'));
        }

        /// <summary>
        /// Calculates age from year provided by user
        /// </summary>
        /// <param name="yearOB">Users year of birth</param>
        /// <returns></returns>
        static int AgeCalc(int yearOB)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - yearOB;
            
            return age;
        }

        /// <summary>
        /// Method to load questions in array and pass to global array
        /// </summary>
        /// <returns>Array holding questions is returned</returns>
        static string[] QuestionList()
        {
            string[] questionArray = new string[10];
            questionArray[0] = "What color is your blood? ";
            questionArray[1] = "Are you a plant? ";
            questionArray[2] = "Have you ever had inter-species relations with a mop? ";
            questionArray[3] = "Do you exist in a hive state? ";
            questionArray[4] = "How many years since your species went to war? ";
            questionArray[5] = "Do you have any illegal pollen? ";
            questionArray[6] = "When was the last time you spoke in Yezctlize to a member of the Spuddock race? ";
            questionArray[7] = "What is life? ";
            questionArray[8] = "Do you identify as subterranean? ";
            questionArray[9] = "Were you ever too cool for school? ";

            return questionArray;
        }

        /// <summary>
        /// Method to ask questions and record answers.
        /// </summary>
        /// <param name="questions">Questions to ask from an array.</param>
        /// <returns>answer array.</returns>
        static string[] AskQ(string[] questions) 
        {
            string[] answers = new string[10];
            for (int i = 0; i < 10; i++)
            {
                string userResponse = "";
                do
                {                    
                    Console.WriteLine($"Question {i + 1}: {questions[i]}");
                    userResponse = Console.ReadLine();
                }
                while (NullChecker(userResponse) == true);
                answers[i] = userResponse;

            }
            return answers;
        }

        /// <summary>
        /// Method to determine if you are held for further questioning by using a random number
        /// If the number is even, you will be held for further questioning
        /// If the number is odd, you are free to go
        /// </summary>
        static void HoldForFurtherQuestions() 
        {
            Random holdNo = new Random();
            int random = holdNo.Next(1, 20);
            if (random % 2 == 0) 
            {
                Console.WriteLine("\n\n\t\tWe need you come with us, now.");
            }
            else  
            {
                Console.WriteLine("\n\n\t\tEverything seems in order. Have a nice trip.");
            }

        }
        
    }
}