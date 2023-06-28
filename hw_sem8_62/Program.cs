using System;

public static class SpiralArrayProgram
{
void Main()
    {
        int size = 4; // Размер массива (4x4)

        int[,] array = FillSpiralArray(size);

        // Выводим заполненный массив на консоль
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write(array[i, j].ToString("D2") + " ");
            }
            Console.WriteLine();
        }
    }
int[,] FillSpiralArray(int size)
    {
        int[,] array = new int[size, size];
        int value = 1;
        int minRow = 0;
        int maxRow = size - 1;
        int minCol = 0;
        int maxCol = size - 1;

        while (value <= size * size)
        {
            // Заполняем верхнюю горизонтальную строку
            for (int i = minCol; i <= maxCol; i++)
            {
                array[minRow, i] = value++;
            }
            minRow++;// Заполняем правый вертикальный столбец
            for (int i = minRow; i <= maxRow; i++)
            {
                array[i, maxCol] = value++;
            }
            maxCol--;

            // Заполняем нижнюю горизонтальную строку
            for (int i = maxCol; i >= minCol; i--)
            {
                array[maxRow, i] = value++;
            }
            maxRow--;

            // Заполняем левый вертикальный столбец
            for (int i = maxRow; i >= minRow; i--)
            {
                array[i, minCol] = value++;
            }
            minCol++;
        }

        return array;
    }
}