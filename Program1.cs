using System;
using System.Text.RegularExpressions;

namespace calculator1_brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите выражение  пример-(4+6+7)");
            const char action = '+';
            string str = Console.ReadLine();
            //выделяется выражение в скобках
            string[] strs = Regex.Split(str, @"\((.*?)\)");
            var sum = 0;
            // reg присваивается первый элемент массива (строка в скобках)
            string reg = strs[1];
            // создается массив из чисел строки
            string[] digits = Regex.Split(reg, @"(\d+|-\d+)");
            // в цикле производится арифметические апирации с каждым элементом массива digits
            foreach (string value in digits)
            {

                int number;
                if (int.TryParse(value, out number))
                {
                    switch (action)
                    {
                        case '+':
                            sum += int.Parse(value);
                            break;
                        case '-':
                            sum -= int.Parse(value);
                            break;
                        case '*':
                            sum *= int.Parse(value);
                            break;
                        case '/':
                            sum /= int.Parse(value);
                            break;
                    }
                 
                    Console.WriteLine(value);
                }
            }
            Console.WriteLine(sum);
        }
    }
}
