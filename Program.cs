Console.Clear();
Console.WriteLine("Введите длину массива");
int size = int.Parse(Console.ReadLine());
int[] Array(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 999);
    }
    return result;
}
int FindElements(int[] mass)
{
    int a = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] % 2 == 0 ) a++;
    }
    return a;
}
int[] mass = Array(size);
Console.WriteLine($"В данном массиве {FindElements(mass)} четных элементов");