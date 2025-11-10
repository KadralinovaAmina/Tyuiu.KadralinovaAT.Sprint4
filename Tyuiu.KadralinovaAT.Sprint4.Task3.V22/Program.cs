using Tyuiu.KadralinovaAT.Sprint4.Task3.V22.Lib;

int[,] array = new int[5, 5] { { 4, 4, 7, 8, 9 },
                              { 9, 5, 9, 7, 8 },
                              { 7, 4, 9, 4, 6 },
                              { 4, 4, 7, 4, 4 },
                              { 4, 5, 8, 6, 7 } };

DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы                                                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #3                                                              *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Найти максимальный элемент в первой строке массива                      *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив: ");
int max = array[0, 0];
for (int i = 0; i < array.GetLength(1); i++)
{
    Console.Write($"{max = array[0, i]} \t");
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(array);

Console.WriteLine("Максимальный элемент в первой строке массива = " + res);
Console.ReadKey();