// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
int conssole (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}
int count (int number)
{
int i = 0;
while (number > 0)
{
    number = number / 10;
    i++;
}
return i;
}

int numb = conssole ("введите число: ");   
int cont = count (numb);
Console.WriteLine (cont);
  