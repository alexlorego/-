// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0} ", matrix[i, j]);
        }
        Console.WriteLine();
    }
}

bool CanMatrixMultipli(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0)) return false;
    else return true;
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                result[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return result;
}

Console.Clear();
Console.WriteLine("Введите размерность первой матрицы: "); // задаем первую матрицу
int[,] matrixA = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < matrixA.GetLength(0); i++)
{
    for (int j = 0; j < matrixA.GetLength(1); j++)
    {
        Console.Write("MatrixA[{0},{1}] = ", i, j);
        matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("Введите размерность второй матрицы: "); // задаем вторую матрицу
int[,] matrixB = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < matrixB.GetLength(0); i++)
{
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        Console.Write("MatrixB[{0},{1}] = ", i, j);
        matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("\nMatrixA:");
Print(matrixA);
Console.WriteLine("\nMatrixB:");
Print(matrixB);
if (CanMatrixMultipli(matrixA, matrixB))
{
    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    result = MatrixMultiplication(matrixA, matrixB);
    Console.WriteLine("\nРезультирующая матрица MatrixA * MatrixB:");
    Print(result);
}
else Console.WriteLine("\nОшибка! Матрицы нельзя перемножить");
Console.WriteLine();
