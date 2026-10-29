using System;

Console.WriteLine("================================");
Console.WriteLine("C# 程式設計練習");
Console.WriteLine("第六章：迴圈");
Console.WriteLine("================================");

// 一、for：適合已知執行次數的迴圈
// int i = 1：設定起始值
// i <= 5：條件成立時繼續執行
// i++：每次執行後，讓 i 增加 1

Console.WriteLine("========== for 迴圈 ==========");

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine("第 " + i + " 次執行");
}

// 二、while：條件成立時持續執行
// 必須適時修改條件使用的變數，避免無限迴圈

Console.WriteLine();
Console.WriteLine("========== while 迴圈 ==========");

int count = 1;

while (count <= 3)
{
    Console.WriteLine("目前次數：" + count);
    count++;
}

// 三、break：立即結束目前的迴圈
Console.WriteLine();
Console.WriteLine("========== break ==========");

for (int i = 1; i <= 5; i++)
{
    if (i == 4)
    {
        break;
    }

    Console.WriteLine("目前數字：" + i);
}

// 四、continue：跳過本次迴圈剩餘的程式碼，進入下一次迴圈
Console.WriteLine();
Console.WriteLine("========== continue ==========");

for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        continue;
    }

    Console.WriteLine("目前數字：" + i);
}

// 五、使用迴圈計算總和
Console.WriteLine();
Console.WriteLine("========== 計算總和 ==========");

int total = 0;

for (int i = 1; i <= 10; i++)
{
    total += i;
}

Console.WriteLine("1 到 10 的總和：" + total);

// 六、使用巢狀迴圈：一個迴圈放在另一個迴圈內
Console.WriteLine();
Console.WriteLine("========== 巢狀迴圈 ==========");

for (int row = 1; row <= 3; row++)
{
    for (int column = 1; column <= 3; column++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}