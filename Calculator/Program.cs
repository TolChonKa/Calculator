using System;

namespace Calculator
{
    internal class Program
    {

        public class Operations
        {
            //static string exception = "Ошибка! Выберете операцию, которая представлена.";
            static double result;
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
                    default: return 0;
                }
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
            string operation, time_variable;
            double result, firstvalue, secondvalue, number, result_number;


            Console.Write("Выберете какую операцию хотите выполнить (+, -, *, /, sin, cos, tg, arctg, log, ln, !, 1/x , exp, ^ : ");
            operation = Console.ReadLine();
            //if (time_variable == "+" || time_variable == "-" || time_variable == "*" || time_variable == "/" || time_variable == "^" || time_variable == "sin" || time_variable == "cos" || time_variable == "tg" || time_variable == "arctg" || time_variable == "ln" || time_variable == "!" || time_variable == "log" || time_variable == "1/x" || time_variable == "exp")
            //{
            //    operation = time_variable;
            //}
            //else
            //{
            //    Console.WriteLine("Ошибка! Введите операцию из списка.");
            //}

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











            //case "cos":
            //    result = firstvalue + secondvalue;
            //    return result;
            //case "tg":
            //    result = firstvalue - secondvalue;
            //    return result;
            //case "arctg":
            //    result = firstvalue * secondvalue;
            //    return result;
            //case "log":
            //    result = firstvalue / secondvalue;
            //    return result;
            //case "ln":
            //    result = firstvalue + secondvalue;
            //    return result;
            //case "!":
            //    result = firstvalue - secondvalue;
            //    return result;
            //case "1/x":
            //    result = firstvalue * secondvalue;
            //    return result;
            //case "exp":
            //    result = firstvalue / secondvalue;
            //    return result;

            //// 1 число
            //Console.Write("Введите первое число: ");
            //Check.check_one_volue = Console.ReadLine();
            //firstvalue = Check._firstvalue;


            //// 2 число
            //Console.Write("Введите второе число: ");
            //Check.check_two_volue = Console.ReadLine();
            //secondvalue = Check._secondvalue;




            //Console.Write("Введите операцию (+, -, *, /): ");
            //operation = Console.ReadLine();

            //var resultoperation = operations.Simple_Operations(_firstvalue, _secondvalue, operation);
            //Console.WriteLine(resultoperation);
            Console.ReadLine();
        }
    }
}
