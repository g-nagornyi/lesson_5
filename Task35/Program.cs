int [] CreateArrayRndInt (int size, int min, int max)
{
    int [] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}   
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int QuantityNum(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100) sum ++;
    }
    return sum;
}


int[] arr = CreateArrayRndInt(5, 1, 200);
PrintArray (arr);
int result = QuantityNum(arr);
Console.WriteLine($"Количество элементов от 10 до 99 --> {result}");