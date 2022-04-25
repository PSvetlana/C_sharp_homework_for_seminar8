/*
Задача 54: Задайте двумерный массив. Напишите программу,
которая упорядочит по убыванию элементы каждой строки двумерного массива.
*/

//создает массив из случайных целых чисел в диапазоне от [0; limit)
int[,] GenerateMatrix(int hight, int weight, int limit)
{
    int[,] generatedArray = new int[hight, weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = new Random().Next(limit);
        }
    }
    return generatedArray;
}

//выводит массив в определенном формате
void PrintMatrix(int[,] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write($"{arrayToPrint[i, j]}\t");
        }
        Console.WriteLine();
    }
}

//сортирует массив по убыванию элементов каждой строки
int[,] SortMatrix(int[,] arrayToSort)
{
    for (int i = 0; i < arrayToSort.GetLength(0); i++)
    {
        for (int k = arrayToSort.GetLength(1) - 1; k > 0; k--)
        {
            for (int j = 0; j < k; j++)
            {
                if (arrayToSort[i, j] < arrayToSort[i, j + 1])
                {
                    int temp = arrayToSort[i, j];
                    arrayToSort[i, j] = arrayToSort[i, j + 1];
                    arrayToSort[i, j + 1] = temp;

                }

            }
        }
    }
    return arrayToSort;
}

int hight = new Random().Next(2, 5),
    weight = new Random().Next(2, 5);
int[,] generatedArray = GenerateMatrix(hight, weight, 100);

Console.WriteLine("\nПервоначальный массив:");
PrintMatrix(generatedArray);
Console.WriteLine("\nОтсортированный массив по убыванию элементов каждой строки:");
PrintMatrix(SortMatrix(generatedArray));