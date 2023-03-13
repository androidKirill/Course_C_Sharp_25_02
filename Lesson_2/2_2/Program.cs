// int MaxNumber(int a)
// {
//     Console.WriteLine(a);

//     if (a % 10 > a / 10)
//         return a % 10;
//     return a / 10;

// }


// Console.WriteLine(MaxNumber(new Random().Next(10, 100)));

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int indexOf(int[] collection, int find)
{
    int index = 0;
    int count = collection.Length;
    int position = -1;
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
int[] array = new int[10];

FillArray(array);
PrintArray(array);
array[4] = 4;
array[6] = 4;
int pos = indexOf(array, 1);
Console.WriteLine();
Console.WriteLine(pos);
