// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
while (a == 0) 
    {
    Console.Write("Введите другое число: ");
    a = Convert.ToInt32(Console.ReadLine());
    }
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int numb = b % a;
if (numb == 0) 
{
    Console.WriteLine("второе число кратно первому");
}
else 
{
    Console.WriteLine("Остаток от деления равен :" + numb);
}
