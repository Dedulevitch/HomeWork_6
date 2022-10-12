/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */



Console.Clear();
Console.WriteLine("ВВЕДИТЕ B1 ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ K1");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ B2 ");
double b2 = int.Parse(Console.ReadLine());
Console.WriteLine("ВВЕДИТЕ K2 ");
double k2 = int.Parse(Console.ReadLine());
double x = 0;
double y = 0;

if (k1 == k2)
{
    if (b1 == b2) Console.WriteLine("ПРЯМЫЕ СОВПАДАЮТ");
    else Console.WriteLine("ПРЯМЫЕ ПАРАЛЕЛЬНЫ");
}
else 
{

x = (b2 - b1) / (k1-k2);
y = k1 * x + b1;
  
Console.Write($"{x} , {y}");
}
 








/* double x = 0;
double y = 2 * x + 3; // 5
double y2 = -x + 6;
Console.Write(y); */



/* Сonsole.WriteLine($"{x} и {y}"); */


// y = k * x + b  == 2 (это и есть константа b)- выражение первой прямой  ( k рост функции b константа xy - переменные)
// x = 0
// k - отношение от y до x  (дельта - разница = то есть если k= 3 три клетки вправо и вверх, 1,2 два вправо один вверх)
// потом идем от b к k (любая прямая может быть задана двумя точками)

// нужно найти x (y = k)