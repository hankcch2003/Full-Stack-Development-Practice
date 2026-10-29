using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("C# 程式設計練習");
        Console.WriteLine("第十三章：建構子、屬性與存取修飾詞");
        Console.WriteLine("================================");

        // 一、建立物件時，透過建構子設定初始資料。
        Book book1 = new Book("C# 入門教學", "王小明", 450);

        Console.WriteLine();
        Console.WriteLine("========== 建立書籍 ==========");
        book1.ShowInfo();

        // 二、透過屬性讀取與修改資料。
        book1.Price = 399;
        book1.Title = "C# 程式設計入門";

        Console.WriteLine();
        Console.WriteLine("========== 修改書籍 ==========");
        book1.ShowInfo();

        // 三、使用唯讀屬性取得計算結果。
        Console.WriteLine();
        Console.WriteLine("========== 書籍折扣 ==========");
        Console.WriteLine("九折後價格：" + book1.CalculateDiscount(0.9).ToString("F0"));

        // 四、測試價格驗證。
        book1.Price = -100;
        Console.WriteLine();
        Console.WriteLine("========== 價格驗證 ==========");
        Console.WriteLine("設定負數後的價格：" + book1.Price.ToString("F0"));

        // 五、建立另一個物件，資料彼此獨立。
        Book book2 = new Book("Java 程式設計", "陳小華", 520);

        Console.WriteLine();
        Console.WriteLine("========== 第二本書 ==========");
        book2.ShowInfo();
    }
}

class Book
{
    // private 欄位只能在 Book 類別內直接存取。
    private string title;
    private string author;
    private double price;

    // 建構子名稱與類別名稱相同，建立物件時會執行。
    public Book(string title, string author, double price)
    {
        this.title = title;
        this.author = author;
        this.Price = price;
    }

    // get 用來讀取屬性，set 用來設定屬性。
    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public string Author
    {
        get { return author; }
        set { author = value; }
    }

    // 設定價格時先驗證，避免負數。
    public double Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
            {
                price = value;
            }
        }
    }

    // 只提供 get 的屬性，外部只能讀取，不能直接設定。
    public string BookDescription
    {
        get { return Title + "，作者：" + Author; }
    }

    public void ShowInfo()
    {
        Console.WriteLine("書名：" + Title);
        Console.WriteLine("作者：" + Author);
        Console.WriteLine("價格：" + Price.ToString("F0"));
        Console.WriteLine("書籍資訊：" + BookDescription);
    }

    public double CalculateDiscount(double discount)
    {
        return Price * discount;
    }
}