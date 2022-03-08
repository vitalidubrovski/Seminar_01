Random rand = new Random();

int a_x = rand.Next(1, 10);
int a_y = rand.Next(1, 10);
int a_z = rand.Next(1, 10);
int b_x = rand.Next(1, 10);
int b_y = rand.Next(1, 10);
int b_z = rand.Next(1, 10);

Console.WriteLine("Точка А - " + a_x + ":" + a_y + ":" + a_z);
Console.WriteLine("Точка В - " + b_x + ":" + b_y + ":" + b_z);

double distance = Math.Sqrt( 
    (a_x - b_x)*(a_x - b_x) + (a_y - b_y)*(a_y - b_y) +(a_z - b_z)*(a_z - b_z));
Console.WriteLine("Длина отрезка: " +distance);

//Math.Pow не получилось решить, всегда пишет ошибу связанную с типом данных double(можете разобрать эту задачу на семинаре, с решением через Pow?)