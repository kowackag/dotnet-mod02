using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Collections.Generic;
namespace MyApp
{
    internal class Task07Mod02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tasks modul 02 lesson 08");
            Console.WriteLine();
            Console.WriteLine("-----Task 1-----");
            Task01();

            Console.WriteLine();
            Console.WriteLine("-----Task 2-----");
            Task02();

            Console.WriteLine();
            Console.WriteLine("-----Task 3-----");
           

            Console.WriteLine();
            Console.WriteLine("-----Task 4-----");
          

            Console.WriteLine();
            Console.WriteLine("-----Task 5-----");
            Task05();

            Console.WriteLine();
            Console.WriteLine("-----Task 6-----");
            Task06();

            Console.WriteLine();
            Console.WriteLine("-----Task 7-----");
            Task07();

            Console.WriteLine();
            Console.WriteLine("-----Task 8-----");
          

            Console.WriteLine();
            Console.WriteLine("-----Task 9-----");
          

            Console.WriteLine();
            Console.WriteLine("-----Task 10-----");
                 
        }
        static void Task01()
        {
            int primeNumbersAmmount = 0;
            for (int i = 1; i <= 100; i++)
            {
                int n = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) n++;
                }
                if (n == 2) primeNumbersAmmount++;
            }
            Console.WriteLine($"Prime numbers is: {primeNumbersAmmount}"); 
        }

        static void Task02()
        {
            int i = 0;
            List<string> list = new List<string>();
            do
            {
                if (i%2==0) list.Add(i.ToString());
                i++; 
            } while (i <= 1000);

            Console.WriteLine($"The given number is: {string.Join(',', list)}");
        }

        static void Task03()
        {
        
        }

        static void Task04()
        {
         
        }

        static void Task05()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"The score is: {Math.Pow(i, 3)}");
            }
        }

        static void Task06()
        {
            float sum = 0;
            for (int i=1; i <= 20; i++)
            {
                sum = sum + (1f/i);
            }
            Console.WriteLine($"The score is: {sum}");
        }

        static void Task07()
        {
            int number = 13;
            for (int i = 1; i <= number; i+=2)
            {
                int emptyNo = (number - i)/2;
                for (int j = 1; j <= emptyNo; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k <= emptyNo; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
            for (int i = number-2; i >= 1; i -= 2)
            {
                int emptyNo = (number - i) / 2;
                for (int j = 1; j <= emptyNo; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                for (int k = 1; k <= emptyNo; k++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("");
            }
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
            else if (height >= 140 && height < 160)
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

            List<int> listNumbers = new List<int>() { a, b, c };
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
            if (math > 70 && physics > 55 && chemist > 45 && (math + chemist + physics) > 180)
            {
                canBeTheStudent = true;
            }

            if (math + physics > 150 || math + chemist > 150)
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

        static void CheckTheWeather()
        {
            Console.WriteLine("Enter the temperature in full Celsius");
            int temp = GetIntegerNumber();

            if (temp < 0)
            {
                Console.WriteLine("cholernie piździ");
            }
            else if (temp >= 0 && temp < 10)
            {
                Console.WriteLine("zimno");
            }
            else if (temp >= 10 && temp < 20)
            {
                Console.WriteLine("chłodno");
            }
            else if (temp >= 20 && temp < 30)
            {
                Console.WriteLine("w sam raz");
            }
            else if (temp >= 30 && temp < 40)
            {
                Console.WriteLine("zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("a weź wyprowadzam się na Alaskę.");
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

        static void DisplayMathScore()
        {
            Console.WriteLine("Enter the number A:");
            string? firstNumberString = Console.ReadLine();
            bool isCorrectNumber = double.TryParse(firstNumberString, out double firstNumber);
            while (!isCorrectNumber)
            {
                Console.WriteLine("Incorrect number. Please enter the correct number: ");
                firstNumberString = Console.ReadLine();
                isCorrectNumber = double.TryParse(firstNumberString, out firstNumber);
            }

            Console.WriteLine("Enter the number B:");
            string? secondNumberString = Console.ReadLine();
            isCorrectNumber = double.TryParse(secondNumberString, out double secondNumber);
            while (!isCorrectNumber)
            {
                Console.WriteLine("Incorrect number. Please enter the correct number: ");
                firstNumberString = Console.ReadLine();
                isCorrectNumber = double.TryParse(firstNumberString, out secondNumber);
            }

            Console.WriteLine("Type opperation: 1 => addition, 2=> substraction, 3=>multiplying, 4=> division, another else quit");

            string? operation = Console.ReadLine();

            switch (operation)
            {
                case "1":
                    Console.WriteLine($"The score is: {firstNumber + secondNumber} ");
                    break;
                case "2":
                    Console.WriteLine($"The score is: {firstNumber - secondNumber} ");
                    break;
                case "3":
                    Console.WriteLine($"The score is: {firstNumber * secondNumber} ");
                    break;
                case "4":
                    {
                        if (secondNumber != 0)
                        {
                            Console.WriteLine($"The score is: {firstNumber / secondNumber} ");
                        }
                        else
                        {
                            Console.WriteLine($"You can not divide by zero");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Good by");
                    break;
            }
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