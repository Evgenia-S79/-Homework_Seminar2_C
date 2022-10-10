// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число от 1 до 7: ");
int day = Convert.ToInt32(Console.ReadLine());

string WorkHoliday(int day)
{
    if (day > 0 && day < 8)
    {
        if (day == 6 || day == 7)
        {
            return ("Выходной день");
        }
        else
        {
            return ("Рабочий день");
        }
    }
    else
    {
        return ("Ошибка. Не верное число!");
    }
}
Console.WriteLine(WorkHoliday(day));