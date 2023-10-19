// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

Console.WriteLine("Введите трёхзначное число:");
int a = int.Parse(Console.ReadLine());
int count = 0;/* в данном случае счётчик будет идти до тех пор,
 пока не закончатся цифры */
 int secondA = a;

if(a < 100 && a > 0 || a < 0 && a > -100){
    Console.WriteLine("третьей цифры нет");
}
else{
    while(secondA != 0){
        secondA = secondA / 10;
        count = count + 1;
    }
    int otherCount = count - 3;
    if(a < 0){a = a - 2 * a;}
    while(otherCount != 0){
        a = a /10;
        otherCount = otherCount - 1;
    }
    int finalNum = a % 10;
    Console.WriteLine(finalNum);
    }


