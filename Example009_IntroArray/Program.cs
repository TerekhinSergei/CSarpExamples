int Max(int arg1, int arg2, int arg3) // int в начале определяет возвращаемое значение, в нашем случае целое число
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
/* прямое решение из Examples008
int a1 = 125;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 231;
int c2 = 33;
int a3 = 13;
int b3 = 12591;
int c3 = 313;

int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2),
    Max(a3, b3, c3));
*/
// трансформируем его в решение через массив
 //              0    1   2   3   4   5   6   7   8
int[] array = { 10, 12, 21, 548, 15, 65, 17, 318, 90 };
// int в начале значит что это массив целых чисел
int result = Max(
    Max(array[0], array[1], array[2]),  // вместо переменной передаем элемент массива
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine($"max = {result}");