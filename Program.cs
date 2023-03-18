// Задайте двумерный массив целых чисел. Найдите среднее арифметическое элементов в каждом столбце
int numberLine = UserInput("Количество строк в новой таблице = ");
int numberColumb = UserInput("Количество столбцов в новой таблице = ");
int maximum = UserInput("Введите максимальное значение = ");
int minimum = UserInput("Введите минимальное значение = ");
int[,] CreateRandomDoubleMatrix(int line, int columb, int min, int max)
{
    int[,] matrix = new int[line, columb];
    for (int i = 0; i < line; i++)
    {
        for (int j = 0; j < columb; j++)
        {
            matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}
int UserInput(string massage)
{
    Console.Write(massage);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int[,] createRandomDoubleMatrix = CreateRandomDoubleMatrix(numberLine, numberColumb, minimum, maximum);
void PrintArrayMatrix(int[,] matrix, int line, int columb)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
PrintArrayMatrix(createRandomDoubleMatrix, numberLine, numberColumb);
int[] averageColumb = AverageColumb(createRandomDoubleMatrix);
PrintArray(averageColumb);
int[] AverageColumb(int[,] matrix)
{
    int[] average = new int[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average[j] = average[j] + matrix[i, j] / matrix.GetLength(0);
        }
    }
    return average;
}
void PrintArray(int[] array)
{
    Console.Write("Среднее значение ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Для столбца №{i + 1} = {array[i]} ; ");
    }
}

