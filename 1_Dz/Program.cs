/* Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
Не использовать массив.

M=5 ; 0, 7, 8, -2, -2 -> 2
M=5 ; -1, -7, 567, 89, 223 -> 3
*/

Console.WriteLine("введите М");
int M = Convert.ToInt32(Console.ReadLine());
int sum = 0;
for (int i = 0; M > i; i++)
{
    Console.WriteLine("введите число");
    int X = Convert.ToInt32(Console.ReadLine());
    if(X>0) sum = sum + 1;
}

Console.WriteLine("кол-во чисел больше нуля = " + sum);