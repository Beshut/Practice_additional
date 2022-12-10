using System;
class Program
{
    private static void BubbleSort(int[] array)//обьявление рекурсивной функции
    {
        for (int i = 0; i < array.Length; i++)//условный оператор, выполняется пока i < array.Length
            for (int j = 0; j < array.Length - 1; j++)//условный оператор, выполняется пока j < array.Length
                if (array[j] > array[j + 1])//условный оператор, выполняется если array[j] > array[j + 1]
                {
                    int t = array[j + 1];//обьявление и присвоение значения переменной
                    array[j + 1] = array[j];//присвоение значения элемента массива
                    array[j] = t;//присвоение значения элемента массива
                }
    }

    public static void Main()
    {
        int[] array = {//обьявление и заполнение массива
        5,
        3,
        4,
        9,
        7,
        2,
        1,
        8,
        6
    };
        BubbleSort(array);//использование рекурсивной функции
        foreach (int e in array)//оператор перебора элементов массива
            Console.WriteLine(e);//вывод на экран сообщения пользователю

        Console.ReadKey();//ожидание нажатия клавиши
    }
}
