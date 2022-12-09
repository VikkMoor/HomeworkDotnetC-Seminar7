void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0, 10);
        }
    }
}
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void ColumnAverage(int[,] matr)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        double result = 0, averageSum = 0;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            result += matr[i, j];
        }
        averageSum = Math.Round(result / matr.GetLength(0), 1);
        Console.Write($"{averageSum}  ");
    }
}

int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
ColumnAverage(matrix);