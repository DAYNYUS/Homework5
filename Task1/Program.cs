// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
// ВАЖНО!!! УЧИТЫВАТЬ оформление и названия переменных

int[] array = new int[4];
FillArrayRandomNumbers(array);
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i]%2 == 0) count++; 
}

Console.WriteLine($"В данном массиве количество четных чисел равно {count}");


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 999);
    }
}