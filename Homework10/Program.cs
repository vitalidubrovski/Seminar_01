Random r = new Random();
int number = r.Next(100, 1000);
Compare(number);

void Compare(int current_num)
{
    int f_place = current_num / 100;
    int s_place = (current_num / 10) % 10;
    int t_place = current_num % 10;
    Console.WriteLine(current_num + ">>>" +t_place+s_place+f_place);
}
