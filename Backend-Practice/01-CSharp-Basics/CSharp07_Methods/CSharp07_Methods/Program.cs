using System;

Console.WriteLine("================================");
Console.WriteLine("C# 程式設計練習");
Console.WriteLine("第七章：方法");
Console.WriteLine("================================");

// 一、定義沒有參數、沒有回傳值的方法
// void 表示方法不會回傳結果

static void ShowWelcome()
{
    Console.WriteLine("歡迎使用圖書管理系統！");
}

// 呼叫方法時，使用方法名稱加上括號
ShowWelcome();

// 二、定義具有參數的方法
// string name 是方法的參數，用來接收呼叫時傳入的值

static void ShowMember(string name)
{
    Console.WriteLine("會員姓名：" + name);
}

ShowMember("Amy");
ShowMember("Tom");

// 三、使用多個參數
// 每個參數都需要指定資料型別

static void ShowBook(string title, string author)
{
    Console.WriteLine("書名：" + title);
    Console.WriteLine("作者：" + author);
}

Console.WriteLine();
Console.WriteLine("========== 圖書資料 ==========");
ShowBook("C# 入門教學", "王小明");

// 四、使用 return 回傳計算結果
// int 表示方法回傳的結果必須是整數

static int Add(int a, int b)
{
    return a + b;
}

Console.WriteLine();
Console.WriteLine("========== 加法計算 ==========");

int sum = Add(10, 20);
Console.WriteLine("10 + 20 = " + sum);

// 五、使用 double 回傳小數結果
static double CalculateAverage(double score1, double score2)
{
    return (score1 + score2) / 2;
}

double average = CalculateAverage(80, 90);
Console.WriteLine("平均成績：" + average);

// 六、使用 bool 回傳判斷結果
// bool 方法只能回傳 true 或 false

static bool IsPassing(int score)
{
    return score >= 60;
}

Console.WriteLine();
Console.WriteLine("========== 成績判斷 ==========");

int score = 75;
Console.WriteLine("考試成績：" + score);
Console.WriteLine("是否及格：" + IsPassing(score));

// 七、方法可以呼叫其他方法
static int CalculateTotalPrice(int price, int quantity)
{
    return Multiply(price, quantity);
}

static int Multiply(int a, int b)
{
    return a * b;
}

Console.WriteLine();
Console.WriteLine("========== 商品金額 ==========");

int totalPrice = CalculateTotalPrice(150, 3);
Console.WriteLine("單價：150");
Console.WriteLine("數量：3");
Console.WriteLine("總金額：" + totalPrice);