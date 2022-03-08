Random rand = new Random();

int a_x = rand.Next(1, 10);
int a_y = rand.Next(1, 10);
int a_z = rand.Next(1, 10);
int b_x = rand.Next(1, 10);
int b_y = rand.Next(1, 10);
int b_z = rand.Next(1, 10);

Console.WriteLine("Точка А - " + a_x + ":" + a_y + ":" + a_z);
Console.WriteLine("Точка В - " + b_x + ":" + b_y + ":" + b_z);

double distance_x = Math.Pow( (b_x - a_x), 2);
double distance_y = Math.Pow( (b_y - a_y), 2);
double distance_z = Math.Pow( (b_z - a_z), 2);

Console.WriteLine("Длина отрезка: " +Math.Sqrt(distance_x + distance_y + distance_z));
