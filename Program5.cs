using System;
class Program
{
    static void Main(string[] args)
    {
        string s10 = "Area";//обьявление и заполнение переменной типа string
        string s11 = " 51";//обьявление и заполнение переменной типа string
        Console.WriteLine("Concat by +: " + s10 + s11);//вывод на экран сообщения пользователю
        Console.WriteLine("Concat by Concat(): " + string.Concat(s10, s11));//вывод на экран сообщения пользователю, использование метода Concat  для обьединения строк
        string[] sArr1 = { "First ", "Second ", "Third " };//обьявление и заполнение массива типа string
        Console.WriteLine(string.Concat(sArr1));//вывод на экран сообщения пользователю, использование метода Concat  для обьединения массива в строку
        string[] sArr2 = { "First", "Second", "Third" };//обьявление и заполнение массива типа string
        Console.WriteLine("Join elements in array by Join() with space: " + string.Join(" ", sArr2));//вывод на экран сообщения пользователю, использование метода Join для обьединения массива в строку
        Console.WriteLine("Join elements in array by Join() with <->: " + string.Join("<->", sArr2));//вывод на экран сообщения пользователю, использование метода Join для обьединения массива в строку, между словами ставится знак "<->"
    }
}
