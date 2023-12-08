// Задача 1: 
// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива,
// значения которых лежат в отрезке [20,90].

// Выполнила Дарья Хан, 08/12/2023

int sum = 0;
int[] array = new int [10]; 

Console.Write ("Вот числа вашего массива: [ ");

for (int i=0; i<array.Length; i++)
{
    array[i]= new Random().Next(1, 101);
    Console.Write (array[i] + " ");
    
    if(array[i]>=20 && array[i]<91)
    {
        sum = sum + array[i];
    }
}
Console.Write ("]");
Console.WriteLine (" ");
Console.WriteLine ($"Искомая сумма значений в отрезке [20,90]: {sum}!");
