int cons (string messege)
{
    Console.Write(messege);
    return Convert.ToInt32(Console.ReadLine ());
}

int [] mass (int n)
{
    int [] array = new int[n];
    int i = 0;
    for (i = 0; i < array.Length; i++)
        array [i] = Random.Shared.Next(0,2);
    return array;
}
int a = cons ("введите колличество элементов массива");
int [] arr = mass(a);
int index = 0;
for (index = 0; index < arr.Length; index++)
    Console.WriteLine( arr[index]);
    
