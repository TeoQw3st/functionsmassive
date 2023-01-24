// Создание рандомного массива

int[,] CreateRandomArray(int line, int column, int start, int end)
{
    int[,] RandomArray = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            RandomArray[i, j] = new Random().Next(start, end + 1);
        }
    }
    return RandomArray;
}

// создание массива с запросом данных от пользователя
int[,] CreateArray()
{
    Console.WriteLine("Введите количество строк");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[line, column];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < column; j++)
        {
            Console.WriteLine($"Введите для {i + 1} строки элемент столбца {j + 1} массива");
            array[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}

// функиця показа массива
void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] matr = CreateRandomArray(3, 4, -10, 10);
ShowArray(matr);
Console.WriteLine();
int[,] matr2 = CreateArray();
Console.WriteLine();
ShowArray(matr2);
