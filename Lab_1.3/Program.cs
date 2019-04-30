using System;

namespace Lab_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number: 
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factirial calculation
            ");// префикс @ резервирует слова в имени переменной.

            a = long.Parse(Console.ReadLine()); //идет приведение к long.
            switch (a) //запущен процесс оператора выбора,он запустит одно решение.
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
        #region farmer
        static void Farmer_puzzle() // Создан метод Farmer_puzzle.
        {
            //Key sequence: 3817283 or 3827183
            // Declare 7 int variables for the input numbers and other variables
            Console.ForegroundColor = ConsoleColor.Green; // Задан цвет для текста в консоли "зеленый".
            Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");// Консоль выводит зарезервированный текст
            Console.WriteLine("There: farmer and wolf - 1");// вывод текста "There: farmer and wolf - 1"
            Console.WriteLine("There: farmer and cabbage - 2");//вывод  текста "There: farmer and cabbage - 2"
            Console.WriteLine("There: farmer and goat - 3");//вывод текста "There: farmer and goat - 3"
            Console.WriteLine("There: farmer  - 4");//вывод текста "There: farmer  - 4"
            Console.WriteLine("Back: farmer and wolf - 5"); //вывод текста "Back: farmer and wolf - 5"
            Console.WriteLine("Back: farmer and cabbage - 6"); //вывод текста "Back: farmer and cabbage - 6"
            Console.WriteLine("Back: farmer and goat - 7");//вывод текста  "Back: farmer and goat - 7"
            Console.WriteLine("Back: farmer  - 8"); //вывод текста "Back: farmer  - 8"
            Console.ForegroundColor = ConsoleColor.Blue;// Задан цвет для текста в консоли "синий".
            Console.WriteLine("Please,  type numbers by step ");//вывод текста  "Please,  type numbers by step "
            // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing

        }
        #endregion

        #region calculator
        static void Calculator()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // Set Console.ForegroundColor  value
            Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation ");
            // Implement option input (1,2,3,4,5)
            //     and input of  two or one numbers
            //  Perform calculations and output the result 
        }
        #endregion

        #region Factorial

        static void Factorial_calculation()
        {
            while (true)
            {
                {
                    double X1, X2;
                    string _operator;
                    Console.WriteLine("введите первое число: ");
                    X1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("введите знак:+ или - или / или * или ^ ");
                    _operator = Console.ReadLine();
                    Console.WriteLine("Введите второе число: ");
                    X2 = Convert.ToDouble(Console.ReadLine());
                    switch (_operator)
                    {
                        case "+":
                            Console.WriteLine("result");
                            Console.WriteLine(X1 + X2);
                            break;
                        case "-":
                            Console.WriteLine("result");
                            Console.WriteLine(X1 - X2);
                            break;
                        case "*":
                            Console.WriteLine("result");
                            Console.WriteLine(X1 * X2);
                            break;
                        case "/":
                            Console.WriteLine("result");
                            Console.WriteLine(X1 / X2);
                            break;
                        case "^":
                            Console.WriteLine("result");
                            Console.WriteLine(Math.Pow(X1, X2));
                            break;
                    }


                }
                // Implement input of the number
                // Implement input the for circle to calculate factorial of the number
                // Output the result
            }
        }

        #endregion
    }
}
