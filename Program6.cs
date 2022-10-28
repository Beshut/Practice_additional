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
            try//условный оператор, проверка кода на исключения
            {
                // Вычисляем факториал числа
                int i, result = 1, num = 1;//обьявление переменных типа int и присванивание им значения

                Console.WriteLine("Введите число:");//вывод на экран сообщения пользователю
                i = int.Parse(Console.ReadLine());//присваивание значения переменной от пользователя

                Console.Write("\n\nФакториал {0} = ", i);//вывод на экран сообщения пользователю
                do//блок выполнение цикла
                {
                    result *= num;//присваивает переменной result значения result умноженного на num
                    num++;//увеличивает значение num на единицу
                } while (num <= i);//проверка условаия, пока num <= i цикл выполняется

                Console.Write(result);//вывод на экран переменной result
            }
            catch (FormatException ex)//условный оператор, обработка возможных исключений
            {
                Console.WriteLine("Вы ввели не число. {0}", ex.Message);//вывод на экран сообщения пользователю
            }
            finally//условный оператор, выполнение программы в случае ошибки
            {
                Console.ReadLine();//ожидание нажатия клавиши
            }
        }
    }
}
