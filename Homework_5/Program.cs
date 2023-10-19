//Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую цифру этого числа.
bool threeNum = false;
int a = 0;
while(threeNum == false){
Console.WriteLine("Введите трёхзначное число:");
a = int.Parse(Console.ReadLine());

if(a > 99 && a < 1000){
    threeNum = true;
}
}
int num = a % 100;
num = num /10;

Console.WriteLine(num);