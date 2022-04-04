// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

void NumberInPosition(int[,] array)
{
    int row = Prompt("Введите строку: ");
    int col = Prompt("Введите столбец: ");
    if( row > array.GetLength(0) || row <= 0
    || col > array.GetLength(1) || col <= 0) 
    {
        Console.WriteLine("Неверные параметры");
        return;
    }
    Console.WriteLine($"Искомое число: {array[row-1,col-1]}");
}

int[,] array = FillArray(3,3);
PrintArray(array);
NumberInPosition(array);