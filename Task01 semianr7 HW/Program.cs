// Написать программу, которая обменивает элементы первой строки и последней строки
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
Console.WriteLine("Произведем обмен элементов первой и последней строки");
Console.WriteLine("Новый массив: ");
int length = array.GetLength(0);
if (length == 2)
{
    for (int column = 0; column < array.GetLength(1); column++)
    {
        int temporary = array[0, column];
        array[0, column] = array[1, column];
        array[1, column] = temporary;
    }
}
if (length > 2)
{
    for (int raw = 0; raw < array.GetLength(0); raw++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            int temporary = array[0, column];
            array[0, column] = array[length - 1, column];
            array[length - 1, column] = temporary;
        }
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


