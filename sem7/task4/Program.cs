// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.
// ​
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// ​
// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
void main()
{
int rows = cons ("введите число строк: ");
int colomns = cons ("введите число столбцов: ");
int LeftBorder =cons ("введите левую границу: ");
int RightBordr =cons ("введите правую границу: ");

int [,] matrix = randomMatrix (rows, colomns, LeftBorder, RightBordr);
PrintMatrix(matrix);

int [,] newMatrix = col(matrix);

PrintMatrix(newMatrix);

}

int [,] col (int [,] matrix)
{
int sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if ( i % 2 == 1)
    {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j % 2 == 1)
        {
            matrix[i,j] *= matrix [i,j];
        }
    }
    }
}
return matrix;
}

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

int cons (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}

main();