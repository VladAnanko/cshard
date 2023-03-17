// Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника



void main()
{
int rows = cons ("введите число строк: ");
int [,] matrix = randomMatrix (rows);
PrintMatrix(matrix);
}

int [,] randomMatrix (int rows)
{
int [,] matrix = new int [rows,rows * 2 -1];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j == matrix.GetLength(0)-1 + i || j == matrix.GetLength(0)-1 - i)
        {
            matrix[i,j] = 1;
        }
        else if (j > matrix.GetLength(0)-1 + i || j < matrix.GetLength(0)-1 - i)
        {
            matrix[i,j] = 0;
        }
        else
        {
            if (j < matrix.GetLength(0)-1 + i || j > matrix.GetLength(0)-1 - i)
            {
                if (matrix[i-1,j] == 1)
                {
                    matrix[i,j] = 0;
                }
                else if (matrix[i-1,j] != 1)
                {
                    matrix [i,j] = matrix[i-1,j-1] + matrix[i-1,j+1];
                }
            }
        }
    }
}
return matrix;
}

void PrintMatrix (int [,] matrix)
{

// matrix[matrix.GetLength(0)-1,matrix.GetLength(0)*2-1]
Console.WriteLine("полученый треугольник:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i,j] == 0)
        {
            Console.Write("  ");
        }
        else
        {
            Console.Write($"{matrix[i,j]} ");
        }
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