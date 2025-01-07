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

    }
}