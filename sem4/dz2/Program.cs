// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12
int sum = 0;
int i = 1;
Console.Write ("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (i > 0)
{
    i = a / 10;
    sum += a % 10;
    a =i;
}
// while (i < a)
// {
//     sum += a[i];
//     i++;
// }
//  почему не сработал алгоритм
Console.WriteLine(sum);

