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
            int result; ;//обьявление переменной типа int

            // Реализуем функцию модуля числа
            for (int i = 5; i >= -5; i--)//условный оператор, выполняется пока i >= -5
            {
                result = i >= 0 ? i : -i;//присвоения переменной значения, тернарная операция
                Console.Write("{0}\t", result);//вывод на экран сообщения пользователю
            }

            Console.WriteLine("\n\n");//пропускает две строки вниз

            // Выбор четных чисел
            for (int i = 0; i < 10; i++)//условный оператор, выполняется пока i < 10
            {
                if (i % 2 == 0 ? true : false)//условный оператор, выполняется если i % 2 == 0, тернарная операция
                    Console.Write("{0}\t", i);//вывод на экран сообщения пользователю
            }

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
