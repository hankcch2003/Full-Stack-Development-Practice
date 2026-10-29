using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("C# 程式設計練習");
        Console.WriteLine("第十二章：類別與物件");
        Console.WriteLine("================================");

        // 一、建立物件
        // class 定義類別，描述物件具有哪些資料與功能。
        // new 用來建立物件。

        Book book1 = new Book();

        // 使用 . 存取物件的欄位。
        book1.title = "C# 入門教學";
        book1.author = "王小明";
        book1.price = 450;

        Console.WriteLine();
        Console.WriteLine("========== 第一個物件 ==========");
        book1.ShowInfo();

        // 二、建立另一個物件
        // 同一個類別可以建立多個物件，各自保存自己的資料。

        Book book2 = new Book();
        book2.title = "Java 程式設計";
        book2.author = "陳小華";
        book2.price = 520;

        Console.WriteLine();
        Console.WriteLine("========== 第二個物件 ==========");
        book2.ShowInfo();

        // 三、修改物件資料
        book1.price = 399;

        Console.WriteLine();
        Console.WriteLine("========== 修改第一本書的價格 ==========");
        book1.ShowInfo();

        // 四、物件可以呼叫方法執行功能
        Console.WriteLine();
        Console.WriteLine("========== 書籍折扣 ==========");
        double discountedPrice = book1.CalculateDiscount(0.9);
        Console.WriteLine("九折後價格：" + discountedPrice.ToString("F0"));

        // 五、建立會員物件
        Member member1 = new Member();
        member1.name = "Amy";
        member1.points = 100;

        Console.WriteLine();
        Console.WriteLine("========== 會員資料 ==========");
        member1.ShowInfo();
        member1.AddPoints(50);
        Console.WriteLine("增加點數後：");
        member1.ShowInfo();
    }
}

// Book 類別：定義書籍的資料與功能。
class Book
{
    // 欄位用來保存物件的資料。
    public string title = "";
    public string author = "";
    public double price;

    // 方法定義物件可以執行的功能。
    public void ShowInfo()
    {
        Console.WriteLine("書名：" + title);
        Console.WriteLine("作者：" + author);
        Console.WriteLine("價格：" + price.ToString("F0"));
    }

    // 參數 discount 代表折扣倍率，例如 0.9 代表九折。
    public double CalculateDiscount(double discount)
    {
        return price * discount;
    }
}

// Member 類別：定義會員的資料與功能。
class Member
{
    public string name = "";
    public int points;

    public void ShowInfo()
    {
        Console.WriteLine("會員名稱：" + name);
        Console.WriteLine("會員點數：" + points);
    }

    public void AddPoints(int amount)
    {
        points += amount;
    }
}