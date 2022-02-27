Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int i = -Math.Abs(N);
for(i = 1; i<=N; i++)
    if((i % 2)  <=0)
{
    Console.Write(""+i+"");
    i++;
}