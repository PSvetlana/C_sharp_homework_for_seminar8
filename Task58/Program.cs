/*
Задача 58: Задайте две матрицы. Напишите программу,
которая будет находить произведение двух матриц.
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

// //произведение двух матриц
void MultiplicationTwoMatrixes(int[,] matrix1, int[,] matrix2)
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0))
    {
        Console.WriteLine("Количество столбцов Матрицы 1 не совпадает с количеством строк Матрицы 2");
        Console.WriteLine("Матрицы нельзя перемножить, перезапустите программу.");
    }
    else
    {
        int[,] newMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                for (int k = 0; k < matrix2.GetLength(0); k++)
                {
                    newMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                }
            }
        }
        Console.WriteLine("\nПроизведение двух матриц:");
        PrintMatrix(newMatrix);
    }
}

int hight = new Random().Next(2, 4),
    weight = new Random().Next(2, 4);
int[,] generatedMatrix1 = GenerateMatrix(hight, weight, 10);
int[,] generatedMatrix2 = GenerateMatrix(hight, weight, 10);

Console.WriteLine("\nМатрица 1:");
PrintMatrix(generatedMatrix1);
Console.WriteLine("\nМатрица 2:");
PrintMatrix(generatedMatrix2);
MultiplicationTwoMatrixes(generatedMatrix1, generatedMatrix2);