//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] randomMatrix (int row, int colomns)
{
double [,] matrix = new double [row,colomns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = Math.Round((Random.Shared.NextDouble()-0.5) * 10, 1);
    }
}
return matrix;
}

int cons (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}

void PrintMatrix (double [,] matrix)
{
Console.WriteLine("полученый массив:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j]+" ");
    }
    Console.WriteLine();
}
}

void main()
{
int rows = cons ("введите число строк: ");
int colomns = cons ("введите число столбцов: ");
double [,] matrix = randomMatrix (rows, colomns);
PrintMatrix(matrix);
}
main();