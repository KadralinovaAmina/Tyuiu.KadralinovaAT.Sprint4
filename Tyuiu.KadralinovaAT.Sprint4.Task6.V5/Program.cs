using Tyuiu.KadralinovaAT.Sprint4.Task6.V5.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Кадралинова А. Т. | ПИНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы                                                 *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #5                                                              *");
Console.WriteLine("* Выполнила: Кадралинова Амина Тастемировна | ПИНб-25-1                   *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* подсчитайте количество элементов, длина которых равна 5                 *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

var planet = new string[] { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };
Console.WriteLine("Исходный массив:");
for (int i = 0; i <= planet.Length - 1; i++)
{
    Console.WriteLine(planet[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Количество элементов длина которых = 5:");
int nums = ds.Calculate(planet);
Console.WriteLine(nums);
Console.ReadKey();