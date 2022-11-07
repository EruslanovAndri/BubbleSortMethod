// Данны (BubbleSort) метод может сортировать массив от меньшего к большему и 
// наоборот,для изменения результата
// необходимо просто поменять знак (<) на (>) внутри метода BubbleSort!

Console.Clear();
int size = 25;
int[] array = new int[size];

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < arr.Length - 1) Console.Write(arr[i] + ",");
        else Console.Write("]");
    }
}

void BubbleSort(int[] arr)
{
    var n = array.Length;

    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                var temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }

        }
    }
}

FillArray(array);
PrintArray(array);
BubbleSort(array);
Console.WriteLine();
PrintArray(array);