// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
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
int count = 0;
int n = cons ("Введите колличество элементов массива: ");
int left = cons ("Введите левый край массива: ");
int right = cons ("Введите правый край массива: ");
int [] array = mass (n, left, right);
Console.WriteLine(string.Join(", ", array));
for (int i = 0; i < array.Length; i++)
    if(array[i] > 9 && array[i] < 100 )
    {
        count += 1;
    }
Console.WriteLine($"{count} чисел в отрезке [10,99]");