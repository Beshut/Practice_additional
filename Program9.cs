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
            // В данном цикле выведутся числа от 1 до 5 вместо 100
            for (int i = 1; i < 100; i++)//условный оператор, выполняется пока i < 100
                if (i <= 5)//условный оператор, выполняется если i <= 5
                    Console.WriteLine(i);//вывод на экран переменной i пользователю
                else break;//выполняется в случая не выполнения блока if, завершение выполнение блока команд

            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
