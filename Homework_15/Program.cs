//Задайте двумерный массив. Напишите программу,
//которая поменяет местами первую и последнюю строку массива.

int[,] GenRanArrx2(int I, int J){
    int[,] arr = new int[I,J];
    for(int i = 0;i < arr.GetLength(0);i++){
        for(int j = 0; j < arr.GetLength(1);j++){
            arr[i,j] = new Random().Next(0,21);
        }
    }
    return arr;
}
void PrintArr(int[,] arr){
    for( int i = 0;i < arr.GetLength(0);i++){
        for(int j = 0; j < arr.GetLength(1);j++){
            Console.Write(arr[i,j] + "\t");
        }
        Console.WriteLine();
    }
}
int[] CopyArrString(int[,] arr){
    int[] array = new int[arr.GetLength(1)];
    for(int x = 0; x < arr.GetLength(1); x++){
        array[x] = arr[0,x];
    }
    return array;
}

Console.WriteLine("Введите количество строк: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int b = int.Parse(Console.ReadLine());

int[,] array = GenRanArrx2(a,b);
PrintArr(array);
void ReplaceString(int[,] arr){
    int[] array1 = CopyArrString(arr);
    for(int x = 0; x < arr.GetLength(1); x++){
        arr[0,x] = arr[arr.GetLength(0) - 1,x];
    }
    for(int x = 0; x < arr.GetLength(1); x++){
        arr[arr.GetLength(0) - 1,x] = array1[x];
    }
}
Console.WriteLine();
ReplaceString(array);
PrintArr(array);