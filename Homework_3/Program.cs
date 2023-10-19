//Напишите программу, которая на вход принимает число и выдает, 
//является ли число четным (делится ли оно на два без остатка). 

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());

if(a % 2 == 0){
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}