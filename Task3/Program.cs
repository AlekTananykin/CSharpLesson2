using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Тананыкин
 * 
 * С клавиатуры вводятся числа, пока не будет введен 0. 
 * Подсчитать сумму всех нечетных положительных чисел.
 */

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчёта суммы нечётных " +
                "положительных чисел");

            try
            {
                int number = 0;
                int sum = 0;
                while (true)
                {
                    Console.Write("Введите число (введите число 0 для выхода):");
                    number = int.Parse(Console.ReadLine());
                    if (0 == number)
                        break;

                    if (0 < number && 1 == number % 2)
                        sum += number;
                }
                
                Console.WriteLine("Сумма введённых нечётных " +
                    "положительных чисел равна: {0}. ", sum);
            }
            catch (FormatException)
            {
                Console.WriteLine("Не верный формат числа. ");
            }
            Console.WriteLine(
               "Нажмите любую клавишу для завершения программы. ");
            Console.ReadKey();
        }
    }
}
