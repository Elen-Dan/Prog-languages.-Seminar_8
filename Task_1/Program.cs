/*
Задача 1:
Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Clear();
Console.WriteLine("Введите количество строк: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int Num2 = Convert.ToInt32(Console.ReadLine());


int[,] Array = new int[Num1, Num2];

for (int i = 0; i < Num1; i++)
{
    for (int j = 0; j < Num2; j++)
    {
        Array[i, j] = new Random().Next(1, 100);
        Console.Write($"{Array[i, j]} "); //вывод значений массива для примера

    }
    Console.WriteLine();
}

int k = 0;
int[] tmpArray = new int[Num2];
while  (k < Array.GetLength(0))
    {
    int SumString = 0;
    for (int l = 0; l < Array.GetLength(1); l++)
        {
            SumString = SumString + Array[k, l];
            tmpArray[l] =  SumString; //заносим сумму строк во временный одномерный массив
        }
        Console.WriteLine(SumString); //выводим для проверки суммы строк
                              
    k++;
    }


int minSumString = tmpArray[0];
int numString = 0;
for (int m = 0; m < tmpArray.Length; m++)
    {
        if (minSumString < tmpArray[m])
            {
                minSumString = tmpArray[m];
                numString++;
            }
    
    }
   Console.WriteLine($"Строка с наименьшей суммой элементов: {numString}");

