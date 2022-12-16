/*Задача 3*. Найдите сумму произведений пар чисел в одномерном целочисленном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран.
1, 3, 8, 3, 2 -> 11
8, 3, 4, 2 -> 28
*/


void FillArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        int rnd = new Random().Next(1,100);
        array[i] = rnd;
        Console.WriteLine(array[i]);
    } 
}

Console.WriteLine("введите длину массива");
int Len = Convert.ToInt32(Console.ReadLine());

int [] arr = new int [Len];
FillArray(arr);

int sum = 0;
int l = Len-1;

for (int j = 0; j < l; j++, l--)
{
   sum = sum + (arr[j] * arr[l]);
}

Console.Write("сумма произведений пар чисел: " + sum);