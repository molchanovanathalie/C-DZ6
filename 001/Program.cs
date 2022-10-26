// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, 
//y = k2 * x + b2, b1 k1 и b2 и k2 заданы

//y = k1 * x + b1,
//y = k2 * x + b2
//k1  x + b1 = k2  x + b2
//k1  x - k2  x = b2 - b1

int b1 = 5;
int b2 = 20;
int k1 = 6;
int k2 = 5;
int x = 0;
int y =0;
x = b2 - b1 / k1 - k2;
y = k1 * x + b1;

Console.Write($"координаты точки: {x}, {y}");
//Почему не работает? Что за ошибка - Программа не содержит статического 
//метода "Main", подходящего для точки входа.

string X(int k1, int k2, int b1, int b2)
{
    string result = string.Empty;
    int x = 0;
    int y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1) / (k1 - k2)) + b1;
    result = $"({x}, {y})";
    return result;
}
Console.WriteLine(X(2, -3, -3, 2));