/* З №2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1<num2)
{
    int max = num2;
    Console.Write("max = ");
    Console.Write(max);
   }
else
{
    int max = num1;
    Console.WriteLine("max = ");
    Console.Write(max);
}
З №4
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());
int a;
if (num1>num2) 
{
    a = num1;
    }
    else 
    {
        a=num2;
    }
    if (a>num3)
    {
       Console.Write(a); 
    }
    else 
    {
        Console.Write(num3);
    }

  З №6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
*/
Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2==0)
{
   Console.WriteLine("Это четное число"); 
}
else 
{
   Console.WriteLine("Это нечетное число"); 
}


