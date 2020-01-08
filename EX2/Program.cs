using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc cal = new Calc();
            string option;
            string num1, num2;
            do
            {
            re:
                Console.Clear();
                Console.WriteLine("Enter two integers");
                num1 = Console.ReadLine();
                num2 = Console.ReadLine();
                int n1 = 0;
                int n2 = 0;
                try
                {
                    n1 = int.Parse(num1);
                    n2 = int.Parse(num2);
                }
                catch
                {
                    Console.WriteLine("Please enter integers");
                    goto re;
                }

                Console.WriteLine("choose a number that represents the operation\n" +
                    "\t1\tAdd\n" +
                    "\t2\tMultiply\n" +
                    "\t3\tSubtract\n" +
                    "\t4\tDivide\n" +
                    "\t0\tEXIT");
                option = Console.ReadLine();
                if (option == "1")
                    MessageBox.Show(num1 + " + " + num2 + " = " + cal.add(n1, n2));
                else if (option == "2")
                    MessageBox.Show(num1 + " * " + num2 + " = " + cal.mul(n1, n2));
                else if (option == "3")
                    MessageBox.Show(num1 + " - " + num2 + " = " + cal.sub(n1, n2));
                else if (option == "4")
                    MessageBox.Show(num1 + " / " + num2 + " = " + cal.div(n1, n2));
                else if (option == "0")
                    break;
                else
                    Console.WriteLine("Please select an option");
                Console.ReadLine();
            } while (true);
        }
    }
    class Calc
    {
        public int add(int a, int b) { return a + b; }
        public int mul(int a, int b) { return a * b; }
        public int sub(int a, int b) { return a - b; }
        public double div(int a, int b) { return (double)a / b; }
    }
}
