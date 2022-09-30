/*
Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

Console.Clear();
Console.WriteLine("Введите количество строк матрицы: ");
int rows = Convert.ToInt32(Console.ReadLine());
int columns = rows;

int[,] matrix1 = new int[rows, columns];
int[,] matrix2 = new int[rows, columns];

int[,] EndMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            matrix1[i, j] = new Random().Next(1, 100);
            matrix2[i, j] = new Random().Next(1, 100);
            Console.Write(matrix1[i, j] + " "); //вывод значений массива для примера
            Console.Write(matrix2[i, j] + " ");
        }
            Console.WriteLine(" ");
}
MultiplicateMatrix(matrix1, matrix2, EndMatrix);

void MultiplicateMatrix(int[,] matrix1, int[,] matrix2, int[,] EndMatrix)
{   
    for (int i = 0; i < EndMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < EndMatrix.GetLength(1); j++)
            {   
                int tempsum = 0;
                for (int k = 0; k < matrix1.GetLength(1); k++)
                    {
                        tempsum = tempsum + matrix1[i, k] * matrix2[k , j];
                    }
                EndMatrix[i, j] = tempsum;
            }
    }
}
Console.WriteLine("- - - - - - - - - ");
Console.WriteLine("Результат перемножения двух матриц:");
Console.WriteLine("- - - - - - - - - ");
for (int i = 0; i < EndMatrix.GetLength(0); i++)
    {
    for (int j = 0; j < EndMatrix.GetLength(1); j++)
        {
               Console.Write(EndMatrix[i, j] + " ");
        }
    Console.WriteLine();
    }
   