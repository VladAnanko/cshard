// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8
int cons (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}
int [] fibonachi (int n)
{
    int [] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < n; i++)
        array[i] = array[i-1] + array [i-2];
    return array;
}
int n = cons ("Введите колличество чисел фибоначи: ");
Console.WriteLine(string.Join(", ", fibonachi(n)));