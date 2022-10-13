// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

using static System.Console;
Clear();

WriteLine("Введите размеры (кол-во строк и столбцов) двумерного массива через пробел: ");
string[] parameters = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] paramet = ReadString(parameters);
int[,] array = GetRandomArray(paramet[0], paramet[1]);
PrintMatrix(array);
WriteLine();
SortMatrix(array);
PrintMatrix(array); 








// Метод для конвертации строки в int
int[] ReadString(string[] input)
{
    int[] result = new int[input.Length];
    for (int i = 0; i < input.Length; i++)
    {
        result[i] = Convert.ToInt32(input[i]);
    }
    return result;
}


// Метод-генератор двумерного массива заданных размеров, заполненного случайными числами
int[,] GetRandomArray(int lines, int columns)
{
    int[,] result = new int[lines, columns];
    for (int i = 0; i < lines; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(1, 100);
        }
    }
    return result;
}


// Метод для печати двумерного массива
void PrintMatrix(int[,] inMatrix)
{
    for (int i = 0; i < inMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inMatrix.GetLength(1); j++)
        {
            Write($"{inMatrix[i, j]}\t");
        }
        WriteLine();
    }
}


// Метод сортировки строк в массиве по убыванию
void SortMatrix(int[,] m)
{
    int temp = 0;
    for (int k = 0; k < m.GetLength(0); k++)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = i + 1; j < m.GetLength(1); j++)
            {
                if (m[k,i] < m[k,j])
                {
                    temp = m[k, i];
                    m[k, i] = m[k, j];
                    m[k, j] = temp;
                }
            }
        }
    }
}
