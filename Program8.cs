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
            // Обычный цикл for выводящий числа от 1 до 5
            Console.WriteLine("Обычный цикл for:");//вывод на экран сообщения пользователю
            for (int i = 1; i <= 5; i++)//условный оператор, выполняется пока i <= 5
                Console.Write("\t{0}", i);//вывод на экран сообщения пользователю

            // Реализуем то же самое с помощью оператора goto
            Console.WriteLine("\n\nА теперь используем goto:");//вывод на экран сообщения пользователю
            int j = 1;//обьявление переменной типа int, присваивается значение
        link1://подсчёт значения переменной link
            Console.Write("\t{0}", j);//обьявление переменной типа int, присваивается значение
            j++;//увеличивает значения переменной j на единицу
            if (j <= 5) goto link1;//условный оператор, блок выполняется пока j <= 5


            Console.ReadLine();//ожидание нажатия клавиши
        }
    }
}
