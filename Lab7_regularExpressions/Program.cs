using System;
using System.Text.RegularExpressions;

namespace Lab7_regularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a valid name.");
            string name = Console.ReadLine();
            ValidName(name);

            Console.WriteLine("Enter a valid email. ");
            string email = Console.ReadLine();
            ValidEmail(email);

            Console.WriteLine("Enter a valid phone number. ");
            string phone = Console.ReadLine();
            ValidPhoneNumber(phone);

            Console.WriteLine("Enter a valid date. ");
            string date = Console.ReadLine();
            ValidDate(date);
        }

        public static void ValidName(string name)
        {
            bool doesNameMatch = Regex.IsMatch(name, @"^([A-Z]{1}[a-z]{1,29})$");

            if (doesNameMatch)
            {
                Console.WriteLine($"\n{name} is a valid name.\n");
            }
            else
            {
                Console.WriteLine($"\nnot a valid name.\n");
            }
          
        }

        public static void ValidEmail(string email)
        {
            bool doesEmailMatch = Regex.IsMatch(email, @"^[A-Z0-9a-z]{1,20}@[a-z]{1,15}\.[a-z]{2,3}$");

            if (doesEmailMatch)
            {
                Console.WriteLine($"\n{email}is a valid email address. \n");
            }
            else
            {
                Console.WriteLine("\nnot a valid email.\n");
            }
        }

        public static void ValidPhoneNumber(string phone)
        {
            bool doesPhoneMatch = Regex.IsMatch(phone, @"^(\d{3})+\-(\d{3})+\-(\d{4})$");
            if (doesPhoneMatch)
            {
                Console.WriteLine($"\n{phone} is a valid phone number.\n");
            }
            else
            {
                Console.WriteLine("\nnot a valid phone number.\n");
            }
        }

        public static void ValidDate(string date)
        {
            bool doesDateMatch = Regex.IsMatch(date, @"^([0-9]{2}\/+[0-9]{2}\/+[0-9]{4})$");
            if (doesDateMatch)
            {
                Console.WriteLine($"\n{date} is a valid date.\n");
            }
            else
            {
                Console.WriteLine("\nnot a valid date. \n");
            }
        }


    }
}
