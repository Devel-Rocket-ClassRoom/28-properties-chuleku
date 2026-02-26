using System;
Rectangle rectangle1 = new Rectangle();
rectangle1.Width = 10;
rectangle1.Height = 5;
rectangle1.Area();
rectangle1.Perimeter();
rectangle1.IsSquare();
Console.WriteLine("=== 사각형 1 ===");
Console.WriteLine($"가로: {rectangle1.Width}, 세로: {rectangle1.Height}");
Console.WriteLine($"넓이: {rectangle1._Area}");
Console.WriteLine($"둘레: {rectangle1._Perimeter}");
Console.WriteLine($"정사각형: {rectangle1._IsSquare}");
Console.WriteLine();
Rectangle rectangle2 = new Rectangle();
rectangle2.Width = 7;
rectangle2.Height = 7;
rectangle2.Area();
rectangle2.Perimeter();
rectangle2.IsSquare();
Console.WriteLine("=== 사각형 2 ===");
Console.WriteLine($"가로: {rectangle2.Width}, 세로: {rectangle2.Height}");
Console.WriteLine($"넓이: {rectangle2._Area}");
Console.WriteLine($"둘레: {rectangle2._Perimeter}");
Console.WriteLine($"정사각형: {rectangle2._IsSquare}");
Console.WriteLine();
Rectangle rectangle3 = new Rectangle();
rectangle3.Width = 1;
rectangle3.Height = 1;
rectangle3.Area();
rectangle3.Perimeter();
rectangle3.IsSquare();
Console.WriteLine("=== 기본 사각형  ===");
Console.WriteLine($"가로: {rectangle3.Width}, 세로: {rectangle3.Height}");
Console.WriteLine($"넓이: {rectangle3._Area}");
Console.WriteLine($"둘레: {rectangle3._Perimeter}");
Console.WriteLine($"정사각형: {rectangle3._IsSquare}");
class Rectangle
{
    public int Width { get; set; } = 1;
    public int Height { get; set; } = 1;
    public int _Area;
    public void Area()
    {
       _Area = Width * Height;
    }
    public int _Perimeter;
    public void Perimeter()
    {
        _Perimeter = 2 * (Width + Height);
    }
    public bool _IsSquare;
    public void IsSquare()
    {

        if (Width == Height)
        {
            _IsSquare = true;
        }

    }
}