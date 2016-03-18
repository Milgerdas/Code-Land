using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Calculator
    {
        static void Main(string[] args)
        {
            int number1, number2;
            float div;
            do
            {

                Console.Write("Enter the first number ");
                number1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number ");
                number2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your selected action : \n1.Addition \n2.Substraction \n3.Multiplication \n4.Division");
                int choose;
                choose = int.Parse(Console.ReadLine());

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Sum of " + number1 + " and " + number2 + " is " + (number1 + number2));
                        break;

                    case 2:
                        Console.WriteLine("Substraction of " + number1 + " and " + number2 + " is " + (number1 - number2));
                        break;

                    case 3:
                        Console.WriteLine("Multiplication of " + number1 + " and " + number2 + " is " + (number1 * number2));
                        break;

                    case 4:
                        div = (((float)number1) / number2);
                        Console.WriteLine("Division of " + number1 + " and " + number2 + " is " + div);
                        break;
                }

                Console.WriteLine("Do you want to continue ? (y/n)");
            }

            while ((Console.ReadLine().ToUpper()=="Y"));

            Console.ReadLine();

            }
    }
}
