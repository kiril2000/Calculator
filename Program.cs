using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Calculator");
            Console.WriteLine("Please enter what to happen:");

            Console.WriteLine("1. calculate");
            Console.WriteLine("2. stop");
            string rule = Console.ReadLine();

            while (rule != "stop")
            {
                if (rule != "calculate")
                {
                    rule = CreateRule();
                    continue;
                }

                Console.WriteLine();
                Console.WriteLine("Please enter first number:");
                double number = double.Parse(Console.ReadLine());

                Console.WriteLine($"{number}");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Available Operations: ");
                Console.WriteLine("1. +");
                Console.WriteLine("2. *");
                Console.WriteLine("3. -");
                Console.WriteLine("4. /");
                Console.WriteLine("5. sqr");
                Console.WriteLine("6. sqrt");
                Console.WriteLine("7. 1 / x");
                Console.WriteLine("0. C");

                Console.WriteLine();
                Console.WriteLine("Please choose from the list. and enter the number of the command");

                int command = 0;

                if (!int.TryParse(Console.ReadLine(), out command))
                {
                    Console.WriteLine("You entered invalid command");

                    rule = CreateRule();

                    continue;
                };

                if (command >= 1 && command <= 4)
                {
                    Console.WriteLine("Please enter second number:");

                    double number2 = double.Parse(Console.ReadLine());

                    switch (command)
                    {
                        case 1:
                            Console.WriteLine($"{number} + {number2} = {number + number2}");
                            break;
                        case 2:
                            Console.WriteLine($"{number} * {number2} = {number * number2}");
                            break;
                        case 3:
                            Console.WriteLine($"{number} - {number2} = {number - number2}");
                            break;
                        case 4:
                            Console.WriteLine($"{number} / {number2} = {number / number2}");
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    switch (command)
                    {
                        case 5:
                            Console.WriteLine($"{Math.Pow(number, 2)}");
                            break;
                        case 6:
                            Console.WriteLine($"{Math.Sqrt(number)}");
                            break;
                        case 7:
                            Console.WriteLine($"{1 / number}");
                            break;
                        case 0:
                            rule = CreateRule();
                            continue;

                        default:
                            break;
                    }
                }

                rule = CreateRule();
            }


            


        }

        private static string CreateRule()
        {
            Console.WriteLine("Please enter command (stop or calculate) :");

            return  Console.ReadLine();
        }

        
    }
}
