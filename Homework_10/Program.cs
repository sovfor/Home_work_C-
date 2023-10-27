//Напишите программу, которая принимает на вход число 
//(N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите n:");
int n = int.Parse(Console.ReadLine());

double[] arr = new double[n];

for(int i  = 0;i < arr.Length;i++)
{
    arr[i] = Math.Pow(i+1,3);
    Console.Write(arr[i] +" ");
}
