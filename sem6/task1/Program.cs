// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
int cons (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}
int number = cons ("Введите число для первода: ");
string result = String.Empty;
for (int i = number; i > 0; i = i / 2)
{
    int BinaryDigit = i % 2;
    result = BinaryDigit + result;
}
Console.WriteLine(result);