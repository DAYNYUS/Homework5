// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
// ВАЖНО!!! УЧИТЫВАТЬ оформление и названия переменных

int[] array = new int[4];
int sum = 0;
for (int i = 1; i < array.Length; i++)
{
    if(i%2 == 0) i++; 
    else 
    {
        sum = sum + array[i];
        i++;
    }
}

FillArrayRandomNumbers(array);
PrintArray(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях, равна {sum}");


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
        array[i] = new Random().Next(-99, 99);
    }
}

