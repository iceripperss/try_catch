using System;

namespace Lecture8
{
    class Program
    {
        static void Main(string[] args)
        {
            bool forever = true;
            do
            {
                try
                {
                    Menu();
                    string operation = Console.ReadLine();
                    if (operation.Length >= 1 && operation.Length <= 3)
                    {
                        //Console.WriteLine("1st validation suceed");
                        if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "sum" || operation == "mul")
                        {
                            //Console.WriteLine("2nd validation suceed");
                            Operation(operation);
                        }
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
            while (forever);

        }
        public static void Operation(string operation)
        {
            try
            {

                switch (operation)
                {
                    case "+":
                        {
                            Console.WriteLine("num1:");
                            int num1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("num2:");
                            int num2 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine($"= {num1 + num2}");
                            break;
                        }
                    case "-":
                        {
                            Console.WriteLine("num1:");
                            int num1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("num2:");
                            int num2 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine($"= {num1 - num2}");
                            break;
                        }
                    case "*":
                        {
                            Console.WriteLine("num1:");
                            int num1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("num2:");
                            int num2 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine($"= {num1 * num2}");
                            break;
                        }
                    case "/":
                        {
                            Console.WriteLine("num1:");
                            int num1 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("num2:");
                            int num2 = Int32.Parse(Console.ReadLine());
                            Console.WriteLine($"= {num1 / num2}");
                            break;
                        }
                    case "sum":
                        {
                            try
                            {
                                Console.WriteLine("Enter arr length");
                                int length = Int32.Parse(Console.ReadLine());
                                int[] SummMass = new int[length];
                                Console.WriteLine("Now enter array numbers");
                                for (int index = 0; index < length; index++)
                                {
                                    Console.WriteLine(index);
                                    SummMass[index] = int.Parse(Console.ReadLine());
                                }
                                Console.WriteLine("El-s to sum");
                                int length1 = Int32.Parse(Console.ReadLine());
                                int sum = 0;
                                for (int index = 0; index < length1; index++)
                                {
                                    sum += SummMass[index];
                                }
                                Console.WriteLine($"= {sum}");
                                break;
                            }
                            catch (OverflowException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }
                            catch (IndexOutOfRangeException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }
                        }
                    case "mul":
                        {
                            try
                            {
                                Console.WriteLine("Enter arr length");
                                int length = Int32.Parse(Console.ReadLine());
                                int[] SummMass = new int[length];
                                Console.WriteLine("Now enter array numbers");
                                for (int index = 0; index < length; index++)
                                {
                                    Console.WriteLine(index);
                                    SummMass[index] = int.Parse(Console.ReadLine());
                                }
                                Console.WriteLine("El-s to sum");
                                int length1 = Int32.Parse(Console.ReadLine());
                                int mul = 0;
                                for (int index = 0; index < length1; index++)
                                {
                                    mul *= SummMass[index];
                                }
                                Console.WriteLine($"= {mul}");
                                break;
                            }
                            catch (OverflowException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }
                            catch (IndexOutOfRangeException ex)
                            {
                                Console.WriteLine(ex.Message);
                                break;
                            }
                        }
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Menu()
        {
            Console.WriteLine("[+], [-], [*], [/], [sum], [mul]");
        }
    }
}
