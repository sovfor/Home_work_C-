﻿//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите конечное число N");
int N = int.Parse(Console.ReadLine());
int count = 1;
while(count != N + 1){
    if(count % 2 == 0){
        Console.WriteLine(count);
    }
    count++;
}
