Console.WriteLine("введите 1 число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число 2");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввели число A " + number1 + " Ввели число B " + number2);
if(number1*number1 == number2)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}