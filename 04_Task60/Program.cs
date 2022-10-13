// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

using static System.Console;
Clear();

WriteLine("Введите размеры трехмерного массива: ");
string[] parameters1 = ReadLine()!.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
int[] paramet1 = ReadString(parameters1);
int[,,] array1 = GetRandomArray(paramet1[0], paramet1[1], paramet1[2]);

PrintMatrix(array1);

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

// Метод-генератор трехмерного массива заданных размеров, заполненного случайными неповторяющимися числами
int[,,] GetRandomArray(int lines, int columns, int width)
{
int[,,] result = new int[lines, columns, width];
int[] checkArray = new int[lines*columns*width];
int count = 0;
for (int i = 0; i < lines; i++)
{
for (int j = 0; j < columns; j++)
{
for (int k = 0; k < width; k++)
{
int x = new Random().Next(10, 100);

            Check:
            bool check = FindNumber(checkArray, x);
            if (check == true)
                {
                    x = new Random().Next(10, 100);
                    goto Check;
                }
            checkArray[count] = x;
            count++;
            result[i, j, k] = x;
        }

    }
}
return result;

}

// Метод для построчной печати трехмерного массива
void PrintMatrix(int[,,] inMatrix)
{
int i = 0;
int j = 0;
int k = 0;
for (i = 0; i < inMatrix.GetLength(0); i++)
{
for (j = 0; j < inMatrix.GetLength(1); j++)
{
for (k = 0; k < inMatrix.GetLength(2); k++)
{
Write($"{inMatrix[i, j, k]}");
Write($"({i},{j},{k})\t");
}
WriteLine();
}
WriteLine();
}
WriteLine();
}

// Метод для проверки наличия в массиве определенного числа
bool FindNumber(int[] line, int z)
{
bool found = false;
for (int i = 0; i < line.Length; i++)
{
if(line[i] == z) found = true;
}
return found;
}