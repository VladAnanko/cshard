// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
int a = 0;
Console.Write("Введите трёхзначное число: ");
a = Convert.ToInt32(Console.ReadLine());
do 
    {
        Console.Write("введите ТРЁХЗНАЧНОЕ число!");
        a = Convert.ToInt32(Console.ReadLine());
    }
while (a < 100 && a > 999);    
Console.WriteLine( "Вторая цифра числа: " + a / 10 % 10);

    