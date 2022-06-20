// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).
Console.WriteLine("Введите количество строк в массиве: ");
int i = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов в массиве: ");
int j = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[i, j];
for (int raw = 0; raw < array.GetLength(0); raw++)
{
    for (int column = 0; column < array.GetLength(1); column++)
    {
        array[raw, column] = new Random().Next(1, 10);
    }
}
for (int raw = 0; raw < array.GetLength(0); raw++)
{
    for (int column = 0; column < array.GetLength(1); column++)
    {
        Console.Write(array[raw, column] + "  ");
    }
    Console.WriteLine();
}
Console.WriteLine("Произведем обмен элементов строк и столбцов");
Console.ReadLine();
if (i != j)
{
    Console.WriteLine("Произвести обмен строк и столбцов невозможно, т.к. матрица не квадратная!");

}
if (i == j)
{
    Console.WriteLine("Новый массив: ");
    {
        for (int raw = 0; raw < array.GetLength(0); raw++)
        {
            for (int column = 0; column < array.GetLength(1); column++)
            {
                Console.Write(array[column, raw] + "  ");
            }
            Console.WriteLine();
        }
    }
}
