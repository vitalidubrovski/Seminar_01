Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("a = " + a + " b = " +b);
if(a>b)
{
    Console.WriteLine("MAX = " +a + " MIN = " +b);
}
else
{
    Console.WriteLine("MAX = " +b + " MIN = " +a);
}