/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.WriteLine("Задайте массив: ");
int[] array;
array = new int[10];
int i = 0;
int sum = 0;
Random random = new Random();
while (i < array.Length)
{
    array[i] = random.Next(-100, 100);
    Console.WriteLine(array[i]);
    i++;
}
for (i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) 
    sum = sum + array[i];
}
Console.WriteLine($"Сумма нечётных элементов: {sum}");
Console.ReadKey();