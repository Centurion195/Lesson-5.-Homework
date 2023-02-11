// Написать программу копирования массива

int[] CreateArray(int length, int lowest, int higtest){
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(lowest, higtest);
    }
    return array;
}

void PrintArray(int[] array){
    for (int i = 0; i < array.Length; i++)
        Console.Write($"| {array[i]} ");
}

int[] CopyArray(int[] array){
    int[] array2 = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        array2[i] = array[i];
    return array2;
}

int length = 10;
int lowest = 0;
int highest = 20;

int[] array = CreateArray(length, lowest, highest);
PrintArray(array);
Console.WriteLine();
PrintArray(CopyArray(array));