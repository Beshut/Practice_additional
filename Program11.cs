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
            int result = Sum(230);//применение рекурсивной функции
            Console.WriteLine("Сумма четных чисел от 1 до 230 равна: " + result);//вывод на экран сообщения пользователю

            Console.ReadLine();//ожидание нажатия клавиши
        }

        // Метод, возращающий сумму всех четных чисел
        // от 1 до s
        static int Sum(int s)//вид рекурсивной функции и её выполнение
        {
            int mySum = 0;//обьявление переменной типа int и присвоение значения
            for (int i = 1; i <= s; i++)//условный оператор, выполняется пока i <= s
                if (i % 2 == 0)//условный оператор, выполняется если i % 2 == 0
                    mySum += i;//присваивает переменной mySum значения переменной mySum сложенной с переменной i
            return mySum;//условный оператор, завершает выполнение метода и возвращает значение переменной mySum
        }
    }
}
