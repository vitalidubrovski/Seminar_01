Console.WriteLine("Введите 5-и значное число");
string numbers = Convert.ToString(Console.ReadLine());
if((numbers[0] == numbers[4]) & (numbers[1] == numbers[3]))
{
    Console.WriteLine(numbers + " ==> " + " Да ");
}
else
{
    Console.WriteLine(numbers + " ==> " + " Нет");
}