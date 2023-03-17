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
        matrix[i,j] = 1;
    }
}
return matrix;
}

void PrintMatrix (int [,] matrix)
{
Console.WriteLine("полученый треугольник:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int j = 0;
    while (j < matrix.GetLength(1))
    {
        if (j == matrix.GetLength(0)-1 + i || j == matrix.GetLength(0)-1 - i)
        {
            Console.Write($"{matrix[i,j]} ");
            
            j++;
        }
        else if (j > matrix.GetLength(0)-1 + i || j < matrix.GetLength(0)-1 - i)
        {
            matrix[i,j] = 0;
            j++;
        }
        else
        {
            if (j < matrix.GetLength(0)-1 + i || j > matrix.GetLength(0)-1 - i) // matrix[i-1,j] == 1 || matrix[i,j - 1] == 1 || matrix[i,j + 1] == 1)
            {
                if (matrix[i-1,j] == 1)
                {
                    matrix[i,j] = 0;
                    Console.Write($"  ");
                    j++;
                }
                else if (matrix[i-1,j] != 1)
                {
                    matrix [i,j] = matrix[i-1,j-1] + matrix[i-1,j+1];
                    if (matrix[i,j] != 0)
                    {
                        Console.Write($"{matrix[i,j]} ");
                    }
                    else
                    {
                        Console.Write($"  ");
                    }
                    j++;
                }
            }
           
            
        }
    }

    // строка +1
    // строка +2
    // строка -2. строка. строка +2
    // for (int j = 0; j < matrix.GetLength(1); j++)
    // {
    //     if (j != matrix.GetLength(0)-1)
    //     {
    //         matrix [ i,j] = "+";
    //     }
    //     Console.Write(matrix[i,j]+" ");
    // }
    Console.WriteLine();
}
}

int cons (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}

main();