using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequencingSelection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // //Algorithm 1
            // Console.WriteLine("what is your name?");
            // string Name = Console.ReadLine();
            // Console.WriteLine("What is your age?");
            // int Age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("What is your favorite color?");
            // string Color = Console.ReadLine();

            ////Algorithm 2
            //Console.WriteLine("what is your first name?");
            //string FirstName = Console.ReadLine();
            //Console.WriteLine(FirstName);

            ////Algorithm 3
            //Console.WriteLine("What is your surname?");
            //string Surname = Console.ReadLine();
            //Console.WriteLine("what is your first name?");
            //string FirstName = Console.ReadLine();
            //Console.WriteLine(FirstName);
            //Console.WriteLine(Surname);

            ////Algorithm 4
            //Console.WriteLine("what is your first name?");
            //string FirstName = Console.ReadLine();
            //Console.WriteLine("What is your surname?");
            //string Surname = Console.ReadLine();
            //Console.WriteLine(FirstName + " " + Surname);

            ////Algorithm 5
            //Console.WriteLine("Enter first number");
            //int FirstNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number");
            //int SecondNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(FirstNum + SecondNum);

            ////Algorithm 6
            //Console.WriteLine("Enter first number");
            //int FirstNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter another number");
            //int SecondNum = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(FirstNum + SecondNum);
            //Console.WriteLine(FirstNum * SecondNum);

            ////Algorithm 7
            //Console.WriteLine("Enter distance travelled");
            //int Distance = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter time taken");
            //int Time = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(Distance / Time);

            ////Algorithm 8
            //Console.WriteLine("How many minutes have you used this month?");
            //int Minutes = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("How many texts this month");
            //int Texts = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((Minutes * 0.1) + (Texts * 0.05) + 10);

            ///Algorithm 9
            // string Name = "John";
            // Console.WriteLine("Enter your first name");
            // string UserName = Console.ReadLine();
            // if (Name == UserName)
            // {
            //     Console.WriteLine("You are cool");
            // }
            // else
            // {
            //     Console.WriteLine("Nice to meet you");
            // }

            ////Algorthim 10
            // int Answer = 26;
            // Console.WriteLine("How many letters in the alphabet?");
            // int Guess = Convert.ToInt32(Console.ReadLine());
            // if (Answer == Guess)
            // {
            //     Console.WriteLine("Correct");
            // }
            // else
            // {
            //     Console.WriteLine("Incorrect");
            // }

            ////Algorithm 11
            // Console.WriteLine("Input a number");
            // int Number = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Input another number");
            // int SecondNum = Convert.ToInt32(Console.ReadLine());
            // if (Number > SecondNum)
            // {
            //     Console.WriteLine("The first number is greater");
            // }
            // else
            // {
            //     Console.WriteLine("The second number is greater");
            // }

            ////Algrithm 12
            // int Random = Next(1,10);
            // Console.WriteLine("Guess a number between 1 and 10");
            // int Guess = Convert.ToInt32(Console.ReadLine());
            // if (Random == Guess)
            // {
            //     Console.WriteLine("Correct");
            // }
            // else
            // {
            //     Console.WriteLine("Not what i was thinking!");
            // }

            ////Algorithm 13
            int Holidays = 28;
            Console.WriteLine("How many days do you work per week?");
            int Days = Convert.ToInt32(Console.ReadLine());
            if (Days == 5)
            {
                Console.WriteLine($"Holidays: {Holidays}"); 
            }
            else
            {
                Console.WriteLine($"Holidays: {Holidays * Days / 5}");
            }
        }
    }
}
