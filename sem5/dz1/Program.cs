//  Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
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
int [] array = mass (n, 100, 999);
Console.WriteLine(string.Join(", ", array));
for (int i = 0; i < array.Length; i++)
    if(array[i] % 2 == 0)
    {
        count += 1;
    }
Console.WriteLine($"{count} четный чисел в массиве");