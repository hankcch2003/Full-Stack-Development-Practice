using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("C# 程式設計練習");
        Console.WriteLine("第十章：字串");
        Console.WriteLine("================================");

        // 一、建立字串與取得長度
        // string 用來儲存文字。
        // Length 取得字串長度，包含空白字元。

        string title = "C# Programming";
        string author = "Amy Chen";

        Console.WriteLine();
        Console.WriteLine("========== 字串基本操作 ==========");
        Console.WriteLine("書名：" + title);
        Console.WriteLine("作者：" + author);
        Console.WriteLine("書名長度：" + title.Length);
        Console.WriteLine("作者長度：" + author.Length);

        // 二、字串大小寫轉換
        // ToUpper() 將英文字母轉成大寫。
        // ToLower() 將英文字母轉成小寫。
        // 這些方法會回傳新字串，不會直接修改原字串。

        Console.WriteLine();
        Console.WriteLine("========== 大小寫轉換 ==========");
        Console.WriteLine("大寫：" + title.ToUpper());
        Console.WriteLine("小寫：" + title.ToLower());

        // 三、移除字串前後的空白
        // Trim() 移除字串開頭與結尾的空白。
        // 不會移除字串中間的空白。

        string input = "   C# 入門教學   ";

        Console.WriteLine();
        Console.WriteLine("========== 移除空白 ==========");
        Console.WriteLine("原始文字：" + input);
        Console.WriteLine("Trim 後：" + input.Trim());

        // 四、搜尋字串內容
        // Contains() 判斷是否包含指定文字。
        // StartsWith() 判斷是否以指定文字開頭。
        // EndsWith() 判斷是否以指定文字結尾。
        // IndexOf() 回傳第一次出現的位置，找不到時回傳 -1。

        Console.WriteLine();
        Console.WriteLine("========== 搜尋字串 ==========");
        Console.WriteLine("是否包含 Programming：" + title.Contains("Programming"));
        Console.WriteLine("是否以 C# 開頭：" + title.StartsWith("C#"));
        Console.WriteLine("是否以 ing 結尾：" + title.EndsWith("ing"));
        Console.WriteLine("Programming 的起始索引：" + title.IndexOf("Programming"));
        Console.WriteLine("Java 的起始索引：" + title.IndexOf("Java"));

        // 五、擷取部分字串
        // Substring(startIndex, length)
        // 第一個參數是起始索引，第二個參數是擷取長度。
        // 索引從 0 開始。

        Console.WriteLine();
        Console.WriteLine("========== 擷取字串 ==========");
        Console.WriteLine("前兩個字元：" + title.Substring(0, 2));
        Console.WriteLine("從索引 3 開始：" + title.Substring(3));

        // 六、取代字串內容
        // Replace() 將符合的內容替換成指定文字。
        // 原始字串不會被直接修改。

        Console.WriteLine();
        Console.WriteLine("========== 取代文字 ==========");
        string newTitle = title.Replace("Programming", "Development");
        Console.WriteLine("原始書名：" + title);
        Console.WriteLine("修改後書名：" + newTitle);

        // 七、分割字串
        // Split() 依指定分隔符號切割字串，並回傳字串陣列。

        string csvData = "101,C# 入門教學,Amy Chen";

        Console.WriteLine();
        Console.WriteLine("========== 分割字串 ==========");

        string[] bookData = csvData.Split(',');

        Console.WriteLine("書籍編號：" + bookData[0]);
        Console.WriteLine("書名：" + bookData[1]);
        Console.WriteLine("作者：" + bookData[2]);

        // 八、合併字串
        // string.Join() 使用指定的分隔符號合併多個字串。

        string[] tags = { "C#", "Programming", "Beginner" };

        Console.WriteLine();
        Console.WriteLine("========== 合併字串 ==========");
        Console.WriteLine(string.Join("、", tags));

        // 九、字串插值
        // 在字串前加上 $，即可使用 {變數} 插入資料。
        // 適合組合文字與變數，通常比多次使用 + 更容易閱讀。

        Console.WriteLine();
        Console.WriteLine("========== 字串插值 ==========");
        int price = 450;
        int quantity = 2;

        Console.WriteLine($"書名：{title}");
        Console.WriteLine($"單價：{price} 元");
        Console.WriteLine($"數量：{quantity}");
        Console.WriteLine($"總金額：{price * quantity} 元");

        // 十、比較字串
        // == 比較字串內容是否相同。
        // StringComparison.OrdinalIgnoreCase 可忽略英文字母大小寫。

        Console.WriteLine();
        Console.WriteLine("========== 字串比較 ==========");

        string inputTitle = "c# programming";

        Console.WriteLine("直接比較：" + (title == inputTitle));
        Console.WriteLine(
            "忽略大小寫比較：" +
            title.Equals(inputTitle, StringComparison.OrdinalIgnoreCase)
        );

        // 十一、檢查空字串與 null
        // string.Empty 代表長度為 0 的字串。
        // null 表示沒有字串物件。
        // IsNullOrEmpty() 可檢查 null 或空字串。
        // IsNullOrWhiteSpace() 還會檢查只有空白字元的字串。

        Console.WriteLine();
        Console.WriteLine("========== 字串空值檢查 ==========");

        string emptyText = "";
        string spaceText = "   ";

        Console.WriteLine("空字串：" + string.IsNullOrEmpty(emptyText));
        Console.WriteLine("空白字串：" + string.IsNullOrWhiteSpace(spaceText));
        Console.WriteLine("空字串常數：" + (emptyText == string.Empty));
    }
}