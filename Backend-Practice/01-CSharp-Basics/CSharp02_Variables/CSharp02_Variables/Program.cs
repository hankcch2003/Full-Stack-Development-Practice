using System;

Console.WriteLine("================================");
Console.WriteLine("C# 程式設計練習");
Console.WriteLine("第二章：變數與資料型別");
Console.WriteLine("================================");

// string 用來儲存文字
string name = "Amy";
string job = "Software Developer";

// int 用來儲存整數
int age = 25;

// double 用來儲存小數
double height = 165.5;
double weight = 52.8;

// bool 用來儲存 true 或 false
bool isStudent = true;

Console.WriteLine();
Console.WriteLine("========== 原始個人資料 ==========");
Console.WriteLine("姓名：" + name);
Console.WriteLine("年齡：" + age);
Console.WriteLine("身高：" + height + " 公分");
Console.WriteLine("體重：" + weight + " 公斤");
Console.WriteLine("職業：" + job);
Console.WriteLine("是否為學生：" + isStudent);

// 將變數重新指定為新的值
name = "Tom";
age = 30;
height = 175.2;
weight = 68.5;
job = "C# Developer";
isStudent = false;

Console.WriteLine();
Console.WriteLine("========== 修改後的個人資料 ==========");
Console.WriteLine("姓名：" + name);
Console.WriteLine("年齡：" + age);
Console.WriteLine("身高：" + height + " 公分");
Console.WriteLine("體重：" + weight + " 公斤");
Console.WriteLine("職業：" + job);
Console.WriteLine("是否為學生：" + isStudent);