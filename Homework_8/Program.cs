//Напишите программу, которая принимает
//на вход пятизначное число и проверяет, является ли
//оно палиндромом.

int num = new Random().Next(10000,100000);

Console.WriteLine(num);

int firstNum = num / 10000;
int secondNum = (num / 1000) % 10;
int fourthNum = (num / 10) % 10;
int fifthNum = num % 10;

if(firstNum == fifthNum && secondNum == fourthNum){
    Console.WriteLine("yes");
}
else{Console.WriteLine("no");}
