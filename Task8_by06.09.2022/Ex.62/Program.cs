// Напишите программу, которая заполнит спирально массив 

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]< 10) Console.Write($"0{array[i, j]} ");
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void FillArraySpiral2D(int[,] result)
{
    int ROWS = result.GetLength(0);
    int COLS = result.GetLength(1);

    int startRow = 0, lastRow = 0, startCol = 0, lastCol = 0;

    int count = 1;
    int row = 0;
    int col = 0;

    while (count <= ROWS * COLS)
    {
        result[row, col] = count;
        if (row == startRow && col < COLS - lastCol - 1) col++;
        else if (col == COLS - lastCol - 1 && row < ROWS - lastRow - 1) row++;
        else if (row == ROWS - lastRow - 1 && col > startCol) col--;
        else row--;

        if ((row == startRow + 1) && (col == startCol) && (startCol != COLS - lastCol - 1))
        {
            startRow++;
            lastRow++;
            startCol++;
            lastCol++;
        }
        count++;
    }
}

Console.Clear();
Console.WriteLine("Введите размерность массива: ");
int[,] array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
Console.WriteLine();
FillArraySpiral2D(array);
PrintArray(array);
Console.WriteLine();






