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
            // Пример возведения числа в несколько степеней
            byte l = 2, i = 0;//обьявление переменных типа byte и присванивание им значения
            int result = 1;//обьявление переменной типа int и присванивание ей значения

            while (i < 10)//условный оператор, выполняется пока i < 10
            {
                i++;//увеличивает значение i на единицу
                result *= l;//присваивает переменной result значения result умноженного на l
                Console.WriteLine("{0} в степени {1} равно {2}", l, i, result);//вывод на экран сообщения пользователю
            }

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
