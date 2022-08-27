/* 
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите число: ");

int Number = Convert.ToInt32(Console.ReadLine());
int Metod(int Number)
{
int first = Number / 10;
int second = first % 10;
return second;
}

int result = Metod(Number);

Console.Write(result);
