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
            while (true)
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
                    Pause();
                    continue; // volta ao início do loop do menu
                }

                if (res == 0)
                    break; // sai do menu e encerra o programa

                switch (res)
                {
                    case 1: Add(); break;
                    case 2: Subtract(); break;
                    case 3: Divide(); break;
                    case 4: Multiply(); break;
                    default:
                        Console.WriteLine("\nInvalid option.");
                        Pause();
                        break; // volta ao menu (o while continua)
                }
            }
        }

        static void Add()
        {
            Console.Clear();

            float v1 = ReadFloat("Enter the first number: ");
            float v2 = ReadFloat("Enter the second number: ");

            float result = v1 + v2;

            Console.WriteLine($"\nThe result of addition is {result}\n");
            Pause(); // <— sem chamar Menu(); o while cuida disso
        }

        static void Subtract()
        {
            Console.Clear();

            float v1 = ReadFloat("Enter the first number: ");
            float v2 = ReadFloat("Enter the second number: ");

            float result = v1 - v2;

            Console.WriteLine($"\nThe result of subtraction is {result}\n");
            Pause();
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

            Pause();
        }

        static void Multiply()
        {
            Console.Clear();

            float v1 = ReadFloat("Enter the first number: ");
            float v2 = ReadFloat("Enter the second number: ");

            float result = v1 * v2;

            Console.WriteLine($"\nThe result of multiplication is {result}\n");
            Pause();
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

        static void Pause()
        {
            Console.WriteLine("Press any key to return to the menu...");
            Console.ReadKey(true);
        }
    }
}