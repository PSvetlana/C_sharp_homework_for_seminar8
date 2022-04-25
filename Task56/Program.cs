/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
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

//поиск строки с наименьшей суммой элементов
void SearchingRowWithMinSum(int[,] arrayToSearch)
{
    int minSumRow = int.MaxValue;
    int indexRow = 0;
    for (int i = 0; i < arrayToSearch.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < arrayToSearch.GetLength(1); j++)
        {
            sumRow += arrayToSearch[i, j];
        }
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            indexRow = i;
        }
    }
    Console.WriteLine($"\nСтрока N {indexRow + 1} имеет минимальную сумму элементов (сумма = {minSumRow})");
}

int hight = new Random().Next(2, 5),
    weight = new Random().Next(2, 5);
int[,] generatedArray = GenerateMatrix(hight, weight, 10);

Console.WriteLine("\nИсходный массив:");
PrintMatrix(generatedArray);
SearchingRowWithMinSum(generatedArray);