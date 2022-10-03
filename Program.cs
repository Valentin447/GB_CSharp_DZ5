void Task34()
{
    // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

}
void Task36()
{

}
void Task38()
{

}
void FillArray(int[] arr)
{
    Random random = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-99, 100);
    }
}
void ShowArray(int[] arr)
{
    Console.Write("{");
    for(int i = 0; i < arr.Length; i++)
    {   
        if(i + 1 !=  arr.Length)
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
Task34();
//Task36();
//Task38();