using System;

Console.WriteLine("================================");
Console.WriteLine("C# 程式設計練習");
Console.WriteLine("第五章：條件判斷");
Console.WriteLine("================================");

// 一、if、else if、else：依條件決定執行哪一段程式碼
// if：條件成立時執行
// else if：前面的條件不成立時，再判斷其他條件
// else：前面的條件都不成立時執行

int score = 85;

Console.WriteLine("========== 成績判斷 ==========");
Console.WriteLine("考試成績：" + score);

if (score >= 90)
{
    Console.WriteLine("成績等級：A");
}
else if (score >= 80)
{
    Console.WriteLine("成績等級：B");
}
else if (score >= 70)
{
    Console.WriteLine("成績等級：C");
}
else if (score >= 60)
{
    Console.WriteLine("成績等級：D");
}
else
{
    Console.WriteLine("成績等級：F");
}

// 二、&&：兩個條件都成立時，結果才是 true
int age = 22;
bool hasTicket = true;

Console.WriteLine();
Console.WriteLine("========== 入場資格判斷 ==========");
Console.WriteLine("年齡：" + age);
Console.WriteLine("是否持有門票：" + hasTicket);

if (age >= 18 && hasTicket)
{
    Console.WriteLine("符合入場資格");
}
else
{
    Console.WriteLine("不符合入場資格");
}

// 三、||：至少一個條件成立，結果就是 true
bool isStudent = false;
bool isSenior = true;

Console.WriteLine();
Console.WriteLine("========== 優惠資格判斷 ==========");

if (isStudent || isSenior)
{
    Console.WriteLine("符合優惠資格");
}
else
{
    Console.WriteLine("不符合優惠資格");
}

// 四、switch：依照指定的值選擇執行分支
// case：定義各個選項
// break：結束目前分支
// default：沒有符合的選項時執行

Console.WriteLine();
Console.WriteLine("========== 功能選單 ==========");
Console.WriteLine("1. 查詢圖書");
Console.WriteLine("2. 新增圖書");
Console.WriteLine("3. 刪除圖書");
Console.Write("請輸入功能選項：");

// Console.ReadLine() 讀取使用者輸入的文字
string? input = Console.ReadLine();

// int.TryParse() 嘗試將字串轉換成整數
// 轉換成功時回傳 true，並將結果存入 menuChoice
// 轉換失敗時回傳 false，不會因格式錯誤而直接拋出轉換例外

if (int.TryParse(input, out int menuChoice))
{
    Console.WriteLine("目前選擇：" + menuChoice);

    switch (menuChoice)
    {
        case 1:
            Console.WriteLine("執行查詢圖書功能");
            break;

        case 2:
            Console.WriteLine("執行新增圖書功能");
            break;

        case 3:
            Console.WriteLine("執行刪除圖書功能");
            break;

        default:
            Console.WriteLine("無效的功能選項");
            break;
    }
}
else
{
    Console.WriteLine("輸入錯誤，請輸入數字選項");
}