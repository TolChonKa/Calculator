using System;

namespace Calculator
{
    internal class Program
    {

        public class Operations
        {
            static double result;
            public static double[] massiv_volue = new double[1];
            public static double OperationsValue(double firstvalue, double secondvalue, string operation)
            {
                switch (operation)
                {
                    case "+":
                        result = firstvalue + secondvalue;
                        return result;
                    case "-":
                        result = firstvalue - secondvalue;
                        return result;
                    case "*":
                        result = firstvalue * secondvalue;
                        return result;
                    case "/":
                        result = firstvalue / secondvalue;
                        return result;
                    case "^":
                        result = Math.Pow(firstvalue, secondvalue);
                        return result;
                    default:
                        return 0;

                }

            }
            public static double Massiv(double[] massivchik)
            {
                for (int i = 0; i < massiv_volue.Length; i++)
                {
                    massiv_volue[i] = result;
                    return massivchik[i] = massiv_volue[i];

                }
                return 0;
            }

            public static double OperationEngener(double number, string operation)
            {
                switch (operation)
                {
                    case "sin":
                        result = Math.Sin(number);
                        return result;
                    case "cos":
                        result = Math.Cos(number);
                        return result;
                    case "tg":
                        result = Math.Tan(number);
                        return result;
                    case "arctg":
                        result = Math.Atan(number);
                        return result;
                    case "log":
                        result = Math.Log(number);
                        return result;
                    case "ln":
                        result = Math.Log10(number);
                        return result;
                    case "!":
                        result = Factorial(number);
                        return result;
                    case "1/x":
                        result = 1 / number;
                        return result;
                    case "exp":
                        result = Math.Exp(number);
                        return result;
                    default: return 0;
                }

            }
            static public double Factorial(double Volue)
            {
                double result = 1;
                for (int i = 1; i != Volue + 1; i++)
                {
                    result *= i;
                }
                return result;
            }
        }
        class Check
        {
            public static double _firstvalue, _secondvalue, number;
            public static double CheckVolue(string ReadVolue)
            {
                bool result = double.TryParse(ReadVolue, out _firstvalue);
                if (result == true)
                {
                    return _firstvalue;
                }
                else
                {
                    return 0;
                }
            }
            public static double CheckVolue2(string ReadVolue2)
            {
                bool result = double.TryParse(ReadVolue2, out _secondvalue);
                if (result == true)
                {
                    return _secondvalue;
                }
                else
                {
                    return 0;
                }
            }
            public static double CheckNumber(string ReadNumber)
            {
                bool result = double.TryParse(ReadNumber, out number);
                if (result == true)
                {
                    return number;
                }
                else
                {
                    return 0;
                }
            }
        }


        static void Main(string[] args)
        {
            Operations operations = new Operations();

            double ValueFromMassiv = 0;
            double[] massiv = new double[1];
            string operation;
            double result, firstvalue, secondvalue, number, result_number;


            Console.Write("Выберете какую операцию хотите выполнить (+, -, *, /, sin, cos, tg, arctg, log, ln, !, 1/x , exp, ^ : ");
            operation = Console.ReadLine();


            if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "^")
            {
                Console.Write("\nВведите первое число: ");
                string ReadVolue = Console.ReadLine();
                Check.CheckVolue(ReadVolue);
                firstvalue = Check._firstvalue;

                Console.Write("\nВведите второе число: ");
                string ReadVolue2 = Console.ReadLine();
                Check.CheckVolue2(ReadVolue2);
                secondvalue = Check._secondvalue;

                result = Operations.OperationsValue(firstvalue, secondvalue, operation);

                Console.WriteLine($"\nРезультат вычислений: {result}");
            }

            else
            {
                Console.Write("\nВведите число: ");
                string ReadNumber = Console.ReadLine();

                Check.CheckNumber(ReadNumber);
                number = Check.number;

                result_number = Operations.OperationEngener(number, operation);
                Console.WriteLine($"\nРезультат вычислений: {result_number}");
            }
            Console.WriteLine();
            while (true)
            {
                Console.Clear();
                Operations.Massiv(massiv);
                // Первое число с прошлой операции //
                for (int i = 0; i < massiv.Length; i++)
                {
                    ValueFromMassiv = massiv[i];
                }
                Console.WriteLine(ValueFromMassiv);
                Console.Write("Выберете какую операцию хотите выполнить (+, -, *, /, sin, cos, tg, arctg, log, ln, !, 1/x , exp, ^ : ");
                operation = Console.ReadLine();

                //Operations.Massiv(massiv);
                //// Первое число с прошлой операции //
                //for (int i = 0; i < massiv.Length; i++)
                //{
                //    ValueFromMassiv = massiv[i];
                //}


                if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "^")
                {


                    Console.Write("\nВведите число: ");
                    string ReadNumber = Console.ReadLine();

                    Check.CheckNumber(ReadNumber);
                    number = Check.number;

                    result = Operations.OperationsValue(ValueFromMassiv, number, operation);
                    Console.WriteLine($"\nРезультат вычислений: {result}");

                    Console.WriteLine();

                }
                else
                {

                    Console.Write("\nВведите число: ");
                    string ReadNumberTwo = Console.ReadLine();

                    Check.CheckNumber(ReadNumberTwo);
                    number = Check.number;

                    result_number = Operations.OperationEngener(number, operation);
                    Console.WriteLine($"\nРезультат вычислений: {result_number}");
                }

            }
        }

    }



}

