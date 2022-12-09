void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int num1 = new Random().Next(-10, 11);
            int num2 = new Random().Next(-10, 11);
            int num3 = new Random().Next(-10, 11);
            double num = (num1 + num2 + num3) / 3.0;
            matr[i, j] = Math.Round(num, 1);
        }
    }
}
void PrintArray(double[,] matr)
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

double[,] matrix = new double[3, 4];
FillArray(matrix);
PrintArray(matrix);
