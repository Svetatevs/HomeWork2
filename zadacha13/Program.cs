// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());
int GetMetod(int x)
{
    if (x < 99)
    {
        Console.WriteLine("третьей цифры нет");
    }
    if (x > 99 && x < 1000)
    {
        int z = x % 10;
        return (z);
    }
    if (x >= 1000 && x < 10000)
    {
        int y = x / 10;
        int z = y % 10;
        return (z);
    }
    if (x >= 10000 && x < 100000)
    {
        int y = x / 100;
        int z = y % 10;
        return (z);
    }
    Console.WriteLine("Введите число не более 99999");
    return -1;
}
int result = GetMetod(x);

Console.WriteLine(result);
