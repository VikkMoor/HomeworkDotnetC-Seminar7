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
Console.Write("Enter coordinates of matrix element (x, y) separated by spaces or commas or both: ");
string text = Console.ReadLine();
string[] nums = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
int[] coord = nums.Select(Int32.Parse).ToArray();
int[,] matrix = new int[4, 6];
FillArray(matrix);
PrintArray(matrix);

bool check = true;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (i == coord[0] && j == coord[1])
        {
            Console.Write(matrix[i, j]);
            check = false;
            break;
        }
    }

}
if (check) Console.Write("No elements with such coordinates");
