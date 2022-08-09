/*
Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.
*/

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(min, max + 1);

    return array;
}

void ShowArray(int[] array)
{
    Console.Write("Массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(" " + array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine();
}

int GetDifference(int[] array)
{
    return array[GetMaxIndex(array)] - array[GetMinIndex(array)];
}

int GetMaxIndex(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > array[max]) max = i;

    return max;
}

int GetMinIndex(int[] array)
{
    int min = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] < array[min]) min = i;

    return min;
}

int[] array = CreateRandomArray(new Random().Next(10, 20), 0, 99);
ShowArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементом равна {GetDifference(array)}");