using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();

            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine("1 - Add");
            Console.WriteLine("2 - Subtract");
            Console.WriteLine("3 - Divide");
            Console.WriteLine("4 - Multiply");
            Console.WriteLine("0 - Exit");

            Console.Write("\nChoose an option: ");

            if (!short.TryParse(Console.ReadLine(), out short res))
            {
                Console.WriteLine("\nInvalid option.");
                Console.ReadKey();
                Menu();
                return;
            }

            switch (res)
            {
                case 1: Add(); break;
                case 2: Subtract(); break;
                case 3: Divide(); break;
                case 4: Multiply(); break;
                case 0: Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void Add()
        {
            Console.Clear();

            float v1 = ReadFloat("Enter the first number: ");
            float v2 = ReadFloat("Enter the second number: ");

            float result = v1 + v2;

            Console.WriteLine($"\nThe result of addition is {result}\n");
            Console.ReadKey();

            Menu();
        }

        static void Subtract()
        {
            Console.Clear();

            float v1 = ReadFloat("Enter the first number: ");
            float v2 = ReadFloat("Enter the second number: ");

            float result = v1 - v2;

            Console.WriteLine($"\nThe result of subtraction is {result}\n");
            Console.ReadKey();

            Menu();
        }

        static void Divide()
        {
            Console.Clear();

            float v1 = ReadFloat("Enter the first number: ");
            float v2 = ReadFloat("Enter the second number: ");

            if (v2 == 0)
            {
                Console.WriteLine("\nError: cannot divide by zero.");
            }
            else
            {
                float result = v1 / v2;
                Console.WriteLine($"\nThe result of division is {result}\n");
            }

            Console.ReadKey();
            Menu();
        }

        static void Multiply()
        {
            Console.Clear();

            float v1 = ReadFloat("Enter the first number: ");
            float v2 = ReadFloat("Enter the second number: ");

            float result = v1 * v2;

            Console.WriteLine($"\nThe result of multiplication is {result}\n");
            Console.ReadKey();

            Menu();
        }

        static float ReadFloat(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (float.TryParse(Console.ReadLine(), out float value))
                    return value;

                Console.WriteLine("Not a valid number. Try again.");
            }
        }
    }
}