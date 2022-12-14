// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int size = new Random().Next(1, 10);

int[] RandomArray (int length)
{
    // creates an array of 3-digit numbers of a given length
    int[] array = new int[length];
    for(int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
    return array;
}

int CountEven (int[] arr)
{
    // counts quantity of even numbers in an array
    int result = 0;
    for(int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
            result++;
    return result;
}

void ShowArray(int[] array)
{
    // Show all elements of array
    Console.Write("Array:");
    for(int i = 0; i < array.Length; i++)
        Console.Write($" {array[i]}");
    Console.WriteLine();
}

int[] newArray = RandomArray(size);
ShowArray(newArray);
Console.WriteLine($"Count even elements: {CountEven(newArray)}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int size = new Random().Next(1, 10);

int[] RandomArray (int length)
{
    // creates an array with values from -999 to 999 of a given length
    int[] array = new int[length];
    for(int i = 0; i < length; i++)
        array[i] = new Random().Next(-999, 1000);
    return array;
}

int SummOddIndex (int[] arr)
{
    // find summ elements of odd Index of a given array
    int result = 0;
    for(int i = 0; i < arr.Length; i++)
        if (i % 2 == 1)
            result += arr[i];
    return result;
}

void ShowArray(int[] array)
{
    // Show all elements of array
    Console.Write("Array:");
    for(int i = 0; i < array.Length; i++)
        Console.Write($" {array[i]}");
    Console.WriteLine();
}

int[] newArray = RandomArray(size);
ShowArray(newArray);
Console.WriteLine($"Summ elements with odd positions: {SummOddIndex(newArray)}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

/*
int size = new Random().Next(1, 10);

double[] RandomArray (int length)
{
    // creates an array of random real numbers of an length
    double[] array = new double[length];
    for(int i = 0; i < length; i++)
        array[i] = new Random().Next(-999, 1000) + new Random().NextDouble();
    return array;
}

double DiffMaxMin (double[] arr)
{
    // finds the difference between the maximum and minimum values ​​of an array
    double result = 0;
    double min = arr[0];
    double max = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
        else if (arr[i] > max)
            max = arr[i];
    }
    result = max - min;
    return result;
}

void ShowArray(double[] array)
{
    // Show all elements of array
    Console.Write("Array:");
    for(int i = 0; i < array.Length; i++)
        Console.Write($" {array[i]}");
    Console.WriteLine();
}

double[] newArray = RandomArray(size);
ShowArray(newArray);
Console.WriteLine($"Difference between the maximum and minimum: {DiffMaxMin(newArray)}");
*/

