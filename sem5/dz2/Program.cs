// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
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
int sum = 0;
int n = cons ("Введите колличество элементов массива: ");
int left = cons ("Введите левый край массива: ");
int right = cons ("Введите правый край массива: ");
int [] array = mass (n, left, right);
Console.WriteLine(string.Join(", ", array));
for (int i = 1; i < array.Length; i=i+2)
    sum += array[i]; 
Console.WriteLine($"сумма нечетных элементов массива равна: {sum}");