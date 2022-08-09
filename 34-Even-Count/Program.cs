/*
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
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

int GetEvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;

    return count;
}

int[] array = CreateRandomArray(new Random().Next(10, 20), 100, 999);
ShowArray(array);
Console.WriteLine($"Количество чётных чисел в массиве: {GetEvenCount(array)}");
