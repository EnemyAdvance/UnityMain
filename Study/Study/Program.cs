using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Основные типы int | float | char | string | bool
            //Целочисленные типы
            byte b; // 0 to 255
            sbyte sb; // -128 to 127
            short s; // -32768 to 32767
            ushort us; // 0 to 65535
            int i; // -2147483648 to 2147483647
            uint ui; // 0 to 4294672295
            long l = long.MaxValue;
            ulong ul = ulong.MaxValue;
            //Числа с плавающей точкой
            float f = 5.7f;
            double d = 5.7;
            //Символьный тип
            char c = 'a'; //Можно присвоить пробел
            //Строковый тип
            string str = "жопа";
            //Логический тип
            bool bl; //Проверка на условие, например true or false

            int DickSize;

            DickSize = 100;

            //Арифмитические операторы
            // + - * / %(деление)

            Console.WriteLine("Как тебя звать?");

            string pass = "Вова";
            string input = Console.ReadLine();

            if (input == pass)
            {
                Console.WriteLine("Вовикс сьел все тыквы в каменке");
            }
            else 
            {
                Console.WriteLine("Соси жопу");
            }          
        }
    }
}
