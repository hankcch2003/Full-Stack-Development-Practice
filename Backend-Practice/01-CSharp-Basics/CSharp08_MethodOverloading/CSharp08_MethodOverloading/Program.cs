using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("C# 程式設計練習");
        Console.WriteLine("第八章：方法多載");
        Console.WriteLine("================================");

        // 一、相同方法名稱，不同參數數量
        Console.WriteLine("========== 參數數量不同 ==========");
        Console.WriteLine("兩個數字相加：" + Add(10, 20));
        Console.WriteLine("三個數字相加：" + Add(10, 20, 30));

        // 二、相同方法名稱，不同參數型別
        Console.WriteLine();
        Console.WriteLine("========== 參數型別不同 ==========");
        Console.WriteLine("整數相乘：" + Multiply(3, 4));
        Console.WriteLine("小數相乘：" + Multiply(2.5, 4.0));

        // 三、相同方法名稱，不同參數組合
        Console.WriteLine();
        Console.WriteLine("========== 圖書資料格式化 ==========");
        Console.WriteLine(FormatBook("C# 入門教學"));
        Console.WriteLine(FormatBook("C# 入門教學", "王小明"));

        // 四、使用多載計算不同形狀的面積
        Console.WriteLine();
        Console.WriteLine("========== 面積計算 ==========");
        Console.WriteLine("長方形面積：" + CalculateArea(5.0, 3.0));
        Console.WriteLine("圓形面積：" + CalculateArea(2.0).ToString("F2"));
    }

    // 兩個整數相加
    static int Add(int a, int b)
    {
        return a + b;
    }

    // 三個整數相加：參數數量不同
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // 兩個整數相乘
    static int Multiply(int a, int b)
    {
        return a * b;
    }

    // 兩個小數相乘：參數型別不同
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // 只提供書名
    static string FormatBook(string title)
    {
        return "書名：" + title;
    }

    // 同時提供書名與作者
    static string FormatBook(string title, string author)
    {
        return "書名：" + title + "，作者：" + author;
    }

    // 長方形面積：需要長與寬
    static double CalculateArea(double width, double height)
    {
        return width * height;
    }

    // 圓形面積：只需要半徑
    static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}