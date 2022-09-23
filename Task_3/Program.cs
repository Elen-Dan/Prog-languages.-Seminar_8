/*
Сформируйте двухмерный массив из неповторяющихся двузначных чисел (размер массива не более 50 элементов). 
Напишите программу, которая будет построчно выводить массив.
*/

Console.Clear();
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] Array = new int[rows, cols];
if ((rows * cols) > 50)
{
    Console.WriteLine("Количество элементов больше 50");
}
else
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Array[i, j] = new Random().Next(1, 100);
            for (int k = 0; k<Array.GetLength(0); k++)
                {
                    for (int l = 0; l < Array.GetLength(1); l++)
                        {
                            if (Array[i, j] == Array[k, l])
                            Array[i, j] = new Random().Next(1, 100);
                        }
                }
            Console.Write($"{Array[i, j]} "); //вывод значений массива для примера
        }
        Console.WriteLine();
    }
