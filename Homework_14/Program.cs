//Напишите программу, которая на вход принимает позиции элемента 
//в двумерном массиве, и возвращает значение этого элемента или же 
//указание, что такого элемента нет.
int a = 0;
int b = 0;
int[,] GenRanArrx2(int I, int J){
    int[,] arr = new int[I,J];
    for(int i = 0;i < arr.GetLength(0);i++){
        for(int j = 0; j < arr.GetLength(1);j++){
            arr[i,j] = new Random().Next(0,21);
        }
    }
    return arr;
}

void FindNum(int[,] arr,int i, int j){
    Console.WriteLine(arr[i,j]);
}

void PrintArr(int[,] arr){
    for( int i = 0;i < arr.GetLength(0);i++){
        for(int j = 0; j < arr.GetLength(1);j++){
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] array = GenRanArrx2(3,4);
Console.WriteLine("Введите номер строки: ");
while(true){
a = int.Parse(Console.ReadLine());
if(a > array.GetLength(0)){
    Console.WriteLine("Вы ввели неверное число.Попробуйте снова:");
}
else{
    break;
}
}
Console.WriteLine("Введите номер столбца: ");
while(true){
b = int.Parse(Console.ReadLine());
if(b > array.GetLength(1)){
    Console.WriteLine("Вы ввели неверное число.Попробуйте снова:");
}
else{
    break;
}
}
Console.WriteLine();

PrintArr(array);
Console.WriteLine();
FindNum(array,a - 1,b - 1);



