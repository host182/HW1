//Novel Poudel
//Homework 1
//Exercise 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using this following namespace
using System.Windows.Forms;

namespace EX1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to this system.\nWhat do you want me to call you?");
            string userName = Console.ReadLine();
            Console.WriteLine("Hi, " + userName + ". How old are you?");
            string ageString = Console.ReadLine();
            int age = new int();
            re:
            //if ageString contains some non numerical characters, it goes to catch and asks the user to enter their age again
            try
            {
                age = int.Parse(ageString);
            }
            catch
            {
                Console.WriteLine("Please enter your age.");
                ageString = Console.ReadLine();
                goto re;
            }

            if (age>=21)
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Clear();
                MessageBox.Show("Danger, " + userName + "Robinson! Danger!");
                Console.Beep();
            }
            Console.WriteLine("Hello, " + userName + "!");
        }
    }
}
