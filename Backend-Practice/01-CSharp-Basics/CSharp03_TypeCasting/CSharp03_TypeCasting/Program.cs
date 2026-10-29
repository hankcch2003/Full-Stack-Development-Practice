using System;

Console.WriteLine("================================");
Console.WriteLine("C# 程式設計練習");
Console.WriteLine("第三章：型別轉換與格式化輸出");
Console.WriteLine("================================");

// 將 int 隱含轉換成 double
int score = 85;
double decimalScore = score;

Console.WriteLine("原始整數成績：" + score);
Console.WriteLine("轉換後的小數成績：" + decimalScore);

// 將 double 明確轉換成 int，小數部分會被截掉
double price = 99.8;
int integerPrice = (int)price;

Console.WriteLine();
Console.WriteLine("原始商品價格：" + price);
Console.WriteLine("轉換後的整數價格：" + integerPrice);

// 使用 F2 格式固定顯示兩位小數
Console.WriteLine("格式化後的商品價格：" + price.ToString("F2"));

// 將數字字串轉換成 int
string ageText = "25";
int age = Convert.ToInt32(ageText);

Console.WriteLine();
Console.WriteLine("原始年齡字串：" + ageText);
Console.WriteLine("轉換後的年齡整數：" + age);

// 將數字字串轉換成 double
string heightText = "170.5";
double height = Convert.ToDouble(heightText);

Console.WriteLine("原始身高字串：" + heightText);
Console.WriteLine("轉換後的身高數值：" + height);

// 將數字轉換成字串
int quantity = 3;
string quantityText = quantity.ToString();

Console.WriteLine();
Console.WriteLine("商品數量：" + quantity);
Console.WriteLine("商品數量字串：" + quantityText);

// 使用 $ 字串插值，直接將變數放進字串
Console.WriteLine();
Console.WriteLine($"商品數量：{quantity}");

// 使用 F2 格式，在字串插值中固定顯示兩位小數
Console.WriteLine($"商品價格：{price:F2}");