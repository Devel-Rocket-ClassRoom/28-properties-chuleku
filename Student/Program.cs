using System;

class Student
{
    private readonly string Name;
    public int _KoreanScore;
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
    public int _EnglishScore;
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
    public int _MathScore;
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
        get { return _TotalScore; }
        set
        {
            _TotalScore=_KoreanScore+_EnglishScore+_MathScore;
        }
    }
    public int _Average;
    public int Average
    {
        get { return _Average; }
        set
        {
            
        }
    }

}