//Напишите программу, которая на вход принимает
//два числа и выдает, какое число большее, а какое меньшее.

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

if(a > b){
   Console.WriteLine("Число a больше числа b и равно " + a);
}
else if(a < b){
    Console.WriteLine("Число b больше числа a и равно " + b);
}
else{
    Console.WriteLine("Числа равны");
}