/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот 
день выходным. */

Console.WriteLine("Введите день недели");
int a = int.Parse(Console.ReadLine());

if(a < 6 && a > 0){
    Console.WriteLine("Это не выходной");
}
else if(a > 5 && a < 8){
    Console.WriteLine("Это выходной");
}
else {
    Console.WriteLine("Это вообще не день недели");
}



