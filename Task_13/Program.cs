// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void TwoNum2()
{
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
num = Math.Abs(num);

    if (num > 99 )
    {
        while (num > 999)
        {
            num/=10;
        }           
        Console.WriteLine("Третья цифра числа " + num%10);
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

TwoNum2 ();
