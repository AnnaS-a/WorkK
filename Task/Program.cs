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

