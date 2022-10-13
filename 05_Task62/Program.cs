// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

using static System.Console;
Clear();

WriteLine("Введите размеры (кол-во строк и столбцов) массива: ");
string[] parameters1 = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] paramet1 = ReadString(parameters1);
int[,] array1 = GetMagicArray(paramet1[0], paramet1[1]);

PrintMatrix(array1);
WriteLine();




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
int[,] GetMagicArray(int lines, int columns)
{
    int[,] result = new int[lines, columns];
    int count = 1;
    int i = 0;
    int j = 1;
    int n = 1;
    for (int z = 1; z < columns; z++)
    {
        if (result[i, j] == 0)
        {
           for (; j < result.GetLength(1) - z; j++)
            {
                result[i, j] = count;
                count++;
            }
         }
        else i++;


        if (result[i, j] == 0)
        {
            for (; i < lines - z; i++)
            {
                result[i, j] = count;
                count++;
            }
        }
        else j--;


        if (result[i, j] == 0)
        {
            for (; j >= z; j--)
            {
                result[i, j] = count;
                count++;
            }
        }
        else i--;


        if (result[i, j] == 0)
        {
            for (; i > z; i--)
            {
                result[i, j] = count;
                count++;
            }
        }
        else j++;
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



// Метод для перемножения матриц
int[,] MegaMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] megaMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                megaMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return megaMatrix;
}
