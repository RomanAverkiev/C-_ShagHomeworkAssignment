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
            Console.WriteLine("Введите целое число");              // Просим пользователя ввести число
            string str = Console.ReadLine();                       // Ввод числа
            Int32 num;                                             // Создаем переменную типа int 

            // Проверка введенного значения
            if (StringIsDigits(str))                               // Введено целое число
            {
                num = Convert.ToInt32(str);                        // Конвертирование строки в число

                //Проверка диапозона
                if (num >= 1 && num <= 100)                        // Число соответствует диапозону
                {
                    // Проверка кратности числа
                    if (num % 3 == 0 && num % 5 == 0)              // Число кратно 5 и кратно 3
                        Console.WriteLine("Fizz Bizz");
                    else if (num % 3 == 0)                         // Число кратно 3       
                        Console.WriteLine("Fizz");
                    else if (num % 5 == 0)                         // Число кратно 5
                        Console.WriteLine("Bizz");
                    else                                          // Число не кратно 3 и 5
                        Console.WriteLine(num);
                }
                else                                              // Число не входит в диапозон
                    Console.WriteLine
                        (
                        $"Число {num} не входит в диапозон от 1 до 100"
                        );
            }
            else                                                  // Введено не целое число
                Console.WriteLine("Введено не десятичное число"); // Сообщение о неправильном вводе
        }

        /// <summary>
        /// Проверка значения на не цифровые символы
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static Boolean StringIsDigits(String str)
        {
            foreach (var item in str)
            {
                if (!char.IsDigit(item)) return false;            // Если в строке присутствует не числовой символ
            }
            return true;
        }
    }
}
