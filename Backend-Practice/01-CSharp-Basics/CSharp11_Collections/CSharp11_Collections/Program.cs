using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("C# 程式設計練習");
        Console.WriteLine("第十一章：集合");
        Console.WriteLine("================================");

        // 一、建立 List<T> 集合
        // using System.Collections.Generic; 提供 List<T> 等泛型集合。
        // List<string> 表示集合中的元素都是 string。
        // 與陣列不同，List<T> 可以動態新增或刪除元素。

        List<string> books = new List<string>
        {
            "C# 入門教學",
            "Java 程式設計",
            "SQL Server 資料庫"
        };

        Console.WriteLine();
        Console.WriteLine("========== 建立集合 ==========");
        Console.WriteLine("書籍數量：" + books.Count);
        Console.WriteLine("第一本書：" + books[0]);

        // 二、Add() 新增單一元素
        // Add() 將一筆資料加到集合尾端。

        books.Add("HTML 與 CSS 基礎");

        Console.WriteLine();
        Console.WriteLine("========== 新增元素 ==========");
        Console.WriteLine("新增後的書籍數量：" + books.Count);

        // AddRange() 一次加入多筆資料。
        books.AddRange(new List<string>
        {
            "JavaScript 入門",
            "ASP.NET Core 實戰"
        });

        Console.WriteLine("批次新增後的書籍數量：" + books.Count);

        // 三、使用 for 與 foreach 讀取集合
        Console.WriteLine();
        Console.WriteLine("========== 使用 for 列出書籍 ==========");

        for (int i = 0; i < books.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + books[i]);
        }

        Console.WriteLine();
        Console.WriteLine("========== 使用 foreach 列出書籍 ==========");

        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        // 四、搜尋集合中的元素
        // Contains() 判斷是否包含指定元素。
        // IndexOf() 回傳元素第一次出現的索引，找不到時回傳 -1。

        Console.WriteLine();
        Console.WriteLine("========== 搜尋書籍 ==========");

        string searchTitle = "SQL Server 資料庫";

        Console.WriteLine("是否包含指定書籍：" + books.Contains(searchTitle));
        Console.WriteLine("指定書籍的索引：" + books.IndexOf(searchTitle));
        Console.WriteLine("是否包含不存在的書籍：" + books.Contains("Python 入門"));

        // 五、修改指定位置的元素
        // 可以透過索引直接修改元素。

        books[0] = "C# 程式設計入門";

        Console.WriteLine();
        Console.WriteLine("========== 修改元素 ==========");
        Console.WriteLine("修改後的第一本書：" + books[0]);

        // 六、Remove() 與 RemoveAt() 刪除元素
        // Remove() 依元素內容刪除第一個符合的項目。
        // RemoveAt() 依索引刪除項目。

        bool removed = books.Remove("HTML 與 CSS 基礎");

        Console.WriteLine();
        Console.WriteLine("========== 刪除元素 ==========");
        Console.WriteLine("是否成功刪除 HTML 與 CSS 基礎：" + removed);

        books.RemoveAt(0);
        Console.WriteLine("刪除索引 0 的元素後，第一本書：" + books[0]);
        Console.WriteLine("目前書籍數量：" + books.Count);

        // 七、Sort() 排序與 Reverse() 反轉
        // Sort() 依字串的排序規則排序。
        // Reverse() 將目前順序反轉，不代表依字母重新排序。

        Console.WriteLine();
        Console.WriteLine("========== 排序與反轉 ==========");

        books.Sort();

        Console.WriteLine("排序後：");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        books.Reverse();

        Console.WriteLine("反轉後：");
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }

        // 八、Clear() 清空集合
        // Clear() 移除所有元素，Count 會變成 0。
        // 集合物件仍然存在，可以繼續加入新元素。

        Console.WriteLine();
        Console.WriteLine("========== 清空集合 ==========");

        books.Clear();

        Console.WriteLine("清空後的書籍數量：" + books.Count);

        books.Add("圖書管理系統開發");
        Console.WriteLine("重新新增後的第一本書：" + books[0]);
        Console.WriteLine("重新新增後的書籍數量：" + books.Count);

        // 九、List<T> 與陣列的差異
        // 陣列使用 Length 取得元素數量，長度建立後固定。
        // List<T> 使用 Count 取得元素數量，元素數量可以動態改變。

        int[] numberArray = { 10, 20, 30 };
        List<int> numberList = new List<int> { 10, 20, 30 };

        numberList.Add(40);

        Console.WriteLine();
        Console.WriteLine("========== 陣列與 List 比較 ==========");
        Console.WriteLine("陣列元素數量：" + numberArray.Length);
        Console.WriteLine("List 元素數量：" + numberList.Count);
    }
}