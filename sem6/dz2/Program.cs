// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int cons (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}
double k1 = cons ("Введите к1: ");
double b1 = cons ("Введите b1: ");
double k2 = cons ("Введите к2: ");
double b2 = cons ("Введите b2: ");
Console.WriteLine($"точка пересечения : y = {k2 * (b2 - b1) / (k1 - k2) + b2} x = {(b2 - b1) / (k1 - k2)}");