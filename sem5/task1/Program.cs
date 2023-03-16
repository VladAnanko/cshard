// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
int [] mass (int n, int left, int right)
{
    int [] array = new int[n];
    int i = 0;
    for (i = 0; i < array.Length; i++)
        array [i] = Random.Shared.Next(left,right +1);
    return array;
}
int [] array = mass (8, -10, 10);
Console.WriteLine(string.Join(", ", array));
for(int i = 0; i < array.Length; i++)
    array[i] = array [i]* -1;
Console.WriteLine(string.Join(", ", array));