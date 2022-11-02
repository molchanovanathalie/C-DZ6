//Написать программу масштабирования фигуры
// точка начала координат находится в точке пересечения диагоналей прямоугольника

// (0,0) (2,0) (2,2) (0,2) 

string Scaling(float x1, float y1, float x2, float y2, 
float x3, float y3, float x4, float y4, float k)
{
    x1 = x1 * k;
    y1 = y1 * k;
    x2 = x2 * k;
    y2 = y2 * k;
    x3 = x3 * k;
    y3 = y3 * k;
    x4 = x4 * k;
    y4 = y4 * k;
    return $"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})";
}
Console.WriteLine("Введите коэффициент: ");
float k = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(Scaling(0, 0, 2, 0, 2, 2, 0, 2, k));