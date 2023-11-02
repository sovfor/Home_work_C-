//  Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Введите числа через запятую");
string nums = Console.ReadLine();
string[] arr = nums.Split(",");
int[] array = new int[arr.Length];
for(int i = 0; i < arr.Length; i++){
    array[i] = int.Parse(arr[i]);
}

int count = 0;
for(int i = 0; i < arr.Length; i++){
    if(array[i] > 0){
        count++;
    }
}

Console.WriteLine("количество положительных чисел равно " + count);
