using System;
class Program
{
    static void Main(string[] args)
    {
        foreach (var s in "1 2 3".Split(' '))//оператор перебора элементов строки; использование метода Split, разделяет заданную строку на подстроки
            Console.WriteLine(s);//вывод на экран сообщения пользователю
        foreach (var s in "1 2 3-4-5-6".Split(new char[] { ' ', '-' }))//оператор перебора элементов строки; использование метода Split, разделяет заданную строку на подстроки
            Console.WriteLine(s);//вывод на экран сообщения пользователю
    }
}
