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
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());


int[,] Array = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Array[i, j] = new Random().Next(1, 100);
        Console.Write($"{Array[i, j]} "); //вывод значений массива для примера
    }
    Console.WriteLine();
}

int minSumRow = 0;
int sumLine = SumRowElements(Array, 0);
for (int i = 1; i < Array.GetLength(0); i++)
{
  int tempSumLine = SumRowElements(Array, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumRow = i;
  }
}

Console.WriteLine($"\n{minSumRow+1} - строкa с наименьшей суммой элементов ({sumLine})");

int SumRowElements(int[,] array, int i)
{
  int sumRow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumRow += array[i,j];
  }
  return sumRow;
}