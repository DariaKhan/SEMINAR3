// Задача 2: Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет 
// количество чётных чисел в массиве.

// Выполнила Дарья Хан, 08/12/2023

int[] digit = new int [10];
int qty_even = 0;

Console.Write ("Вот числа вашего массива: [ ");
for (int i=0; i<digit.Length; i++)
{
    digit [i] = new Random().Next(0,51);
    Console.Write (digit[i] + " ");

    if (digit [i]%2 == 0) 
    {
        qty_even = qty_even + 1;
    } 
}
Console.Write ("]");
Console.WriteLine (" ");
Console.WriteLine ($"Количество чётных чисел в массиве: {qty_even}");