// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] array = new Int32[4, 7];
randomFilling(array, 0, 10);
arrayOutput(array);
arithmeticMeanColumn(array);
void randomFilling(int[,] arr, int min, int max)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }}}
void arithmeticMeanColumn(int[,] arr)
{
    int sum = 0;
    Console.Write("Arithmetic mean value: ");
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write(Math.Round((double)sum / arr.GetLength(0), 1) + "  ");
        sum = 0;
    }
}
void arrayOutput(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "  ");
        }
        Console.WriteLine(" ");
    }
}
