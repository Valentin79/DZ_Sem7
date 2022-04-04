// Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintArithmeticMean(int[,] array)  // Считаем среднеарифметическое в столбцах
{ 
    double avg;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        avg = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            avg = avg + array[i,j];
        }
        Console.Write($"{avg / array.GetLength(0):0.00}\t");
    }
}

int[,] array = FillArray(7,5);
PrintArray(array);
for(int i = 0; i < array.GetLength(1); i++)
{
    Console.Write("=\t");
}
Console.WriteLine();
PrintArithmeticMean(array);