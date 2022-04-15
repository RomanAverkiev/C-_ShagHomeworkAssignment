/*
   Пользователь вводит с клавиатуры число в диапа-
зоне от 1 до 100. Если число кратно 3 (делится на 3 без
остатка) нужно вывести слово Fizz. Если число кратно 5
нужно вывести слово Buzz. Если число кратно 3 и 5 нужно
вывести Fizz Buzz. Если число не кратно не 3 и 5 нужно
вывести само число.
Если пользователь ввел значение не в диапазоне от 1
до 100 требуется вывести сообщение об ошибке.
 */

using System;

namespace MultiplicityOfNumber
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            String str = Console.ReadLine();
            Int32 num;

            if (StringIsDigits(str))
                num = Convert.ToInt32(str);
            else
                Console.WriteLine("Введено не десятичное число");
        }

        static bool StringIsDigits(String str)
        {
            foreach (var item in str)
            {
                if (!char.IsDigit(item)) return false;
            }
            return true;
        }
    }
}
