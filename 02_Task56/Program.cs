// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

using static System.Console;
Clear();

WriteLine("Введите размеры (кол-во строк и столбцов) двумерного массива через пробел: ");
string[] parameters = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] paramet = ReadString(parameters);
int[,] array = GetRandomArray(paramet[0], paramet[1]);
PrintMatrix(array);
WriteLine();

int x = FindMin(array);
WriteLine($"Строкой с минимальной суммой элементов является {x}");

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

// Метод для нахождения строки с минимальной суммой элементов
int FindMin(int[,] m)
{
int currentSum = 0;
int minLine = 0;
int[] temp = new int[m.GetLength(0)];
for (int i = 0; i < m.GetLength(0); i++)
{
for (int j = 0; j < m.GetLength(1); j++)
{
currentSum += m[i, j];
}
temp[i] = currentSum;
WriteLine($"Сумма элементов строки {i} равна {currentSum}");
currentSum = 0;
}


int minElement = temp[0];

for (int i = 0; i < temp.Length; i++)
{
    if (temp[i] < minElement)
    {
        minElement = temp[i];
        minLine = i;
    }
}

return minLine;


}