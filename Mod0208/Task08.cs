using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using System.Collections.Generic;
using System.Linq;
namespace MyApp
{
    internal class Task07Mod02
    {
        static void Main(string[] args)
        {
            Task10();
            Console.WriteLine("Tasks modul 02 lesson 08");
            Console.WriteLine();
            Console.WriteLine("-----Task 1-----");
            Task01();

            Console.WriteLine();
            Console.WriteLine("-----Task 2-----");
            Task02();

            Console.WriteLine();
            Console.WriteLine("-----Task 3-----");
            Task03();

            Console.WriteLine();
            Console.WriteLine("-----Task 4-----");
            Task04();

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
            Task08();

            Console.WriteLine();
            Console.WriteLine("-----Task 9-----");
            Task09();

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
                if (i % 2 == 0) list.Add(i.ToString());
                i++;
            } while (i <= 1000);

            Console.WriteLine($"The given number is: {string.Join(',', list)}");
        }

        static void Task03()
        {
            int last = 1;
            int prev = 0;
            string score = "1";
            List<int> chain = new List<int>();


            while (last <= 200000000)
            {
                int copyLast = last;
                score = score + last.ToString();
                chain.Add(copyLast);
                last = last + prev;
                prev = copyLast;
            }

            Console.WriteLine("chain:" + string.Join(',', chain));
        }

        static void Task04()
        {
            Console.WriteLine("Enter integer number a:");
            int max = GetIntegerNumber();
            Console.WriteLine();
            int print = 1;
            for (int i = 1; print <= max; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (print <= max)
                    {
                        Console.Write(print + " ");
                        print++;
                    }
                }
                Console.WriteLine();
            }
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
            for (int i = 1; i <= 20; i++)
            {
                sum = sum + (1f / i);
            }
            Console.WriteLine($"The score is: {sum}");
        }

        static void Task07()
        {
            int number = 13;
            for (int i = 1; i <= number; i += 2)
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
            for (int i = number - 2; i >= 1; i -= 2)
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

        static void Task08()
        {
            Console.WriteLine("Type some string");
            string? chain = Console.ReadLine();
            if (chain != null)
            {
                Console.WriteLine($"Reverse: {string.Join("", chain.ToCharArray().Reverse())}");
            }
            else
            {
                Console.WriteLine("");
            }
        }
        static void Task09()
        {
            Console.WriteLine("Enter some integer");
            int number = GetIntegerNumber();
            List<int> integerNumbers = new List<int>();

            for (int i = number; i >= 1; i = i / 2)
            {
                integerNumbers.Add(i % 2);
            }

            integerNumbers.Reverse();
            if (integerNumbers.Count > 0) Console.WriteLine("Binary: " + string.Join("", integerNumbers));
        }

        static void Task10()
        {
            Console.WriteLine("Enter some integer");
            int numberA = GetIntegerNumber();

            Console.WriteLine("Enter some integer");
            int numberB = GetIntegerNumber();

            int num=0;
            for (int i = 1; i <=numberA*numberB; i++)
            {
                if ((i  % numberB) == 0 && (i % numberA == 0))
                {
                    num = i;
                    break;
                }
            }
            Console.WriteLine(num);
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