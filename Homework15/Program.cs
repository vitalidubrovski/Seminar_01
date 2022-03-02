Console.WriteLine("День недели");
int x = Convert.ToInt32(Console.ReadLine());
WeekEnds(x);

void WeekEnds(int daynumber)
{
    if(daynumber == 1)
    {
        Console.WriteLine(daynumber + " -> " +  "Нет"  +  " Понедельник ");
    }
    if(daynumber == 2)
    {
        Console.WriteLine(daynumber + " -> " +  "Нет"  +  " Вторник");
    }
    if(daynumber == 3)
    {
        Console.WriteLine(daynumber + " -> " +  "Нет"  +  " Среда");
    }
    if(daynumber == 4)
    {
        Console.WriteLine(daynumber + " -> " +  "Нет"  +  " Четверг");
    }
    if(daynumber == 5)
    {
        Console.WriteLine(daynumber + " -> " +  "Нет"  +  " Пятница");
    }
    if(daynumber == 6)
    {
        Console.WriteLine(daynumber + " -> " +  "Да"  +  " Суббота.Выходной");
    }
    if(daynumber == 7)
    {
        Console.WriteLine(daynumber + " -> " +  "Да"  +  " Воскресенье.Выходной");
    }
}