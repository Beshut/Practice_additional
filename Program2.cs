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
            string myStr;//обьявление переменной типа string
            Console.WriteLine("Введите строку: ");//вывод на экран сообщения пользователю

            myStr = Console.ReadLine();//присваивание значения переменной от пользователя

            if (myStr.Length < 5)//условный оператор, выполняется если длина строки меньше 5
                Console.WriteLine("\nВ данной строке меньше 5 символов");//вывод на экран сообщения пользователю
            else if ((myStr.Length >= 5) && (myStr.Length <= 12))//условный оператор, выполняется если длина строки => 5 и длина строки <= 12
                Console.WriteLine("\nВ данной строке {0} символов", myStr.Length);//вывод на экран сообщения пользователю
            else Console.WriteLine("\nВ данной строке больше 12 символов");//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
