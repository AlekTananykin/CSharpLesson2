using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * a) Разработать рекурсивный метод, который выводит на экран 
 * числа от a до b(a<b).
 * б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
 * 
 */

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два целых числа A и B (A < B)");
            try
            {
                int num1 = ReadInteger("A: ");
                int num2 = ReadInteger("B: ");

                if (num2 <= num1)
                    throw new Exception("Не выполнено условие (A < B)");

                Console.WriteLine(
                    "\nДиапазон введённых чисел от {0} до {1}(не включая):", num1, num2);
                PrintRange(num1, num2);

                Console.WriteLine("\nСумма чисел от {0} до {1} равна {2}", 
                    num1, num2, ProcessSum(num1, num2));
            }
            catch (FormatException)
            {
                Console.WriteLine("Не верный формат вводимого числа");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Для завершения программы нажмите любую клавишу");
            Console.ReadKey();
        }

        private static int ProcessSum(int num1, int num2)
        {
            if (num1 == num2)
                return 0;

            return num1 + ProcessSum(num1 + 1, num2);
        }

        private static void PrintRange(int num1, int num2)
        {
            Console.WriteLine(num1++);
            if (num1 < num2)
                PrintRange(num1, num2);
        }

        private static int ReadInteger(string msg)
        {
            Console.Write(msg);
            return int.Parse(Console.ReadLine());
        }
    }
}
