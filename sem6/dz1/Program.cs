// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int cons (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}
int [] mass (int n)
{
    int [] array = new int[n];
    for (int i = 0; i < array.Length; i++)
        array [i] = cons ("введите число: ");
    return array;
}
int a = cons ("Сколько чисел вводим: ");
int [] numbers = mass (a);
int count = 0;
for (int i = 0; i < numbers.Length; i++)
    if (numbers[i] >= 0)
    {
        count++;
    }
Console.WriteLine($"{count} положительных чисел введено");