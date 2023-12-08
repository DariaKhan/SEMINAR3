// Задача 3: Задайте массив из вещественных чисел 
// с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива. 

// Выполнила Дарья Хан, 08/12/2023

double[] digits = {2.2, 0.4, 9.11, 7.2, 78.98};
double max = digits[0];
double min = digits [0];

for (int i =0; i < digits.Length; i++) 
{
    if (digits [i] > max)
    {
        max = digits [i];
    }

    if (digits [i]<min)
    {
         min = digits [i];
    }
} 
Console.WriteLine ($"Разница между максимальным и минимальным элементами массива:{max-min}");
