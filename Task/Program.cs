// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина, которых меньше или равна три символа.
Console.Clear();

Console.WriteLine("Введите любые четыре значения через пробел");

string[] GetArray(int size)
{
    string[] array = new string[size];
    string[] element = Console.ReadLine().Split(' ');
    for (int i = 0; i < size; i++)
    {
        array[i] = element[i];
    }
    return array;
}

void PrintArray(object[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
    Console.Write("] -> ");
}

