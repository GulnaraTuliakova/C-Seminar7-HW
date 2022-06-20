// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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
int sum = 0;
int sumMin = 100;
for (int raw = 0; raw < array.GetLength(0); raw++)
{
    for (int column = 0; column < array.GetLength(1); column++)
   { 
         sum = sum + array[raw, column];
    }
    if (sum <= sumMin)
    {
        sumMin = sum;    
    }
    sum = 0;
   }
   Console.WriteLine($"Наименьшая сумма элементов в строке составляет {sumMin}");

