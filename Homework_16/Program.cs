//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

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
Console.WriteLine();
int[,] array = GenRanArrx2(a,b);
PrintArr(array);
Console.WriteLine();

int SearchMinString(int[,] arr){
    int[]sumArray = new int[arr.GetLength(0)];
    int sum = 0;
    int coun = 0;
    int minCount = 0;
    
    for(int y = 0; y < arr.GetLength(0);y++){
        for(int x = 0; x < arr.GetLength(1);x++){
            sum = sum + arr[y,x];
        }
        sumArray[coun] = sum;
        sum = 0;
        coun++;
    }
    for(int i =0;i < sumArray.Length;i++){
        Console.Write(sumArray[i] + "\t");
    }
    Console.WriteLine();
    int min = sumArray[0];
    for(int i =0;i < sumArray.Length;i++){
        if(sumArray[i] < min){
            min = sumArray[i];
            minCount = i;
        }
    }
    return minCount;
}
Console.WriteLine("Минимальная строка имеет индекс " + SearchMinString(array));