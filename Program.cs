using System;
namespace GradingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your exam result.");
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Outstanding!!!");
                    break;

                case 'B':
                    Console.WriteLine("Superior!!");
                    break;

                case 'C':
                    Console.WriteLine("Good!");
                    break;
                case 'D':
                    Console.WriteLine("Satisfactory.");
                    break;
                case 'E':
                    Console.WriteLine("Low Pass.");
                    break;
                case 'F':
                    Console.WriteLine("Failure.");
                    break;
                default:
                    Console.WriteLine("What?!");
                    break;
            }
        }
    }
}