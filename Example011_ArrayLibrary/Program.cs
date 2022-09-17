void FillArray(int[] collection) //заполнение массива случайными числами
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)  //вывод массива на печать
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write($"{col[position]}, "); //через запятую        
        position++;
    }    
}

int IndexOf(int[] collection, int find)  //поиск индекса заданного элемента
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // -1 для обхода ситуации когда такого элемента нет, а мы видим 0
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // создание массива размером 10

FillArray(array);
//array[6] = 4;
PrintArray(array);

Console.WriteLine(); // первод строки
Console.WriteLine();

int pos = IndexOf(array, 7);
Console.WriteLine(pos);

