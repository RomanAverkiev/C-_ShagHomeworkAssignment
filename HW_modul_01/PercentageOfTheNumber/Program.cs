/*
     Пользователь вводит с клавиатуры два числа. Первое
   число — это значение, второе число процент, который
   необходимо посчитать. Например, мы ввели с клавиатуры
   90 и 10. Требуется вывести на экран 10 процентов от 90.
   Результат: 9. 
 */

using System;

namespace PercentageOfTheNumber
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число"); // Просим ввести число
            String StrNumber = Console.ReadLine(); // Ввод числа
            Double Number = StringConversion(StrNumber); // Конвертируем  и присваиваем значение

            // Проверка нулевых значений
            if( Number == 0 || StrNumber == null)
            {
                CheckInputValue(StrNumber, Number);
                return;
            }

            Console.WriteLine("Введите высчитывемый процент");  // Просим ввести высчитываемый процент
           String StrInsert = Console.ReadLine(); // Ввод значения
            Double CalcInserts = StringConversion(StrInsert); // Вычисляемый процент

            // Проверка нулевых значений
            if(StrInsert == null || CalcInserts == 0)
            {
                CheckInputValue(StrInsert, CalcInserts);
                return;
            }

            InterestCalculation(Number, CalcInserts);
        }

        /// <summary>
        /// Проверк и конвертированние строки в тип Double
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static Double StringConversion( String Str)
        {
            //Проверка строки
            if(!Double.TryParse(Str, out Double result)) // Строка не числовое значение
            {
                return 0;
            }

            return result;

        }

        /// <summary>
        /// Проверка ввода значения
        /// </summary>
        /// <param name="Str"></param>
        /// <param name="Value"></param>
        static void CheckInputValue(String Str, Double Value)
        {
            // Проверка на ввод значения
            if (Str != null) // Значение введено
            {

                if (Value == 0)  // Значение равно нулю
                {
                    if (Str == Convert.ToString(Value)) // Введен ноль
                    {
                        Console.WriteLine
                            (
                            $" невозможно посчитать процент"
                            );
                        return;
                    }
                    else  // Введено не коректное значение
                    {
                        Console.WriteLine("Неправельный ввод числа");
                        return;
                    }
                }

            }
            else   // Значение не введено
            {
                Console.WriteLine("Число не введено");
                return;
            }
        }

        /// <summary>
        /// Расчет процента
        /// </summary>
        /// <param name="Number"></param>
        /// <param name="Insert"></param>
        static void InterestCalculation(Double Number, Double Insert)
        {
            Console.WriteLine((Number / 100) * Insert);
        }
    }
}