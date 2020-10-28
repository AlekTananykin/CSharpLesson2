using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /*Тананыкин
     * 
     * Написать метод подсчета количества цифр числа.
     */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Программа подсчёта цифр в числе");
                Console.Write("Введите целое число: ");
                int number = int.Parse(Console.ReadLine());
                
                Console.WriteLine("В введённом числе {0} цифр(а)", 
                    DigitsCount(number));
            }
            catch (FormatException)
            {
                Console.WriteLine("Не верный формат числа");
            }

            Console.WriteLine(
                "Нажмите любую клавишу для завершения программы. ");
            Console.ReadKey();
        }

        private static int DigitsCount(int number)
        {
            int digitsCount = 0;
            do
            {
                number /= 10;
                ++digitsCount;
            }
            while (0 != number);
            return digitsCount;
        }

    }
}
