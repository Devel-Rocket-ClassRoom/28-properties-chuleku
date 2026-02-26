using System;
BankAccount account = new BankAccount();
account.Name = "홍길동";
account.ShowInfo();
Console.WriteLine("--- 50000원 입금 ---");
account.Deposit(50000);
Console.WriteLine("--- 20000원 출금 ---");
account.Withdraw(20000);
Console.WriteLine("--- 100000원 출금 시도 ---");
account.Withdraw(100000);

class BankAccount
{
    public readonly string AccountNumber;
    public string Name { get; set; }
    public bool _Withdraw;
    public int _Balance;
    public int Balance
    {
        get { return _Balance; }
        private set
        {
            if (Balance < 0)
            {
                _Balance = 0;
            }
        }
    }
    public BankAccount()
    {
        Name = "홍길동";
        _Balance = 0;
        AccountNumber = "123-456";
    }
    
    public void Deposit(int amount)
    {
        if (amount > 0)
        {
            _Balance += amount;
            Console.WriteLine($"잔액: {_Balance}");
        }
    }
    public void Withdraw(int amount)
    {
        if (amount < Balance)
        {
            _Balance -= amount;
            _Withdraw = true;
            Console.WriteLine($"출금 성공: {_Withdraw}");
            Console.WriteLine($"잔액: {_Balance}");
        }
        else if(amount > Balance)
        {
            _Withdraw=false;
            Console.WriteLine($"출금 성공: {_Withdraw}");
            Console.WriteLine($"잔액: {_Balance}");
        }
    }
    public void ShowInfo()
    {
        Console.WriteLine($"계좌번호: {AccountNumber}");
        Console.WriteLine($"예금주: {Name}");
        Console.WriteLine($"잔액: {_Balance}");
    }

}