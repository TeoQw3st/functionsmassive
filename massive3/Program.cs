﻿// Создание рандомного трехмерного массива c неповторяющимися числами

int[,,] CreateRandomArray(int line, int column, int diagonal, int start, int end)
{
    int[,,] RandomArray = new int[line, column, diagonal];
    for (int z = 0; z < RandomArray.GetLength(2); z++)
    {
        for (int i = 0; i < RandomArray.GetLength(0); i++)
        {
            for (int j = 0; j < RandomArray.GetLength(1); j++)
            {
                RandomArray[i, j, z] = new Random().Next(start, end + 1);
                if (RandomArray[i, j, z] == RandomArray[i, j, z])
                {
                    RandomArray[i, j, z] = new Random().Next(start, end + 1);
                }
            }
        }
    }
    return RandomArray;
}

// создание трехмерного массива с запросом данных от пользователя
int[,,] CreateArray()
{
    Console.WriteLine("Введите количество строк");
    int line = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество диагональных значений");
    int diagonal = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[line, column, diagonal];
    for (int z = 0; z < array.GetLength(2); z++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.WriteLine($"Введите для {z + 1} диагонали  {i + 1} строки элемент столбца {j + 1} массива");
                array[i, j, z] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    return array;
}

// функиця показа трехмерного массива массива
void ShowArray(int[,,] array)
{

    for (int z = 0; z < array.GetLength(2); z++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j, z]} ({i},{j},{z}) ");

            }
            Console.WriteLine();
        }



    }
}
