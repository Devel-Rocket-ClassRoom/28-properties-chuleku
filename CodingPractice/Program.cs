using Microsoft.VisualBasic;
using System;
using System.Data;
///과제 1: public 필드의 문제점
/*Player player = new Player();
player.Health = 100;
player.Health = -999;
class Player
{
    public int Health;
}*/
///과제 2: Get/Set 메서드 방식
/*Player player = new Player();
player.setHealtlh(100);
Console.WriteLine(player.GetHealth());
class Player
{
    private int _Health;

    public void setHealtlh(int value)
    {
        if (value >= 0 && value <= 100)
        {
            _Health = value;
        }
    }
    public int GetHealth()
    {
        return _Health;
    }
}*/
///과제 3: 전체 프로퍼티
/*Person person = new Person();
person.name = "홍길동";
Console.WriteLine(person.name);
class Person
{
    private string _Name;
    public string name
    {
        get { return _Name; }
        set {  _Name = value; }
    }
}*/
///과제 4: 자동 구현 프로퍼티
/*Developer dv = new Developer();
dv.name = "김개발";
dv.age = 25;
Console.WriteLine($"{dv.name}, {dv.age}세");
class Developer
{
    public string name { get; set; }
    public int age { get; set; }
}*/
///과제 5: 자동 프로퍼티 이니셜라이저
/*Player player = new Player();
Console.WriteLine($"이름: {player.Name}");
Console.WriteLine($"레벨: {player.Level}");
Console.WriteLine($"최대 체력: {player.MaxHealth}");
class Player
{
    public string Name { get; set; } = "플레이어";
    public int Level { get; set; } = 1;
    public int MaxHealth { get; set; } = 100;
}*/
///과제 6: 전체 프로퍼티 vs 자동 프로퍼티
/*Car car = new Car();
car.name = "소나타";
car.Color = "검정";
Console.WriteLine($"{car.name},{car.Color}");
class Car
{
    private string Name;
    public string name
    {
        get { return Name; }
        set { Name = value; }
    }
    public string Color { get; set; }

}*/
///과제 7: 읽기 전용 프로퍼티
/*Product product = new Product();
Console.WriteLine(product.Manufacturer);
class Product
{
    public string Manufacturer
    {
        get { return "한국전자"; }
    }
}*/
///과제 8: private set을 사용한 읽기 전용
/*Page mesage = new Page();
Console.WriteLine(mesage.Message);
mesage.UpdateMessage("업데이트된 메시지");
Console.WriteLine(mesage.Message);
class Page
{
    public string Message { get; private set; } = "읽기 전용 메세지";
    public void UpdateMessage(string newmessage)
    {
        Message = newmessage;
    }
}*/
///과제 9: 쓰기 전용 프로퍼티
/*SecureData data = new SecureData();
data.Password = "sc12345";
Console.WriteLine(data.Validate("sc12345"));
class SecureData
{
    private string _Password;
    public string Password
    {
        set { _Password = value; }
    }
    public bool Validate(string input)
    {
        return _Password == input;
    }
}*/
///과제 10: 읽기 전용 식 본문 프로퍼티
/*Circle radius = new Circle();
radius.Radius = 5;
Console.WriteLine($"반지름:{radius.Radius}");
Console.WriteLine($"넓이: {radius.area}");
Console.WriteLine($"둘레: {radius.Circumference}");
class Circle
{
    public double Radius { get; set; }
    public double area => 3.14159 * Radius * Radius;
    public double Circumference => 2 * 3.14159 * Radius;
}*/
///과제 11: get/set 식 본문
/*Counter count = new Counter();
count.count = 10;
count.Increase();
Console.WriteLine($"카운트: {count.count}");
class Counter
{
    public int _count;
    public int count
    {
        get => _count;
        set => _count = value;
    }
    public void Increase() => _count++;
}*/
///과제 12: 프로퍼티에서 유효성 검사
/*Player player = new Player();
player.Health = 150;
Console.WriteLine($"체력: {player._Health}");
player.Health = -50;
Console.WriteLine($"체력: {player._Health}");
class Player
{
    public int _Health;
    public int Health
    {
        get { return _Health; }
        set
        {
            if(value>=100)
            {
                _Health = 100;
            }
            else if (value<=0)
            {
                _Health = 0;
            }
            else
            {
                _Health = value;
            }
        }
    }
}*/
///과제 13: 계산된 프로퍼티
/*Person person = new Person();
person.Name = "홍길동";
person.birthyear = 2000;
Console.WriteLine($"이름:{person.Name}, 나이: {person.age}");
class Person
{
    private int _birthyear;
    public string Name { get; set; }
    public int birthyear
    {
        set
        {
            if(value>=1900)
            {
                _birthyear = value;
            }
        }
    }
    public int age
    {
        get { return DateTime.Now.Year - _birthyear; }
    }
}*/
///과제 14: 개체 이니셜라이저 (기존 방식)
/*Course course1 = new Course();
course1.id = 1;
course1.Title = "C# 기초";
Console.WriteLine($"{course1.id} - {course1.Title}");

class Course
{
    public int id { get; set; }
    public string Title { get; set; }
}*/
///과제 15: 개체 이니셜라이저 사용
/*Course course1 = new Course { id = 2, Title = "Unity 게임 개발" };
Console.WriteLine($"{course1.id} - {course1.Title}");
Course[] course = 
{    
     new Course { id = 1,Title = "C# 기초"},
     new Course { id = 2 ,Title ="C# 중급"},
     new Course { id = 3, Title = "Unity 입문" }
};
foreach (Course c in course)
{
    Console.WriteLine($"{c.id}. {c.Title}");
}
class Course
{
    public int id { get; set; }
    public string Title { get; set; }
}*/
///과제 16: 데이터 클래스
// 개체 이니셜라이저로 초기화
/*Customer customer = new Customer
{
Id = 1,
Name = "김철수",
Email = "kim@example.com",
City = "서울"
};

Console.WriteLine($"고객 #{customer.Id}");
Console.WriteLine($"이름: {customer.Name}");
Console.WriteLine($"이메일: {customer.Email}");
Console.WriteLine($"도시: {customer.City}");
class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string City { get; set; }
}*/
///과제 17: 정적 프로퍼티
/*Console.WriteLine($"게임: {GameSettings.GameTitle}");
Console.WriteLine($"최대 플레이어: {GameSettings.MaxPlayers}");
Console.WriteLine($"사운드: {GameSettings.IsSoundEnabled}");
GameSettings.MaxPlayers = 8;
Console.WriteLine($"변경된 최대 플레이어: {GameSettings.MaxPlayers}");
class GameSettings
{
    public static string GameTitle { get; set; } = "My Game";
    public static int MaxPlayers { get; set; } = 4;
    public static bool IsSoundEnabled { get; set; } = true;
}*/
///과제 18: 프로퍼티 종합 예제
/*Monster Goblin = new Monster("고블린");
Goblin.Level = 5;
Goblin.Attack = 15;
Console.WriteLine($"이름: {Goblin.Name}");
Console.WriteLine($"레벨: {Goblin.Level}");
Console.WriteLine($"체력: {Goblin.Health}");
Console.WriteLine($"공격력: {Goblin.Attack}");
Console.WriteLine($"방어력: {Goblin.Defence}");
Console.WriteLine($"생존: {Goblin.IsAlive}");
Goblin.TakeDamage(50);
Console.WriteLine($"50대미지 후 체력: {Goblin.Health}");
class Monster
{
    private int _Health;
    private const int k_MaxHealth = 200;
    public int Health
    {
        get { return _Health; }
        set
        {
            if (value < 0)
            {
                _Health = 0;
            }
            else if (value >= k_MaxHealth)
            {
                _Health = k_MaxHealth;
            }
            else
            {
                _Health = value;
            }
        }
    }
    public int Level { get; set; } = 1;
    public int Attack { get; set; } = 10;
    public string Name { get; private set; }
    public bool IsAlive => Health > 0;
    public int Defence => Level * 2;
    public Monster(string name)
    {
        Name = name;
        Health = 100;
    }*/

/*    public void TakeDamage(int damage)
    {
        int actualdamage = damage - Defence;
        if(actualdamage>0)
        {
            Health -= actualdamage;
        }
    }

}*/