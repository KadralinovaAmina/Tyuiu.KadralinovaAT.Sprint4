using Tyuiu.KadralinovaAT.Sprint4.Task5.V2.Lib;
Random rnd = new Random();
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы                                                 *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #2                                                              *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Найти количество отрицательных элементов                                *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] mtrx = new int[rows, columns];

Console.WriteLine("***************************************************************************");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    { 
    mtrx[i, j] = rnd.Next(-7, 5);
    }
}

Console.WriteLine("\nМассив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(mtrx);

Console.WriteLine("Количество отрицательных элементов = " + res);
Console.ReadKey();