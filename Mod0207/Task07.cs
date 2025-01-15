using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    internal class Task07
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Tasks modul 02 lesson 07");
            Console.WriteLine();

            Console.WriteLine("-----Task 1-----");
            CheckIfNumberAreEqual();

            Console.WriteLine();
            Console.WriteLine("-----Task 2-----");
            CheckIfNumberIsEven();

            Console.WriteLine();
            Console.WriteLine("-----Task 3-----");
            CheckIfNumberIsPositive();

            Console.WriteLine();
            Console.WriteLine("-----Task 4-----");
            //DisplayVariablesInfo();

            Console.WriteLine();
            Console.WriteLine("-----Task 5-----");
            CheckIfCanBeAuthoritive();

            Console.WriteLine();
            Console.WriteLine("-----Task 6-----");
            CheckHeight();

            Console.WriteLine();
            Console.WriteLine("-----Task 7-----");
            DisplayTheBigestNumber();

            Console.WriteLine();
            Console.WriteLine("-----Task 8-----");
            DisplayIfCanBeTheStudent();

            Console.WriteLine();
            Console.WriteLine("-----Task 9-----");
           

            Console.WriteLine();
            Console.WriteLine("-----Task 10-----");
            DisplayIfCanBuildTriangle();

            Console.WriteLine();
            Console.WriteLine("-----Task 11-----");
            DisplayScore();

            Console.WriteLine();
            Console.WriteLine("-----Task 12-----");
        }
        static void CheckIfNumberAreEqual()
        {
            Console.WriteLine("Enter integer number a:");
            int a = GetIntegerNumber();
            Console.WriteLine("Enter integer number b:");
            int b = GetIntegerNumber();

            if (a==b)
            {
                Console.WriteLine("Number a and number b are equal");
            }
            else
            {
                Console.WriteLine("Number a and number b are not equal");
            }   
        }

        static void CheckIfNumberIsEven()
        {
            Console.WriteLine("Enter integer number:");
            int number = GetIntegerNumber(); 
            bool isEven = number % 2 == 0;
            Console.WriteLine("The given number is " + (isEven ? "even" : "odd") );
        }

        static void CheckIfNumberIsPositive()
        {
            Console.WriteLine("Enter the number:");
            string? numberString = Console.ReadLine();
            bool isCorrectNumber = double.TryParse(numberString, out double number);
            while (!isCorrectNumber)
            {
                Console.WriteLine("Incorrect number. Please enter the correct number: ");
                numberString = Console.ReadLine();
                isCorrectNumber = double.TryParse(numberString, out number);
            }
            
            if (number > 0)
            {
                Console.WriteLine("The given number is positive");
                return;             
            } 
            else if (number < 0) {
                Console.WriteLine("The given number is positive");
                return;
            }
            
            Console.WriteLine("The given number is neither positive nor odd. It is zero");
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

        static void CheckIfCanBeAuthoritive()
        {
            Console.WriteLine("Give me your years");
            int years = GetIntegerNumber();
            Console.WriteLine($"You can be authoritive: {years >= 21}");
        }
        static void CheckHeight()
        {
            Console.WriteLine("Enter your height in cm");
            int height = GetIntegerNumber();
            if (height < 140)
            {
                Console.WriteLine("You are dwarf");
            }
            else if ( height >=140 && height <160)
            {
                Console.WriteLine("You are short");
            }
            else if (height >= 160 && height < 180)
            {
                Console.WriteLine("You are quite tall");
            }
            else
            {
                Console.WriteLine("You are tall");
            }
        }

        static void DisplayTheBigestNumber()
        {
            Console.WriteLine("Enter integer number a:");
            int a = GetIntegerNumber();
      
            Console.WriteLine("Enter integer number b:");
            int b = GetIntegerNumber();
       
            Console.WriteLine("Enter integer number c:");
            int c = GetIntegerNumber();

            List<int> listNumbers = new List<int>() { a,b,c};
            listNumbers.Sort();

            Console.WriteLine($"The Bigest number is: {listNumbers[2]}");
        }

        static void DisplayIfCanBeTheStudent()
        {
            Console.WriteLine("Enter your score of Math");
            int math = GetIntegerNumber();
            Console.WriteLine("Enter your score of Physics");
            int physics = GetIntegerNumber();
            Console.WriteLine("Enter your score of Chemist");
            int chemist = GetIntegerNumber();

            bool canBeTheStudent = false;
            if (math > 70 && physics > 55 && chemist>45 && (math + chemist+ physics) > 180)
            {
                canBeTheStudent = true;
            }
       
            if (math + physics >150 || math + chemist >150)
            {
                canBeTheStudent = true;
            }

            if (canBeTheStudent)
            {
                Console.WriteLine("You can be a student");
            } 
            else
            {
                Console.WriteLine("You can not be a student. Try again next year");
            }
        }

        static void DisplayIfCanBuildTriangle()
        {
            Console.WriteLine("Enter the first dimension");
            int dimention01 = GetIntegerNumber();
            Console.WriteLine("Enter the second dimension");
            int dimention02 = GetIntegerNumber();
            Console.WriteLine("Enter the third dimension");
            int dimention03 = GetIntegerNumber();

            int[] intArray = new int[] { dimention01, dimention02, dimention03 };

            Array.Sort(intArray);
            if (intArray[0] + intArray[1] > intArray[2])
            {
                Console.WriteLine("You can build triangle");
            }
            else
            {
                Console.WriteLine("You can not build triangle");
            }
        }

        static void DisplayScore()
        {
            Console.WriteLine("Enter the score 1-6");
            string? numberString = Console.ReadLine();
            bool isCorrectNumber = int.TryParse(numberString, out int number) && number > 0 && number < 7;
            while (!isCorrectNumber)
            {
                Console.WriteLine("Incorrect number. Please enter the correct integer number: ");
                numberString = Console.ReadLine();
                isCorrectNumber = int.TryParse(numberString, out number) && number > 0 && number < 7;
            }
            string score;
            switch (number) 
            { 
                case 1:
                    score = "niedostateczny";
                    break;
                case 2:
                    score = "dopuszczający";
                    break;
                case 3:
                    score = "dostateczny";
                    break;
                case 4:
                    score = "dobry";
                    break;
                case 5:
                    score = "bardzo dobry";
                    break;
                case 6:
                    score = "celujący";
                    break;
                default:
                    score = "unknown";
                    break;
            }
            Console.WriteLine($"Your score in polish is: {score}");
        }
        //helpers

        static int GetIntegerNumber()
        {
            string? numberString = Console.ReadLine();
            bool isCorrectNumber = int.TryParse(numberString, out int number);
            while (!isCorrectNumber)
            {
                Console.WriteLine("Incorrect number. Please enter the correct integer number: ");
                numberString = Console.ReadLine();
                isCorrectNumber = int.TryParse(numberString, out number);
            }
            return number;
        }
    }
}