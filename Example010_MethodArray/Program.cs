﻿int[] array = { 1, 12, 31, 14, 8, 15, 0, 18, 16, 17, 18 };

int n = array.Length; // определение длинны массива (количества элементов)
int find = 18; //задаем что будем скать (какую величины, это  могут быть и строки)

int index = 0;

while (index < n)  // от нулевого элемента, до n
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; // принудительная остановка после нахождения первого же элемента сответсвующего <find> значения
    }
    //index = index + 1;
    index++;
}
