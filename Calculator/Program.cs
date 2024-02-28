using System;
using System.Threading;

namespace Calculator
{
    internal class Program
    {
        public class Operations
        {
            public static double result;
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
            //static public void AC_Programm(double Volue)
            //{
            //    Program._default = 
            //}
        }
        class Check
        {
            public static double Value;
            public static bool result;
            public static double CheckVolue(string ReadVolue)
            {
                result = double.TryParse(ReadVolue, out Value);
                if (result)
                {
                    return Value;
                }
                return 0;

            }

        }

        class Memory
        {
            static double[] MemoryResult = new double[1];

            public static void MemoryRead()
            {
                Console.WriteLine(MemoryResult[0]); 
            }

            public static void Memory_Addition_Deduction(string String_Read)
            {
                if (String_Read == "M+" || String_Read == "m+" || String_Read == "м+" || String_Read == "М+")
                {
                    MemoryResult[0] += Operations.result;
                }
                if (String_Read == "M-" || String_Read == "m-" || String_Read == "м-" || String_Read == "М-")
                {
                    MemoryResult[0] -= Operations.result;
                }
            }

            public static void Memory_Clear()
            {
                    MemoryResult[0] *= 0;
            }
        }

        static void Main(string[] args)
        {

           
            string[] massiv = new string[1];
            double _default = 0;
            double number = 0;
            double[] MR = new double[1];
            //double result, firstvalue, secondvalue, number, result_number;

            while (true)
            {
                var Value = Console.ReadLine();

                if (Value == "Clear" || Value == "clear" )
                {
                    Console.Clear();
                    Console.WriteLine(Operations.result);
                    continue;
                }

                if (Value == "MR" || Value == "mr" ||  Value == "мr" || Value == "Мr")
                {
                    Memory.MemoryRead();
                    continue;
                }

                if (Value == "M+" || Value == "m+" || Value == "м+" || Value == "М+")
                {
                    Memory.Memory_Addition_Deduction(Value);
                    continue;
                }

                if (Value == "M-" || Value == "m-" || Value == "м-" || Value == "М-")
                {
                    Memory.Memory_Addition_Deduction(Value);
                    continue;
                }

                if (Value == "MC" || Value == "mc" || Value == "мс" || Value == "МС")
                {
                    Memory.Memory_Clear();
                    continue;
                }


                if (Value == "+" || Value == "-" || Value == "*" || Value == "/" || Value == "^" || Value == "sin" || Value == "cos" || Value == "tan" || Value == "arctg" || Value == "exp" || Value == "log" || Value == "ln" || Value == "1/x" || Value == "!")
                {
                    for (int i = 0; i < massiv.Length; i++)
                    {
                        massiv[i] = Value;
                    }

                }

                Check.CheckVolue(Value);

                if (Value == "+" || Value == "-" || Value == "*" || Value == "/" || Value == "^")
                {
                    continue;
                }
                if (Check.result)
                {
                    number = Check.Value;
                }
                if (massiv[0] != null)
                {
                    if (massiv[0] == "+" || massiv[0] == "-" || massiv[0] == "*" || massiv[0] == "/" || massiv[0] == "^")
                    {
                        Operations.OperationsValue(_default, number, massiv[0]);

                    }
                    else { Operations.OperationEngener(_default, massiv[0]); }
                }

                _default = number;
                if (Value == "AC" || Value == "ac")
                {
                    _default = 0;
                    number = 0;
                    massiv[0] = null;
                    continue;
                }
                if (massiv[0] != null) { Console.WriteLine(Operations.result); _default = Operations.result; }
                

            }
        }
    }
}



