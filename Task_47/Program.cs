// Запросите от пользователя размерности двумерного массива. Напишите метод для заполнения массива случайными числами. 
// Напишите метод для вывода массива на экран (постарайтесь вывести массив красиво). 
// Округлите значения, генерируемые Random до двух знаков после запятой.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.WriteLine("введите количество строк m: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов n: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m, n] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        Console.Write("[ ");
        for (int n = 0; n < array.GetLength(1); n++)
        {
            Console.Write(array[m, n] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}