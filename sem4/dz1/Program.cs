// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
int c = 1;
int i = 0;
Console.Write ("Введите число, которое будем возводить в степень: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите степень: ");
int b = Convert.ToInt32(Console.ReadLine());
while (i < b)
{
    c = c*a;
    i++;
}
Console.WriteLine(c);

