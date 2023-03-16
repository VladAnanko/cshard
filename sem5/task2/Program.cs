// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int [] mass (int n, int left, int right)
{
    int [] array = new int[n];
    int i = 0;
    for (i = 0; i < array.Length; i++)
        array [i] = Random.Shared.Next(left,right +1);
    return array;
}

int cons (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}

bool IsMassElement (int[] array, int elem)
{
    for(int i = 0; i < array.Length; i++)
        if (array[i] == elem) return true;
    return false;
}
// 
// 
int n = cons ("Введите эллемент массива для проверки: ");
int [] array = mass (8, -10, 10);
Console.WriteLine(string.Join(", ", array));

if (IsMassElement(array, n) == true)
{
    Console.WriteLine($"Эллемент {n} присутствует в массиве");
}
else
    Console.WriteLine($"Эллемент {n} отсутствует в массиве");
 
