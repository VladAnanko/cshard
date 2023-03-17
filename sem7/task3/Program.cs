// Задача 51: Задайте двумерный массив.
// Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12
void main()
{
int rows = cons ("введите число строк: ");
int colomns = cons ("введите число столбцов: ");
int LeftBorder =cons ("введите левую границу: ");
int RightBordr =cons ("введите правую границу: ");

int [,] matrix = randomMatrix (rows, colomns, LeftBorder, RightBordr);
PrintMatrix(matrix);
int result = sum(matrix);
Console.WriteLine ($"Сумма элементов главной диагонали равна {result}");

}

int sum (int [,] matrix)
{
int sum = 0;
int i = 0;
int j = 0;
while (i < matrix.GetLength(0) && j < matrix.GetLength(1))
{
    sum += matrix[i,j];
    i++;
    j++;
}
return sum;
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