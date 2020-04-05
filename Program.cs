using System;

namespace Calculator
{
    class Program
    {
        private static double sqrt;
        static void Main(string[] args)

        {
            double firstNum;
            double secondNum;                   
            string operation;
            double result;

            Console.Write("Enter the first number: ");
            firstNum = Convert.ToDouble(Console.ReadLine());
          
            Console.Write("Ok now enter your operation ( * , / , +, -, %, sqrt) ");
            operation = Console.ReadLine();

            if (operation == "x")
            {
                Console.Write("Now enter your second number: ");
                secondNum = Convert.ToDouble(Console.ReadLine());
                result = firstNum * secondNum;
                Console.WriteLine(firstNum + " x " + secondNum + " = " + result);
                Console.ReadLine();
            }
            else if (operation == "/")
            {
                Console.Write("Now enter your second number: ");
                secondNum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Now enter your second number: ");
                secondNum = Convert.ToDouble(Console.ReadLine());
                result = firstNum / secondNum;
                Console.WriteLine(firstNum + " / " + secondNum + " = " + result);
                Console.ReadLine();
            }
            else if (operation == "+")
            {
                Console.Write("Now enter your second number: ");
                secondNum = Convert.ToDouble(Console.ReadLine());
                result = firstNum + secondNum;
                Console.WriteLine(firstNum + " + " + secondNum + " = " + result);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                Console.Write("Now enter your second number: ");
                secondNum = Convert.ToDouble(Console.ReadLine());
                result = firstNum - secondNum;
                Console.WriteLine(firstNum + " - " + secondNum + " = " + result);
                Console.ReadLine();
            }
            else if (operation =="%")
            {
                Console.Write("Now enter your second number: ");
                secondNum = Convert.ToDouble(Console.ReadLine());
                result = firstNum*secondNum/100;
                Console.WriteLine(firstNum + " % " + secondNum + " = " + result);
                Console.ReadLine();

            }
            else if (operation == "sqrt")
            {

                result =  sqrt ( firstNum);
                Console.WriteLine(result);
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Sorry that is not correct format! Please restart!");     
                Console.ReadLine();
            }
        }
    }
}