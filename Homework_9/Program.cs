//Напишите программу, которая принимает
//на вход координаты двух точек и находит 
//расстояние между ними в 3D пространстве.

Console.WriteLine("Введите x1:");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите y1:");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите z1:");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x2:");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x1:");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x1:");
int z2 = int.Parse(Console.ReadLine());

double lx = x2 - x1;
double ly = y2 - y1;
double lz = z2 - z1;

double x = Math.Pow(lx,2);
double y = Math.Pow(ly,2);
double z = Math.Pow(lz,2);

double sum = x + y + z;
double d = Math.Sqrt(sum);
Console.WriteLine(d);