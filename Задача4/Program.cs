// Задайте двумерный массив. Введите элемент, и найдите первое его вхождение, 
// выведите позиции по горизонтали и вертикали, или напишите, что такого элемента нет.

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

void FindNumber(int[,] array)  //Находим только 1е число
{
    int number = Prompt("Введите число: ");
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == number)
            {
                Console.WriteLine($"Позиция числа {number}: Строка {i+1}, Столбец {j+1}");
                return;
            }
        }
        
    }
    Console.WriteLine($"Число {number} не найдено");
}

void FindNumber2(int[,] array)   // Находим все числа
{
    int number = Prompt("Введите число: ");
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == number)
            {
                sum++;
                Console.WriteLine($"Позиция {sum}го числа {number}: Строка {i+1}, Столбец {j+1}");
            }
            
        }
        
    }
    if(sum == 0) Console.WriteLine($"Число {number} не найдено");
}

int[,] array = FillArray(3,3);
PrintArray(array);
FindNumber(array);
Console.WriteLine("Второй метод");
FindNumber2(array);
