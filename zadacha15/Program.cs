// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

 Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int GetMetod2(int a)
{    
    if (a <= 5 && a > 0)
    {
        Console.WriteLine("Нет");    
        return -1; 
    }    
    if (a == 0)    
    {
       Console.WriteLine("Ошибочно введено число"); 
       return -1; 
    }    
    if(a >= 8)
    {
        Console.WriteLine("Число введено  неверно"); 
    }
    else
    {    
        Console.WriteLine("Да");
    }    
    return -1;       
}
int result = GetMetod2(a);
