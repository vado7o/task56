// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
Console.WriteLine("Программа находит строку массива с наименьшей суммой элементов");

int row = AskForInput("строк");
int column = AskForInput("столбцов");

int[,] array = FillArray(row, column, 1, 10);
int count = 1;
int sum = 0;

Console.Write("\nCгенерированный массив: \n");
PrintArray(array);

System.Console.WriteLine($"\nНаименьшая сумма элементов ({SumArrayRow(array)}) находится в строке {count}!");



//////////////////////////// функции ////////////////////////////////////////////////////

int[,] FillArray(int row, int column, int min, int max)
{
    int[,] filledArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            filledArray[i, j] = new Random().Next(min, max);
        }
    }
    return filledArray;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
    Console.WriteLine();
    }   
}

int AskForInput(string str)
{
    while (true)
    {
        Console.Write($"\nНапишите - из скольки {str} должен состоять массив? :");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number > 0) 
            {
                return number;
                break;
            }
            else Console.WriteLine($"Некорректно указано количество {str} массива!\n");
        }
        else Console.WriteLine($"Некорректно указано количество {str} массива!\n");
    }
}

int SumArrayRow(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array[i, j];
        }
        if(sum == 0)
        {
            sum = tempSum;
            count = i + 1;
        }
        else if(tempSum < sum)
        {
            sum = tempSum;
            count = i + 1;
        }
    }
    return sum; 
}