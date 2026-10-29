using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("C# 程式設計練習");
        Console.WriteLine("第十七章：JSON 與非同步");
        Console.WriteLine("================================");

        // 一、建立書籍物件
        Book book = new Book
        {
            Id = 1,
            Title = "C# 入門教學",
            Author = "王小明",
            Price = 450
        };

        Console.WriteLine();
        Console.WriteLine("========== 原始物件 ==========");
        Console.WriteLine("書名：" + book.Title);
        Console.WriteLine("作者：" + book.Author);
        Console.WriteLine("價格：" + book.Price);

        // 二、JSON 序列化：將物件轉換成 JSON 字串
        string json = JsonSerializer.Serialize(
            book,
            new JsonSerializerOptions
            {
                WriteIndented = true
            }
        );

        Console.WriteLine();
        Console.WriteLine("========== JSON 序列化 ==========");
        Console.WriteLine(json);

        // 三、JSON 反序列化：將 JSON 字串還原成物件
        Book? restoredBook = JsonSerializer.Deserialize<Book>(json);

        Console.WriteLine();
        Console.WriteLine("========== JSON 反序列化 ==========");

        if (restoredBook != null)
        {
            Console.WriteLine("書籍編號：" + restoredBook.Id);
            Console.WriteLine("書名：" + restoredBook.Title);
            Console.WriteLine("作者：" + restoredBook.Author);
            Console.WriteLine("價格：" + restoredBook.Price);
        }

        // 四、建立多筆書籍資料
        List<Book> books = new List<Book>
        {
            new Book
            {
                Id = 1,
                Title = "C# 入門教學",
                Author = "王小明",
                Price = 450
            },
            new Book
            {
                Id = 2,
                Title = "Java 程式設計",
                Author = "陳小華",
                Price = 520
            }
        };

        // 將整個集合轉換成 JSON 陣列
        string booksJson = JsonSerializer.Serialize(books);

        Console.WriteLine();
        Console.WriteLine("========== 多筆書籍 JSON ==========");
        Console.WriteLine(booksJson);

        // 五、非同步寫入 JSON 檔案
        string filePath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "books.json"
        );

        Console.WriteLine();
        Console.WriteLine("========== 非同步檔案操作 ==========");

        await File.WriteAllTextAsync(filePath, booksJson);
        Console.WriteLine("JSON 檔案寫入完成");

        // 六、非同步讀取 JSON 檔案
        string loadedJson = await File.ReadAllTextAsync(filePath);
        Console.WriteLine("JSON 檔案讀取完成");

        // 將讀取到的 JSON 還原成書籍集合
        List<Book>? loadedBooks =
            JsonSerializer.Deserialize<List<Book>>(loadedJson);

        if (loadedBooks != null)
        {
            Console.WriteLine("讀取的書籍數量：" + loadedBooks.Count);

            foreach (Book item in loadedBooks)
            {
                Console.WriteLine(item.Id + ". " + item.Title);
            }
        }

        // 七、呼叫自訂非同步方法
        Console.WriteLine();
        Console.WriteLine("========== 自訂非同步方法 ==========");

        string message = await GetMessageAsync();
        Console.WriteLine(message);
    }

    // 非同步方法：等待 500 毫秒後回傳字串
    static async Task<string> GetMessageAsync()
    {
        await Task.Delay(500);
        return "非同步工作已完成";
    }
}

// Book 類別：定義書籍的資料結構
class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public double Price { get; set; }
}