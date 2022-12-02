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

int[] ArrayMultiplication(int[] array);
{
        int size = arr.Length;
        if (array.Length % 2 == 1) size += 1;
        int [] arrMult = new int [size];
        for (int i = 0; i < arrMult.Length; i++)
        {
            arrMult[i] = array[i] * array[arrMult.Length - 1 - i];   
        }
    return arrayMult;
}