// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
void main()
{
int rows = cons ("введите число строк: ");
int colomns = cons ("введите число столбцов: ");
int LeftBorder =cons ("введите левую границу: ");
int RightBordr =cons ("введите правую границу: ");

int [,] matrix = randomMatrix (rows, colomns, LeftBorder, RightBordr);
PrintMatrix(matrix);
Console.WriteLine($"{element (matrix)} искомый элемент массива");

}

bool IsOk (int [,] matrix, int row, int colomn)
{
    if (row < matrix.GetLength(0) && colomn < matrix.GetLength(1))
        return true;
    else
        return false;
}

int element (int [,] matrix)

{
    int row = cons ("Введите искомую строку: ");
    int colomn = cons ("Введите искомый столбец: ");
    if (IsOk(matrix, row, colomn) == true)
    {
        return matrix[row,colomn];
    }
    else 
    {
        Console.WriteLine("Такого элемента не существует, попробуйте еще раз");
        return element(matrix);
    }

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