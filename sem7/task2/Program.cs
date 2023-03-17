// Задача 48: Задайте двумерный массив размера m на n, 
// каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
void main()
{
int rows = cons ("введите число строк: ");
int colomns = cons ("введите число столбцов: ");
int [,] matrix = ColMatrix (rows, colomns);
PrintMatrix(matrix);
}


int [,] ColMatrix (int row, int colomns)
{
int [,] matrix = new int [row,colomns];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i + j;
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