// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int n = 2;

// Console.Write("Введите первое число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// int a = b;
// if (a == 0)
// {
//     Console.WriteLine("Третья цифра отсутствует");
// }
// else if (a < 0) 
//         {
//             a = a*-1;
//         }
// else
// int count = 0;
// while (a > 0)
// {
//     a = a / 10 ;
//     count++;
// }
// for (count < n; Console.WriteLine("Третья цифра отсутствует");   )
// {
//     Console.WriteLine("Третья цифра отсутствует");
// }
// int index = count - 1;
// int [] array = new int [index];
// while (count > -1)
// {
//     array [index] = b % 10;
//     b = b / 10;
//     count--;
//     Console.WriteLine("Третяя цифра = " + array[n]);
// }
int count = 0;
int c = 0;
Console.Write("Введите число: ");
int v = Convert.ToInt32(Console.ReadLine());
int a = v;
int d = v;
while (a > 0)
{
    a = a / 10;
    count++;   
}
if (count < 3)
{
    Console.WriteLine("Третьей цифры не существует");
}
else
{
    while (c < count -3)
    {
        d = d/10;
        c++;
    }
Console.WriteLine("Третьей цифрой в числе " + v + " является " + d % 10);
}
