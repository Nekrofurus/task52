// Задача 52 Задайте двумерный массив целых чисел. Найдите среднее арифметическое элементов в каждом столбце
int numberLine = UserInput("Количество строк в новой таблице = ");
int numberColumb = UserInput("Количество столбцов в новой таблице = ");
int maximum = UserInput("Введите максимальное значение = ");
int minimum = UserInput("Введите минимальное значение = ");
int[,] createRandomDoubleMatrix = CreateRandomDoubleMatrix(numberLine, numberColumb, minimum, maximum);
PrintArrayMatrix(createRandomDoubleMatrix, numberLine, numberColumb);
double[] averageColumb = AverageColumb(createRandomDoubleMatrix);
PrintArrayMidl(averageColumb);

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
double[] AverageColumb(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    double[,] matrixdouble = new double[matrix.GetLength(0),matrix.GetLength(1)];
       for (int j = 0; j < matrix.GetLength(1); j++)
    {
        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrixdouble[i, j] = Convert.ToDouble(matrix[i, j]);
            average[j] = Math.Round(average[j] + matrixdouble[i, j] / matrixdouble.GetLength(0), 1);
        }
    }
    return average;
}
void PrintArrayMidl(double[] array)
{
    Console.Write("Среднее значение ");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -1) Console.Write($"Для столбца №{i + 1} = {array[i]} ; ");
        else Console.Write($"Для столбца №{i + 1} = {array[i]}.");
    }
}

