/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Введите количество элементов в массиве:");
Random rnd = new Random();
int n = 0;
bool numberCheck = int.TryParse(Console.ReadLine(),out int n_size);
if (numberCheck)
{
    int[] n_array = new int[n_size];
    for (int i = 0; i < n_size; i++)
    {
        n_array[i] = rnd.Next(100, 999);
        if (n_array[i] % 2 == 0) n++;
    }
    Console.WriteLine("[" + String.Join(", ", n_array) + "] -> " + n);
}
else Console.WriteLine("не верно");