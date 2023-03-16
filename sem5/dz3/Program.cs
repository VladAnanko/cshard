// Задайте массив натуральных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
int [] mass (int n, int left, int right)
{
    int [] array = new int[n];
    int i = 0;
    for (i = 0; i < array.Length; i++)
        array [i] = Random.Shared.Next(left,right +1);
    return array;
}
int cons (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}

// 
// 
int min = 0;
int max = 0;
int n = cons ("Введите колличество элементов массива: ");
int left = cons ("Введите левый край массива: ");
int right = cons ("Введите правый край массива: ");
int [] array = mass (n, left, right);
Console.WriteLine(string.Join(", ", array));
for (int i = 0; i < array.Length; i++)
    if (array[i] > max)
    {
        max = array[i];
    }
for (int i = 0; i < array.Length; i++)    
    if (array[i] < min)
    {
        min = array[i];
    }
Console.WriteLine($"наибольший элемент массива: {max}");
Console.WriteLine($"наименьший элемент массива: {min}");
Console.WriteLine($"разница наибольшего и наименьшего эллементов массива: {max - min}");