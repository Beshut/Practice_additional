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
            short d = 10, f = 12;//обьявление переменных типа short и присванивание им значения
            bool var1 = true, var2 = false;//обьявление переменных типа bool и присванивание им значения

            if (d < f)//условный оператор,выполняется если d < f
                Console.WriteLine("d < f");//вывод на экран сообщения пользователю
            if (d <= f)//условный оператор,выполняется если d <= f
                Console.WriteLine("d <= f");//вывод на экран сообщения пользователю
            if (d != f)//условный оператор,выполняется если d не равно f
                Console.WriteLine("d != f");//вывод на экран сообщения пользователю

            // Следующее условие не выполнится
            if (d > f)//условный оператор,выполняется если d > f
                Console.WriteLine("d > f");//вывод на экран сообщения пользователю

            // Сравниванием переменные var1 и var2
            if (var1 & var2)//условный оператор,выполняется если получили true
                Console.WriteLine("Данный текст не выведется");//вывод на экран сообщения пользователю
            if (!(var1 & var2))//условный оператор,выполняется если получили true
                Console.WriteLine("!(var1 & var2) = true");//вывод на экран сообщения пользователю
            if (var1 | var2)//условный оператор,выполняется если получили true
                Console.WriteLine("var1 | var2 = true");//вывод на экран сообщения пользователю
            if (var1 ^ var2)//условный оператор,выполняется если получили true
                Console.WriteLine("var1 ^ var2 = true");

            Console.ReadLine();//ожидание нажатия клавиши
        }

    }
}
