using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

/*Тананыкин
 * 
 * Реализовать метод проверки логина и пароля. На вход метода подается логин и 
 * пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел 
 * (Логин: root, Password: GeekBrains). Используя метод проверки логина и 
 * пароля, написать программу: пользователь вводит логин и пароль, программа 
 * пропускает его дальше или не пропускает. С помощью цикла do while ограничить 
 * ввод пароля тремя попытками.
 */

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа проверки пароля. ");
            int autorizeTryCount = 3;
            string expectedLogin = "root";
            string expectedPassword = "GeekBrains";

            try
            {
                if (Autorization(
                    expectedLogin, expectedPassword, autorizeTryCount))
                    Console.WriteLine("\r\nВы авторизованы. ");
                else
                    Console.WriteLine("\r\nВы не авторизованы. ");

            }
            catch (FormatException ex)
            {
                Console.WriteLine("\r\n");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(
                "\r\nНажмите любую клавишу для завершения программы. ");
            Console.ReadKey();
        }

        private static string ReadText(string textToPrint)
        {
            Console.Write(textToPrint);
            return Console.ReadLine();
        }

        static string ReadPassword(string textToPrint)
        {
            Console.Write(textToPrint);
            StringBuilder passwd = new StringBuilder();
            
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                if (ConsoleKey.Enter == key.Key)
                    break;

                char ch = key.KeyChar;
                if (Char.IsControl(ch))
                    throw new FormatException("Недопустимый символ в пароле.");

                Console.Write('*');
                passwd.Append(ch);
            }
            Console.WriteLine();
            return passwd.ToString();
        }

        private static bool Autorization(string expectedLogin,
            string expectedPassword, int autorizeTryCount)
        {
            while (0 < autorizeTryCount--)
            {
                Console.WriteLine();
                string login = ReadText("Логин: ");
                string password = ReadPassword("Пароль: ");

                if (expectedLogin == login && expectedPassword == password)
                    return true;

                if (0 < autorizeTryCount)
                    Console.WriteLine(
                        CreateWrongPassMessage(autorizeTryCount));
            }
            return false;
        }

        private static string CreateWrongPassMessage(int autorizeTryCount)
        {
            StringBuilder message = new StringBuilder();
            message.Append("\r\nНе верный логин или пароль. ");

            if (1 == autorizeTryCount)
                message.Append("Осталась ещё 1 попытка.");
            else
                message.Append(String.Format("Осталось ещё {0} попытки.", 
                    autorizeTryCount));
            
            return message.ToString();
        }
    }
}
