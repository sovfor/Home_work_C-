## Комманды Консоли:
__*dotnet new console*__ – создать новый проект

__*dotnet run*__ – запустить проект

## Комманды C#:
__*Write();*__ - Вывод в одну строку

__*WriteLine();*__ - В конце перейти на новую строку

__*ReadLine();*__ - Считать строку из терминала

__*new Random().Next(min, max)*__ -
даст случайное целое число от min до max-1

__*Console.Clear()*__ - чистит терминал

__*Console.SetCursorPosition(a, b)*__ - делает отступ курсора по длинне(a) и высоте(b)

__*(name_of_array).Length*__ - показывает количество чисел в массиве

__*Convert.To(Type)(name)*__ - переводит один тип данных в другой

__*(type).Parse(name)*__ - перевод строки name в другой тип данных

__*(type)[] (array_name) = {x,y...,z}*__ - создание массива  с любым типом данных и некоторыми переменными внутри

__*(type)[] (array_name) = new (type)[n]*__ - создание пустого массива любого типа с определённым количеством места(n - это количество перемменых)

__*break;*__ - команда, что позволяет закончить процесс, не выполяя остальной код

__*(Type).Empty*__ - создаёт пустую переменную

f(x) = x 2 +1
double f(double x)
{
double result = x * x + 1;
return result
} - пример функции
__*"string".Split(" ")*__ - команда, что позволяет разделить элементы строки по какому то символу для записи в массив.
__*string.Join(" ",array)*__ - позволяет собрать из массива одну строку
__*foreach("type" "name" in "array"){}*__ - цикл, перебериающий каждую ячейку массива и выполняющий с ним действия