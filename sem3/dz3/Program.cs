// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
void coub (int a) //разобрался и сам написал, честно!
{
int q = 1;
    do
    {
        Console.Write((Math.Pow(q, 3)));
        q++;
        if (q <= a)
        {
            Console.Write(", ");
            
        }
    }
    while (q <= a); 
}
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 0)
{
    a *= -1;
    coub (a);
}
else
{
    coub (a);
}