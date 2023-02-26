// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int arg = 2;
if (arg <= a)
    while (a >= arg){
        Console.Write(arg);
        arg += 2;
        if (arg <= a) Console.Write(", ");
    }
else Console.Write("Четных чисел в заданном диапазоне не существует!");
