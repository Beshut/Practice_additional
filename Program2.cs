using System;
class Program
{
    static int[] temporaryArray;//обьявление рекурсивной функции

    static void Merge(int[] array, int start, int middle, int end)//обьявление рекурсивной функции
    {
        var leftPtr = start;//обьявление и присвоение значения переменной
        var rightPtr = middle + 1;//обьявление и присвоение значения переменной
        var length = end - start + 1;//обьявление и присвоение значения переменной
        for (int i = 0; i < length; i++)//условный оператор, выполняется пока i < length
        {
            if (rightPtr > end(leftPtr <= middle && array[leftPtr] < array[rightPtr]))//условный оператор, выполняется если rightPtr > end  (leftPtr <= middle && array[leftPtr] < array[rightPtr])
            {
                temporaryArray[i] = array[leftPtr];//присвоение значения элемента массива
                leftPtr++;//увеличение переменной на единицу
            }
            else//выполняетя в противном случае оператора if
            {
                temporaryArray[i] = array[rightPtr];//присвоение значения элемента массива
                rightPtr++;//увеличение переменной на единицу
            }
        }
        for (int i = 0; i < length; i++)//условный оператор, выполняется пока i < length
            array[i + start] = temporaryArray[i];//присвоение значения элемента массива
    }

    static void MergeSort(int[] array, int start, int end)//обьявление рекурсивной функции
    {
        if (start == end) return;//условный оператор, выполняется если start == end; завершает выполнение блока программы
        var middle = (start + end) / 2;//обьяление и присвоение значения переменной
        MergeSort(array, start, middle);//использование рекурсивной функции
        MergeSort(array, middle + 1, end);//использование рекурсивной функции
        Merge(array, start, middle, end);//использование рекурсивной функции

    }

    static void MergeSort(int[] array)//обьявление рекурсивной функции
    {
        temporaryArray = new int[array.Length];//создание нового массива
        MergeSort(array, 0, array.Length - 1);//применение рекурсивной функции
    }

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
        MergeSort(array);//использование рекурсивной функции
        foreach (var e in array)//оператор перебора элементов массива
            Console.WriteLine(e);//вывод на экран сообщения пользователю
        Console.ReadKey();//ожидание нажатия клавиши
    }
}
