using System;

namespace exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE ONE
            // string nameRequestMessage = "Please Provide Your Full Name";
            // Console.WriteLine(nameRequestMessage);
            // string userName = Console.ReadLine();

            // Console.WriteLine(userName.ToUpper().TrimEnd());

            // Console.WriteLine(userName.ToLower().TrimStart());
            // Console.WriteLine(userName.Trim().Length);

            // Console.WriteLine(userName.Trim().IndexOf(" "));
            // Console.WriteLine(userName.Trim().LastIndexOf(" "));
            
            // EXERCISE TWO
            // string ssnRequestMessage = "Please Provide Your SSN";
            // Console.WriteLine(ssnRequestMessage);

            // string ssNumber = Console.ReadLine();
            // Console.WriteLine(ssNumber.Substring(0, 1));
            // Console.WriteLine(ssNumber.Substring(7, 4));

            // string ssNumbNoDashes = ssNumber.Replace("-", "");
            // string ssNumbHidden = ssNumbNoDashes.Substring(0, 5);

            // Console.WriteLine(ssNumbNoDashes.Replace(ssNumbHidden, "*****"));

            // EXERCISE THREE
            string userPhraseMessage = "I will help you create a password. Please provide any phrase.";
            Console.WriteLine(userPhraseMessage);
            string userPhrase = Console.ReadLine();

            string userNumberMessage = "Please Provide A Number Greater Thank 9";
            Console.WriteLine(userNumberMessage);
            string userNumber = Console.ReadLine();

            string firstUserNumber = userNumber.Substring(0, 1);
            int lastUserNumberIndex = userNumber.Trim().Length - 1;
            string lastUserNumber = userNumber.Substring(lastUserNumberIndex, 1);

            string userPassword = firstUserNumber + userPhrase.Replace(" ", "").Replace("a", "2").Replace("o", "0") + lastUserNumber;

            Console.WriteLine($"Your phrase was: {userPhrase}. Your number was: {userNumber}. Your password is: {userPassword}");
        }
    }
}
