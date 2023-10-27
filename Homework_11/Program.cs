/* Напишите цикл, который принимает на вход два 
числа (A и B) и возводит число A в натуральную степень B.*/
 Console.WriteLine("Введите число a:");
 int a = int.Parse(Console.ReadLine());

 Console.WriteLine("Введите степень числа a:");
 int b = int.Parse(Console.ReadLine());
 
double Pow(double num, double degree){
    double c = num;
for(int i = 1;i < degree;i++){
    
    num = num * c;
}
return num;
}

double x = Pow(a,b);
Console.WriteLine(x);