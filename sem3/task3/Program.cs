Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int q = 1;
if (n < 0)
{
    n *= -1;
    do
    {
        Console.Write((Math.Pow(q, 2)));
        q++;
        
        
    }
    while (q <= n);
    Console.Write(", ");
}
else
{
    do
    {
        Console.Write((Math.Pow(q, 2)));
        q++;
        
        
    }
    while (q <= n);
    Console.Write(", ");
}
