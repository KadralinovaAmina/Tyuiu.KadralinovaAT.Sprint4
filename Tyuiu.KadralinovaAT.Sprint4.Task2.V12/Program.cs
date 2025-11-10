using Tyuiu.KadralinovaAT.Sprint4.Task2.V12.Lib;
Random rnd = new Random();
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы                                                *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #12                                                             *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* подсчитать сумму нечетных элементов массива                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите количество элементов массива: ");
int len = Convert.ToInt32(Console.ReadLine());

int[] numsArray = new int[len];

for (int i = 0; i < len; i++)
{
    numsArray[i] = rnd.Next(4, 9);
}
Console.WriteLine("Массив: ");
for (int i = 0; i < len; i++)
{
    Console.Write(numsArray[i] + "\t");
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(numsArray);

Console.WriteLine("Сумма нечетных элементов массива = " + res);
Console.ReadKey();