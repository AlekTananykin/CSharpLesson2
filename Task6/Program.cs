using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Тананыкин
 * 
 * *Написать программу подсчета количества «хороших» чисел в диапазоне 
 * от 1 до 1 000 000 000. «Хорошим» называется число, которое делится на сумму 
 * своих цифр. Реализовать подсчёт времени выполнения программы, используя 
 * структуру DateTime.
 */

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа выводит числа, " +
                "которые делятся на сумму своих цифр.");

            DateTime startTime = DateTime.Now;

            const int minNumber = 1;
            const int maxNumber = 100;

            for (int number = minNumber; number <= maxNumber; ++number)
            {
                if (0 == number % ProcessDigitsSum(number))
                    Console.WriteLine(
                        "Число {0} делится на сумму своих цифр.", number);
            }

            Console.WriteLine("\nВремя выполнения программы: {0}", 
                (DateTime.Now - startTime));

            Console.ReadKey();
        }

        private static int ProcessDigitsSum(int number)
        {
            int sum = 0;
            while (0 != number)
            {
                sum += number % 10;
                number /= 10;
            }
            
            return sum;
        }
    }
}
