// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

using static System.Console;
Clear();

WriteLine("Введите размеры (кол-во строк и столбцов) первой матрицы: ");
string[] parameters1 = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] paramet1 = ReadString(parameters1);
int[,] array1 = GetRandomArray(paramet1[0], paramet1[1]);

WriteLine("Введите размеры (кол-во строк и столбцов) второй матрицы: ");
string[] parameters2 = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] paramet2 = ReadString(parameters2);
int[,] array2 = GetRandomArray(paramet2[0], paramet2[1]);
if (paramet1[1] != paramet2[0])
{
WriteLine("Такие матрицы невозможно перемножить");
return;
}

PrintMatrix(array1);
WriteLine();
PrintMatrix(array2);
WriteLine();
int[,] newMatrix = MegaMatrix(array1, array2);
PrintMatrix(newMatrix);

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
result[i, j] = new Random().Next(1, 10);
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