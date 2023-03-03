//Написать метод для разворота массива, не используя память под дополнительный массив
Console.Write($"Введите колличество элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] mas = new int [n];
int i = 0;
int a = 0;
Console.WriteLine($"Введите {n} элементов массива: ");
while (i < n)
{   
    mas[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
i = 0;
Console.Write("Ваш введенный массив: ");
while (i < n)
{
    Console.Write(mas[i]);
    
    i++;
    if (i < n)
    {
        Console.Write(", ");    
    }
}
i = 0;
while (i < n/2)
{
    a = mas [i];
    mas[i] = mas [n-1-i];
    mas [n-1-i] = a;
    i++;
}
i = 0;
Console.WriteLine();
Console.Write("Ваш перевернутый массив: ");
while (i < n)
{
    Console.Write(mas[i]);
    
    i++;
    if (i < n)
    {
        Console.Write(", ");    
    }
}
    