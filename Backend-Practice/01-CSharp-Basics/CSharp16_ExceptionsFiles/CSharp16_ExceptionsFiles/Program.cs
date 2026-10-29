using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("C# 程式設計練習");
        Console.WriteLine("第十六章：例外處理與檔案操作");
        Console.WriteLine("================================");

        // 一、使用 try-catch 處理例外。
        Console.WriteLine();
        Console.WriteLine("========== 例外處理 ==========");

        try
        {
            int numerator = 10;
            int denominator = 0;

            if (denominator == 0)
            {
                throw new DivideByZeroException("除數不可為零");
            }

            Console.WriteLine("計算結果：" + (numerator / denominator));
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("發生錯誤：" + ex.Message);
        }
        finally
        {
            Console.WriteLine("除法操作結束");
        }

        // 二、處理使用者輸入的數字。
        Console.WriteLine();
        Console.WriteLine("========== 數字轉換 ==========");

        string input = "abc";

        try
        {
            int number = int.Parse(input);
            Console.WriteLine("轉換結果：" + number);
        }
        catch (FormatException)
        {
            Console.WriteLine("輸入內容不是有效的整數");
        }

        // 三、建立檔案路徑。
        // 使用目前程式的工作目錄建立練習檔案。

        string filePath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "books.txt"
        );

        // 四、寫入文字檔。
        Console.WriteLine();
        Console.WriteLine("========== 寫入檔案 ==========");

        try
        {
            string[] books =
            {
                "C# 入門教學",
                "Java 程式設計",
                "SQL Server 資料庫"
            };

            File.WriteAllLines(filePath, books);
            Console.WriteLine("檔案寫入成功");
            Console.WriteLine("檔案位置：" + filePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine("檔案寫入失敗：" + ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("沒有檔案存取權限：" + ex.Message);
        }

        // 五、讀取文字檔。
        Console.WriteLine();
        Console.WriteLine("========== 讀取檔案 ==========");

        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("找不到指定的檔案");
        }
        catch (IOException ex)
        {
            Console.WriteLine("檔案讀取失敗：" + ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine("沒有檔案讀取權限：" + ex.Message);
        }

        // 六、檢查檔案是否存在。
        Console.WriteLine();
        Console.WriteLine("========== 檔案檢查 ==========");
        Console.WriteLine("檔案是否存在：" + File.Exists(filePath));

        // 七、示範 throw 主動拋出例外。
        Console.WriteLine();
        Console.WriteLine("========== 自訂驗證 ==========");

        try
        {
            CheckPrice(-100);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("價格驗證失敗：" + ex.Message);
        }
    }

    static void CheckPrice(double price)
    {
        if (price < 0)
        {
            throw new ArgumentException("價格不可小於零");
        }

        Console.WriteLine("價格有效：" + price);
    }
}