using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("C# 程式設計練習");
        Console.WriteLine("第九章：陣列");
        Console.WriteLine("================================");

        // 一、一維陣列（Single-Dimensional Array）
        // [] 表示一維陣列型別。
        // string[] 表示可以儲存多個字串的陣列。
        // 陣列的索引從 0 開始，而不是從 1 開始。

        string[] bookTitles =
        {
            "C# 入門教學",
            "Java 程式設計",
            "SQL Server 資料庫",
            "HTML 與 CSS 基礎"
        };

        Console.WriteLine();
        Console.WriteLine("========== 一維陣列 ==========");

        // 變數名稱後面的 [0] 表示存取索引 0 的元素。
        Console.WriteLine("第一本書：" + bookTitles[0]);
        Console.WriteLine("第二本書：" + bookTitles[1]);

        // Length 取得陣列的元素總數。
        Console.WriteLine("書籍數量：" + bookTitles.Length);

        // 可以修改既有元素，但不能直接改變陣列長度。
        bookTitles[1] = "Java OCP 考試準備";
        Console.WriteLine("修改後的第二本書：" + bookTitles[1]);

        // 二、使用 for 迴圈存取一維陣列
        // for 可以透過索引控制讀取的位置。
        // i < bookTitles.Length 可避免讀取超出範圍的元素。

        Console.WriteLine();
        Console.WriteLine("========== 使用 for 列出書籍 ==========");

        for (int i = 0; i < bookTitles.Length; i++)
        {
            Console.WriteLine((i + 1) + ". " + bookTitles[i]);
        }

        // 三、使用 foreach 逐筆讀取一維陣列
        // foreach 會依序取得每一個元素，不必自行管理索引。

        Console.WriteLine();
        Console.WriteLine("========== 使用 foreach 列出書籍 ==========");

        foreach (string title in bookTitles)
        {
            Console.WriteLine(title);
        }

        // 四、搜尋陣列中的資料
        // found 用來記錄是否找到指定的書名。

        Console.WriteLine();
        Console.WriteLine("========== 搜尋書籍 ==========");

        string searchTitle = "SQL Server 資料庫";
        bool found = false;

        for (int i = 0; i < bookTitles.Length; i++)
        {
            if (bookTitles[i] == searchTitle)
            {
                Console.WriteLine("找到書籍，索引：" + i);
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine("找不到書籍");
        }

        // 五、數值陣列：加總、平均、最大值與最小值
        int[] scores = { 85, 92, 78, 90, 88 };

        int total = 0;

        // 先使用第一個元素作為初始最大值與最小值。
        int maxScore = scores[0];
        int minScore = scores[0];

        Console.WriteLine();
        Console.WriteLine("========== 成績統計 ==========");

        foreach (int score in scores)
        {
            total += score;

            if (score > maxScore)
            {
                maxScore = score;
            }

            if (score < minScore)
            {
                minScore = score;
            }
        }

        // 將 total 轉成 double，避免整數除法捨去小數部分。
        double average = (double)total / scores.Length;

        Console.WriteLine("成績總和：" + total);
        Console.WriteLine("平均成績：" + average.ToString("F2"));
        Console.WriteLine("最高成績：" + maxScore);
        Console.WriteLine("最低成績：" + minScore);

        // 六、二維陣列（Multidimensional Array）
        // [,] 表示二維陣列。
        // int[,] 表示元素都是 int 的二維陣列。
        // 使用 [列索引, 欄索引] 存取元素。
        // 例如 stock[0, 1] 表示第 0 列、第 1 欄。

        int[,] stock =
        {
            { 10, 8 },
            { 5, 12 }
        };

        Console.WriteLine();
        Console.WriteLine("========== 二維陣列 ==========");

        // GetLength(0) 取得列數；GetLength(1) 取得欄數。
        Console.WriteLine("列數：" + stock.GetLength(0));
        Console.WriteLine("欄數：" + stock.GetLength(1));

        Console.WriteLine("第一列第一欄：" + stock[0, 0]);
        Console.WriteLine("第一列第二欄：" + stock[0, 1]);

        // 二維陣列可以修改指定列與欄的元素。
        stock[0, 0] = 15;
        Console.WriteLine("修改後的第一列第一欄：" + stock[0, 0]);

        // 使用巢狀 for 迴圈列出所有列與欄。
        // 外層控制列，內層控制欄。

        Console.WriteLine("庫存表：");

        for (int row = 0; row < stock.GetLength(0); row++)
        {
            for (int col = 0; col < stock.GetLength(1); col++)
            {
                Console.Write(stock[row, col] + "\t");
            }

            Console.WriteLine();
        }

        // 七、交錯陣列（Jagged Array）
        // [][] 表示陣列中的每個元素本身也是一個陣列。
        // int[][] 表示元素為 int 陣列的陣列。
        // 每一個子陣列可以有不同長度。
        // scoresByClass[0] 代表第 0 個子陣列。
        // scoresByClass[0][1] 代表第 0 個子陣列中的第 1 個元素。

        int[][] scoresByClass =
        {
            new int[] { 85, 90, 88 },
            new int[] { 76, 92 },
            new int[] { 95, 89, 91, 87 }
        };

        Console.WriteLine();
        Console.WriteLine("========== 交錯陣列 ==========");

        for (int row = 0; row < scoresByClass.Length; row++)
        {
            Console.Write("第 " + (row + 1) + " 組成績：");

            // 使用 scoresByClass[row].Length 取得該子陣列的長度。
            // 不同子陣列的長度可以不同。

            for (int col = 0; col < scoresByClass[row].Length; col++)
            {
                Console.Write(scoresByClass[row][col] + " ");
            }

            Console.WriteLine();
        }

        // 八、建立指定長度的陣列
        // new int[3] 建立長度為 3 的整數陣列。
        // int 陣列中的元素預設值為 0。

        int[] quantities = new int[3];

        quantities[0] = 10;
        quantities[1] = 20;
        quantities[2] = 30;

        Console.WriteLine();
        Console.WriteLine("========== 指定長度的陣列 ==========");

        for (int i = 0; i < quantities.Length; i++)
        {
            Console.WriteLine("數量 " + (i + 1) + "：" + quantities[i]);
        }

        // 九、陣列長度與索引範圍
        // 注意：長度為 4 的陣列，合法索引是 0、1、2、3。
        // 若存取 bookTitles[4]，執行時會發生
        // IndexOutOfRangeException（索引超出範圍例外）。
        // 一維陣列：bookTitles[0]
        // 二維陣列：stock[0, 1]
        // 交錯陣列：scoresByClass[0][1]
        // 陣列建立後長度固定；若需要動態新增或刪除元素，
        // 後續可以使用 List<T> 集合。

        Console.WriteLine();
        Console.WriteLine("========== 陣列索引 ==========");

        Console.WriteLine("bookTitles 的長度：" + bookTitles.Length);
        Console.WriteLine("第一個索引：0");
        Console.WriteLine("最後一個索引：" + (bookTitles.Length - 1));
    }
}