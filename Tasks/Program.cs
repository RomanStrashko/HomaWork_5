// Задача 1. Задайте массив заполненый случайными положительными трехзначными числами. Напишите программу, которая покажет количество четных чисел в массиве.

/*int[] array = GetArray(8, 100, 999);
Console.WriteLine($"[{String.Join(", ", array)}] -> Количество четных чисел {Coun()}");

int Coun()
{
    int count = 0;
 for(int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    count++;
}
return count;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/


// Задайте одномерный массив, заполненый случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.

/*int[] array = GetArray(10, -10, 10);
Console.WriteLine($"[{String.Join(", ", array)}] -> Сумма элементов на нечетных позициях {Num()}");

int Num()
{
    int Sum = 0;
    for(int i = 0; i < array.Length; i++)
{
    if(i % 2 == 1)
    Sum += array[i];
    
}
return Sum;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/
