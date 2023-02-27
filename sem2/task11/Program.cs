// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98
int arg = Random.Shared.Next(100, 1000);
int arg1 = arg / 100;
int arg2 = arg % 10;
int argnew = arg1 * 10 + arg2;
Console.WriteLine(arg);
Console.WriteLine(argnew);