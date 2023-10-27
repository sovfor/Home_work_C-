//Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
int a = new Random().Next(100,1000);
int num1 = a / 100;
int num2 = (a/ 10) % 10;
int num3 = a % 10;

Console.WriteLine(a);

Console.WriteLine(num1 + num2 + num3);