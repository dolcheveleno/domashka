/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3,21 7,04 22,93 -2,71 78,24] -> 75,53
*/

Console.WriteLine("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
double[] array = new double[N]; 
FillArray(array);
PrintArray(array);
double max = Max(array);
double min = Min(array);
double dif = max - min;
Console.WriteLine($"Pазницa между максимальным ({max}) и минимальным ({min}) значением равна {dif}");

void FillArray(double[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
        arr[i] = random.NextDouble() * 200 - 100;  
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine($"arr[{i}] = {arr[i]}");
}


double Min(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
            min = arr[i];
    }
    return min;
}

double Max(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
    }
    return max;
}