void Task34()
{
    // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, 100, 999);
    ShowArray(numbers);
    Console.WriteLine();
    int chet = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            chet++;
        }
    }
    Console.WriteLine("Четных чисел: " + chet);
}
void Task36()
{
    // Задача 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.

    int size = 10;
    int[] numbers = new int[size];
    FillArray(numbers, -99, 99);
    ShowArray(numbers);
    Console.WriteLine();
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + numbers[i];
        }
    }
    Console.WriteLine("Сумма элементов с не четными индексами равна: " + sum);
}
void Task38()
{
    // Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

    int size = 10;
    double[] numbers = new double[size];
    Random random = new Random();
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(random.Next(-9999, 10000)) / 100;
    }
    ShowArrayDouble(numbers);
    Console.WriteLine();
    double max = GetMax(numbers);
    double min = GetMin(numbers);
    Console.WriteLine($"max = {max}, min = {min}, differenc = {max - min}");
}

void FillArray(int[] arr, int min, int max)
{
    max++;
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max);
    }
}
void ShowArray(int[] arr)
{
    Console.Write("{");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i + 1 != arr.Length)
        {
            Console.Write(arr[i] + ", ");
        }
        else
        {
            Console.Write(arr[i]);
        }
    }
    Console.Write("}");
}
void ShowArrayDouble(double[] arr)
{
    Console.Write("{");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i + 1 != arr.Length)
        {
            Console.Write(arr[i] + "  ");
        }
        else
        {
            Console.Write(arr[i]);
        }
    }
    Console.Write("}");
}
double GetMax(double[] arr)
{
    double max = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max){
            max = arr[i];
        }
    }
    return max;
}
double GetMin(double[] arr)
{
    double min = arr[0];
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min){
            min = arr[i];
        }
    }
    return min;
}
//Task34();
//Task36();
Task38();