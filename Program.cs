/* З №2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7*/
Console.WriteLine("Введите первое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number<number1)
{
    Console.WriteLine("max= number1");
}
else
{
    Console.WriteLine("max=number");
}

