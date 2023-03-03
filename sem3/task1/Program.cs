

Console.Write("Введите четверть: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a == 1)
{
    Console.Write("Координаты X и Y больше 0");
}
else if (a == 2)
{
    Console.Write("Координата X  меньше 0, координата Y больше 0");
}
else if (a == 3)
{
    Console.Write("Координата X  меньше 0, координата Y меньше 0");
}
else if (a == 4)
{
    Console.Write("Координата X  больше 0, координата Y меньше 0");
}
else
{
    Console.Write("вы не находитесь в координатной четверти");
}