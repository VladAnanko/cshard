// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем
int [] b = new int [8];
int i = 0;
while (i < 8)
{
    Console.Write ("Введите элемент массива через Enter: ");
    b[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
int index = 0;
for (index = 0; index < b.Length; index++)
    Console.Write( $"{b[index]} ");
    