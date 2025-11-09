using Tyuiu.KadralinovaAT.Sprint4.Task0.V5.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы                                                *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* подсчитать сумму четных элементов массива                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] numsArray = { 8, 9, 4, 1, 2, 3, 4, 5, 6, 7 };

Console.WriteLine("Исходный массив:");

for (int i = 0; i < numsArray.Length; i++)
{
    Console.WriteLine(numsArray[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Результирующий массив:");

int res = ds.GetSumEvenArrEl(numsArray);

Console.WriteLine("Сумма четных элементов: " + res);

Console.WriteLine();
Console.ReadKey();