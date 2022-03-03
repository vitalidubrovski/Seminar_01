Random r = new Random();
int number = r.Next(10, 200);
Compare(number);



void Compare(int current_num)
{
    int a = 100;
    if(current_num<a)
    {
        Console.WriteLine(current_num + " >>> " + " Нет третьей цифры");
    }
    else
    {
        int t_place = current_num % 10;
        Console.WriteLine(current_num + " >>> " + t_place);
    }
}