
int [,] randomMatrix (int row, int colomns, int LeftBorder, int RightBordr)
{
int [,] matrix = new int [row,colomns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = Random.Shared.Next(LeftBorder,RightBordr +1);
    }
}
return matrix;
}
void PrintMatrix (int [,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
}
int [,] matrix = randomMatrix (3, 4, 0, 10);
PrintMatrix(matrix);