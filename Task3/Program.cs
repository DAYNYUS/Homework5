// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// ВАЖНО!!! УЧИТЫВАТЬ оформление и названия переменных

Console.WriteLine("Задайте размер массива вещественных чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] FillSourceArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

PrintDiffMaxMin(FillSourceArray(size));
Console.WriteLine();

void PrintDiffMaxMin(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min();
    Console.WriteLine($"Максимальное значение массива {arr.Max()}, Минимальное значение массива {arr.Min()}");
    Console.WriteLine($"Разница между минимальным и максимальным элементом массива составляет {difference}");
}
