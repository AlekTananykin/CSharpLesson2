using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /*
     * Тананыкин
     * 
     * Написать метод, возвращающий минимальное из трёх чисел.
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Программа нахождения минимального " +
                    "из трёх чисел");
                Console.WriteLine("Введите три целых числа");
                int number1 = ReadInteger("Первоее число: ");
                int number2 = ReadInteger("Второе число: ");
                int number3 = ReadInteger("Третье число: ");

                Console.WriteLine("Минимальное число {0}", 
                    MinNumber(number1, number2, number3));
            }
            catch (FormatException)
            {
                Console.WriteLine("Не верный формат введённого числа. ");
            }
            Console.WriteLine("Нажмите любую клавишу для завершения программы. ");
            Console.ReadKey();
        }

        private static int MinNumber(int number1, int number2, int number3)
        {
            if (number1 < number2)
                return Math.Min(number1, number3);

            return Math.Min(number2, number3);
        }

        private static int ReadInteger(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
    }
}
