using System;

Console.WriteLine("================================");
Console.WriteLine("C# 程式設計練習");
Console.WriteLine("第四章：運算子與數學運算");
Console.WriteLine("================================");

// 一、算術運算子：用於數字計算
// + 加法、- 減法、* 乘法、/ 除法、% 取餘數

int a = 10;
int b = 3;

Console.WriteLine("========== 算術運算 ==========");
Console.WriteLine("加法：" + (a + b));
Console.WriteLine("減法：" + (a - b));
Console.WriteLine("乘法：" + (a * b));

// 兩個 int 相除會執行整數除法，小數部分會被捨去
Console.WriteLine("整數除法：" + (a / b));

// % 取得除法的餘數
Console.WriteLine("取餘數：" + (a % b));

// 將 a 轉換成 double，讓除法可以保留小數
double decimalResult = (double)a / b;
Console.WriteLine("小數除法：" + decimalResult);

// 二、指定運算子：計算後將結果存回原變數
// += 等同於 quantity = quantity + 5
// -= 等同於 quantity = quantity - 3
// *= 等同於 quantity = quantity * 2
// /= 等同於 quantity = quantity / 4

int quantity = 10;

Console.WriteLine();
Console.WriteLine("========== 指定運算 ==========");
Console.WriteLine("原始數量：" + quantity);

quantity += 5;
Console.WriteLine("增加 5：" + quantity);

quantity -= 3;
Console.WriteLine("減少 3：" + quantity);

quantity *= 2;
Console.WriteLine("乘以 2：" + quantity);

quantity /= 4;
Console.WriteLine("除以 4：" + quantity);

// 三、比較運算子：比較兩個值，結果為 bool
// == 相等、!= 不相等
// > 大於、< 小於
// >= 大於或等於、<= 小於或等於

int score = 85;

Console.WriteLine();
Console.WriteLine("========== 比較運算 ==========");
Console.WriteLine("成績是否等於 85：" + (score == 85));
Console.WriteLine("成績是否不等於 60：" + (score != 60));
Console.WriteLine("成績是否大於 60：" + (score > 60));
Console.WriteLine("成績是否小於 60：" + (score < 60));
Console.WriteLine("成績是否至少 60：" + (score >= 60));
Console.WriteLine("成績是否至多 60：" + (score <= 60));

// 四、邏輯運算子：組合或反轉條件
// && AND：兩邊條件都成立，結果才是 true
// || OR：至少一邊條件成立，結果就是 true
// ! NOT：反轉布林值，true 變 false，false 變 true

bool hasAccount = true;
bool hasPassword = false;

Console.WriteLine();
Console.WriteLine("========== 邏輯運算 ==========");
Console.WriteLine("帳號與密碼都已提供：" + (hasAccount && hasPassword));
Console.WriteLine("已提供帳號或密碼：" + (hasAccount || hasPassword));
Console.WriteLine("尚未提供帳號：" + (!hasAccount));

// 五、Math 數學方法：執行常見數學計算
// Math.Abs()：取得絕對值
// Math.Round()：依指定的捨入規則取近似值
// Math.Ceiling()：無條件進位
// Math.Floor()：無條件捨去
// Math.Max()：取得較大值
// Math.Min()：取得較小值

Console.WriteLine();
Console.WriteLine("========== Math 數學方法 ==========");
Console.WriteLine("絕對值：" + Math.Abs(-10));

// Math.Round() 預設採用中點取偶數規則，例如 2.5 會得到 2
Console.WriteLine("四捨五入：" + Math.Round(3.6));
Console.WriteLine("無條件進位：" + Math.Ceiling(3.2));
Console.WriteLine("無條件捨去：" + Math.Floor(3.8));
Console.WriteLine("較大值：" + Math.Max(10, 20));
Console.WriteLine("較小值：" + Math.Min(10, 20));