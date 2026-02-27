using System;
Student kim = new Student("±èÃ¶¼ö",85,90,95);
Console.WriteLine($"±¹¾î: {kim.KoreanScore}, ¿µ¾î: {kim.EnglishScore}, ¼öÇÐ: {kim.MathScore}");
Console.WriteLine($"ÃÑÁ¡: {kim.TotalScore}");
Console.WriteLine($"Æò±Õ: {kim.Average:F2}");
Console.WriteLine($"ÇÐÁ¡: {kim.Grade}");
Console.WriteLine();
Student Lee = new Student("ÀÌ¿µÈñ", 75, 80, 70);
Console.WriteLine($"±¹¾î: {Lee.KoreanScore}, ¿µ¾î: {Lee.EnglishScore}, ¼öÇÐ: {Lee.MathScore}");
Console.WriteLine($"ÃÑÁ¡: {Lee.TotalScore}");
Console.WriteLine($"Æò±Õ: {Lee.Average:F2}");
Console.WriteLine($"ÇÐÁ¡: {Lee.Grade}");
Console.WriteLine();
Student park = new Student("ÀÌ¿µÈñ", 110, 120, -10);
Console.WriteLine($"±¹¾î: {park.KoreanScore}, ¿µ¾î: {park.EnglishScore}, ¼öÇÐ: {park.MathScore}");
Console.WriteLine($"ÃÑÁ¡: {park.TotalScore}");
Console.WriteLine($"Æò±Õ: {park.Average:F2}");
Console.WriteLine($"ÇÐÁ¡: {park.Grade}");
class Student
{
    public string Name { get; }
    private int _KoreanScore;

    public Student(string name,int korea,int eng,int Math)
    {
        KoreanScore = korea;
        EnglishScore = eng;
        MathScore = Math;
        Name = name;
        Console.WriteLine($"=== ¼ºÀûÇ¥: {Name} ===");
    }
    public int KoreanScore
    {
        get { return _KoreanScore; }
        set
        {
            if(value<=0)
            {
                _KoreanScore = 0;
            }
            else if(value >= 100)
            {
                _KoreanScore = 100;
            }
            else
            {
                _KoreanScore = value;
            }
        }
    }
    private int _EnglishScore;
    public int EnglishScore
    {
        get { return _EnglishScore; }
        set
        {
            if (value <= 0)
            {
                _EnglishScore = 0;
            }
            else if (value >= 100)
            {
                _EnglishScore = 100;
            }
            else
            {
                _EnglishScore = value;
            }
        }
    }
    private int _MathScore;
    public int MathScore
    {
        get { return _MathScore; }
        set
        {
            if( value <= 0)
            {
                _MathScore = 0;
            }
            else if(value >= 100)
            {
                _MathScore = 100;
            }
            else
            {
                _MathScore=value;
            }
        }
    }
    public int _TotalScore;
    public int TotalScore
    {
        get { return (KoreanScore + EnglishScore + MathScore); }

    }
    public double _Average;
    public double Average
    {
        get { return TotalScore / 3.0; }
    }
    public string Grade
    {
        get
        {
            if(Average>=90)
            {
                return "A";
            }
            else if(Average>=80)
            {
                return "B";
            }
            else if(Average>=70)
            {
                return "C";
            }
            else if(Average>=60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}