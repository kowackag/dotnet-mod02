using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tasks modul 02");
            Console.WriteLine();

            Console.WriteLine("-----Task 1-----");
            DisplayPersonalData();

            Console.WriteLine();
            Console.WriteLine("-----Task 2-----");
            DisplaySomeChars();

            Console.WriteLine();
            Console.WriteLine("-----Task 3-----");
            CountDiagonal();

            Console.WriteLine();
            Console.WriteLine("-----Task 4-----");
            DisplayVariablesInfo();

            Console.WriteLine();
            Console.WriteLine("-----Task 5-----");
            GetPersoalData();
        }
        static void DisplayPersonalData()
        {

            string name = "Gosia";
            string surname = "Kot";
            int age = 44;
            char gender = 'k';
            string personalId = "12345678901";
            string personalNumber = "AB1234567";

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            Console.WriteLine($"Age: {age} years");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal Id: {personalId}");
            Console.WriteLine($"Personal number: {personalNumber}");
        }

        static void DisplaySomeChars()
        {
            char a = 'a';
            char b = 'b';
            char c = 'c';
            Console.WriteLine($"Chars in reversed order: {c}, {b}, {a}");
        }

        static void CountDiagonal()
        {
            Console.WriteLine("Enter the length of the rectangle: ");
            double length = 0;
            string? lengthString = Console.ReadLine();
            bool isCorrectLength = double.TryParse(lengthString, out length);
            while (!isCorrectLength)
            {
                Console.WriteLine("Incorrect value. Please enter the correct length of the rectangle: ");
                lengthString = Console.ReadLine();
                isCorrectLength = double.TryParse(lengthString, out length);
            }

            Console.WriteLine("Enter the height of the rectangle: ");
            double height = 0;
            string? heightString = Console.ReadLine();
            bool isCorrectHeight = double.TryParse(heightString, out height);
            while (!isCorrectHeight)
            {
                Console.WriteLine("Incorrect value. Please enter the correct height of the rectangle: ");
                heightString = Console.ReadLine();
                isCorrectHeight = double.TryParse(heightString, out height);
            }

            if (isCorrectLength && isCorrectHeight)
            {
                double diagonal = Math.Sqrt(Math.Pow(height, 2) + Math.Pow(length, 2));
                Console.WriteLine($"The length of the diagonal is: {diagonal}");
            }
            else
            {
                Console.WriteLine("Incorrect value. Task was ended");
            }
        }

        static void DisplayVariablesInfo()
        {
            int number = 10;
            string title = "Szkoła Dotneta";
            double floatNumber = 12.5;
            Console.WriteLine($"Number: {number} - Type {number.GetType()}");
            Console.WriteLine($"Title: {title} - Type {title.GetType()}");
            Console.WriteLine($"FloatNumber: {floatNumber} - Type {floatNumber.GetType()}");
        }

        static void GetPersoalData()
        {
            Console.WriteLine("Enter your name: ");
            string? nameString = Console.ReadLine();
            while (string.IsNullOrEmpty(nameString))
            {
                Console.WriteLine("Incorrect name. Try again");
                nameString = Console.ReadLine();
            }

            Console.WriteLine("Enter your surname: ");
            string? surnameString = Console.ReadLine();
            while (string.IsNullOrEmpty(surnameString))
            {
                Console.WriteLine("Incorrect surname. Try again");
                surnameString = Console.ReadLine();
            }

            Console.WriteLine("Enter your phone number - only number ");
            string? phoneNumber = Console.ReadLine();
            bool isCorrectPhoneNumber = long.TryParse(phoneNumber, out long phoneNumberLong) && phoneNumber.Length == 9;
            while (!isCorrectPhoneNumber)
            {
                Console.WriteLine("Incorrect phone number. Try again");
                phoneNumber = Console.ReadLine();
                isCorrectPhoneNumber = long.TryParse(phoneNumber, out phoneNumberLong) && phoneNumber.Length == 9;
            }

            Console.WriteLine("Enter your email");
            string? email = Console.ReadLine();
            bool isCorrectEmail = !string.IsNullOrEmpty(email) && email.Contains("@") && email.Contains(".");
           
            while (!isCorrectEmail)
            {
                Console.WriteLine("Incorrect email. Try again");
                email = Console.ReadLine();
                isCorrectEmail = !string.IsNullOrEmpty(email) && email.Contains("@") && email.Contains(".");
            }

            Console.WriteLine("Enter your height in cm");
            string? heightString = Console.ReadLine();
            int height = 0;
            bool isCorrectHeight = int.TryParse(heightString, out height) && height > 80 && height < 250;

            while (!isCorrectHeight)
            {
                Console.WriteLine("Incorrect height. Try again");
                heightString = Console.ReadLine();
                isCorrectHeight = int.TryParse(heightString, out height);
            }

            Console.WriteLine("Enter your weight in kg");
            string? weightString = Console.ReadLine();
            double weight = 0;
            bool isCorrectWeight = double.TryParse(weightString, out weight) && weight > 20 && weight < 280;

            while (!isCorrectWeight)
            {
                Console.WriteLine("Incorrect weight. Try again");
                weightString = Console.ReadLine();
                isCorrectWeight = double.TryParse(weightString, out weight);
            }

            Console.WriteLine($"That was all questions. {nameString} {surnameString} Thank you for your response"); 
        }
    }
}