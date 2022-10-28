using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Выводим числа кратные 5
            for (byte i = 1; i <= 100; i++)//условный оператор, выполняется пока
            {
                if (i % 5 != 0) continue;//условный оператор, выполняется если (i % 5 != 0, продолжает выполнение программы
                Console.Write("\t{0}", i);//вывод на экран сообщения пользователю
            }

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
