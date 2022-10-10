// Напишите программу, которая принимает вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void TwoNum()
{
Console.WriteLine("Введите трехзначное число");
int a = Convert.ToInt32(Console.ReadLine());

    if (a > 99 && a < 1000)
    {
        Console.WriteLine("Вторая цифра числа" + (a/10%10));
    }
    else
    {
        Console.WriteLine("Введено не трехзначное число");
    }
}

TwoNum ();

