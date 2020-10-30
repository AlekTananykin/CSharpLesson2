using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Тананыкин
 * 
 * 
 * а) Написать программу, которая запрашивает массу и рост человека, вычисляет 
 * его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес 
 * или всё в норме.
 * б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для 
 *  нормализации веса.
 */

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа расчёта индекса массы тела\r\n");

            try
            {
                double weight = ReadDoubleValue(
                    "Введите вес человека в килограммах: ");
                double height = ReadDoubleValue(
                    "Введите рост человека в сантиметрах: ");

                Console.WriteLine("\n--------------------------------");
                Console.WriteLine(ToMakeConclusion(height, weight));

            }
            catch (FormatException)
            {
                Console.WriteLine("Не верный формат числа. ");
            }

            Console.WriteLine(
               "\nНажмите любую клавишу для завершения программы. ");
            Console.ReadKey();
        }

        static double ReadDoubleValue(string message)
        {
            Console.Write(message);
            return double.Parse(Console.ReadLine());
        }

        static double ProcessHmi(double weight, double height)
        {
            return weight / (height * height) * 10000.0;
        }

        static string ToMakeConclusion(double height, double weight)
        {
            double hmi = ProcessHmi(weight, height);

            StringBuilder conclusion = new StringBuilder();
            conclusion.Append(String.Format(
                "Индекс массы человека: {0:F2}\n", hmi));
            
            const double lowerHmi = 18.5;
            const double upperHmi = 25.0;

            if (hmi <= lowerHmi)
            {
                conclusion.Append(String.Format("Недостаточная масса тела. \n" +
                    "Необходимо поправиться хотя бы на {0} (кг).", 
                    ProcessDeltaWeight(upperHmi, height, weight)));
            }
            else if (hmi <= upperHmi)
            {
                conclusion.Append("Вес в норме.");
            }
            else
            {
                conclusion.Append(String.Format("Избыточная масса тела. \n" +
                    "Необходимо похудеть хотя бы на {0} (кг).", 
                    ProcessDeltaWeight(upperHmi, height, weight)));
            }

            return conclusion.ToString();
        }

        static int ProcessDeltaWeight(double hmi, 
            double actualHeight, double actualWeight)
        {
            double borderWeight = hmi * actualHeight * 
                actualHeight / 10000.0;

            return (int) Math.Ceiling(Math.Abs(actualWeight - borderWeight));
        }
    }
}
