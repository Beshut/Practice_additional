using System;
class Program
{
    static void HoareSort(int[] array, int start, int end)//обьявление рекурсивной функции
    {
        if (end == start) return;//условный оператор, выполняется если end == start; завершение выполнение блока программы
        var pivot = array[end];//обьявление и присвоение значения переменной
        var storeIndex = start;//обьявление и присвоение значения переменной
        for (int i = start; i <= end - 1; i++)//условный оператор, выполняется пока i <= end - 1
            if (array[i] <= pivot)//условный оператор, выполняется если array[i] <= pivot
            {
                var t = array[i];//обьявление и присвоение значения переменной
                array[i] = array[storeIndex];//присвоение значения элемента массива
                array[storeIndex] = t;//присвоение значения элемента массива
                storeIndex++;//увеличение значения переменной на единицу
            }

        var n = array[storeIndex];//обьявление и присвоение значения переменной
        array[storeIndex] = array[end];//присвоение значения элемента массива
        array[end] = n;//присвоение значения элемента массива
        if (storeIndex > start) HoareSort(array, start, storeIndex - 1);//условный оператор, выполняется если storeIndex > start; использование рекурсивной функции
        if (storeIndex < end) HoareSort(array, storeIndex + 1, end);//условный оператор, выполняется если storeIndex < end; использование рекурсивной функции
    }

    static void HoareSort(int[] array)//обьявление рекурсивной функции
    {
        HoareSort(array, 0, array.Length - 1);//использование рекурсивной функции
    }

    static Random random = new Random();//инициализация нового экземпляра класса Random

    public static void Main()
    {
        int[] array = {//обьявление и заполнение массива
        3,
        2,
        5,
        7,
        8,
        1,
        9
    };
        HoareSort(array);//использование рекурсивной функции
        foreach (var e in array)//оператор перебора элементов массива
            Console.WriteLine(e);//вывод на экран сообщения пользователю
        Console.ReadKey();//ожидание нажатия клавиши
    }
}
