//Задача 4. 
//Дано натуральное число в диапазоне от 1 до 100 000. 
//Создайте массив, состоящий из цифр этого числа. 
//Старший разряд числа должен располагаться на 0-м индексе 
//массива, младший – на последнем. 
//Размер массива должен быть равен количеству цифр.


// Генерируем случайное число
int number = new Random().Next(1, 100001);
Console.WriteLine ($"Ваше случайное число: {number}");

// Задаем нужные нам переменные
int number_aux = number;
int digit_order = 0;

// Узнаем разряд сгенерированного числа

while (number_aux>0)
{
    number_aux = number_aux/10;
    digit_order = digit_order+1;
}
Console.WriteLine ($"Число разрядов числа: {digit_order}");

// Создаем массив

int [] array = new int [digit_order];

// Заполняем массив в обратном порядке

Console.Write ($"Массив в обратном порядке:   [ ");
for (int i = 0; i<digit_order; i++)
{
    array [i] = number%10;
    number = number/10;
    Console.Write (array [i] + " ");
}
Console.Write ("]");
Console.WriteLine (" ");

// Заполняем массив в правильном порядке

for (int i = 0; i<array.Length/2; i++)
{
    int temp = array [i];
    array [i] = array [array.Length-1-i];
    array[array.Length-i-1] = temp;
}

// Выводим массив на печать в правильном порядке

Console.Write ($"Массив в правильном порядке: [ ");
for (int i = 0; i<array.Length; i++)
{
    Console.Write (array [i] + " ");
}
Console.Write ("]");
