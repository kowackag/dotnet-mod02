using System;
using FirstApp;

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
    }
}