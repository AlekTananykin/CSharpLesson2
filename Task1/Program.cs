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
                Console.Write("Введите три целых числа \r\nПервоее число: ");
                int number1 = int.Parse(Console.ReadLine());
                Console.Write("Второе число: ");
                int number2 = int.Parse(Console.ReadLine());
                Console.Write("Третье число: ");
                int number3 = int.Parse(Console.ReadLine());

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
    }
}
