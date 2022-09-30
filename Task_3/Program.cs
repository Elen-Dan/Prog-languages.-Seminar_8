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
        {
            CreateArray(Array);
            for (int i = 0; i < Array.GetLength(0); i++)
                {
                    for (int j = 0; j < Array.GetLength(1); j++)
                        {
                            Console.Write(Array[i, j] +" ");
                        }
                Console.WriteLine();
                }
        }
   
void CreateArray(int[,] Array)
{
  int[] temp = new int[Array.GetLength(0) * Array.GetLength(1)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 99);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 99);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int m = 0; m < Array.GetLength(0); m++)
  {
    for (int n = 0; n < Array.GetLength(1); n++)
    {
        Array[m, n] = temp[count];
        count++;
    }
  }
}
