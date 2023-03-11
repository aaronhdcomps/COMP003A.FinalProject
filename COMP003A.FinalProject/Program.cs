namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Department of Interplanetary Travel");
            Console.WriteLine("We have a questionairre for you to fill out before your stay on Planet JoKohn.");
            
            Console.Write("What is your last name?");
            string lastName = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"What is your gender:\nEnter M for Male | F for Female | O for Other");

            while (true) { };

            Console.Write("What is your date of birth: MM/DD/YYYY");
            string dateOfBirth = Convert.ToString(Console.ReadLine());

        }
        //End Main

        //Module Section
        static void firstName() 
        {
            try
            {
                Console.Write("What is your first name?");
                string firstName = Convert.ToString(Console.ReadLine());
            }
            catch (Exception)
            {

                throw;
            }
            


        }
    }
}