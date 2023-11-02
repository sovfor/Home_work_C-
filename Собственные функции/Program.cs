int[,] GenIntRanArrx2(int I, int J, int min, int max){
    int[,] arr = new int[I,J];
    for(int i = 0;i < arr.GetLength(0);i++){
        for(int j = 0; j < arr.GetLength(1);j++){
            arr[i,j] = new Random().Next(min,max);
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

int[] CopyIntArrString(int[,] arr){
    int[] array = new int[arr.GetLength(1)];
    for(int x = 0; x < arr.GetLength(1); x++){
        array[x] = arr[0,x];
    }
    return array;
}

char[] CopyCharArrString(char[,] arr){
    char[] array = new char[arr.GetLength(1)];
    for(int x = 0; x < arr.GetLength(1); x++){
        array[x] = arr[0,x];
    }
    return array;
}

char[,] GenCharRanArrx2(int I, int J){
    char[,] arr = new int[I,J];
    for(int i = 0;i < arr.GetLength(0);i++){
        for(int j = 0; j < arr.GetLength(1);j++){
            Condole.WriteLine("Введите символ для" + i + "строки и " + j + "столбца");
            
            try{
                arr[i,j] = Console.ReadLine();
                break;
            }
            catch{
                Console.WriteLine("Вы ввели неправильный символ. Попробуйте снова:");
            }
            Console.Clear();
        }
    }
    return arr;
}

