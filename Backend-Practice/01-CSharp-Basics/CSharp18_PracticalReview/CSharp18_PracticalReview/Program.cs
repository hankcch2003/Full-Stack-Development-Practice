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
        Console.WriteLine("第十八章：實務整合複習");
        Console.WriteLine("================================");

        // 一、建立書籍管理服務
        IBookService service = new BookService();

        // 二、新增書籍
        Console.WriteLine();
        Console.WriteLine("========== 新增書籍 ==========");

        try
        {
            service.AddBook(new Book
            {
                Id = 1,
                Title = "C# 入門教學",
                Author = "王小明",
                Status = BookStatus.Available
            });

            service.AddBook(new Book
            {
                Id = 2,
                Title = "Java 程式設計",
                Author = "陳小華",
                Status = BookStatus.Borrowed
            });

            Console.WriteLine("新增書籍成功");

            // 測試重複編號的例外處理
            service.AddBook(new Book
            {
                Id = 1,
                Title = "重複編號的書",
                Author = "測試作者",
                Status = BookStatus.Available
            });
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("新增失敗：" + ex.Message);
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("新增失敗：" + ex.Message);
        }

        // 三、顯示所有書籍
        Console.WriteLine();
        Console.WriteLine("========== 書籍清單 ==========");

        service.ShowAllBooks();

        // 四、依編號查詢書籍
        Console.WriteLine();
        Console.WriteLine("========== 查詢書籍 ==========");

        try
        {
            Book foundBook = service.FindBookById(2);
            Console.WriteLine(foundBook);
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine("查詢失敗：" + ex.Message);
        }

        // 五、修改書名
        Console.WriteLine();
        Console.WriteLine("========== 修改書籍 ==========");

        try
        {
            service.UpdateBookTitle(1, "C# 進階教學");
            Console.WriteLine("書名修改成功");
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine("修改失敗：" + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("修改失敗：" + ex.Message);
        }

        // 六、刪除書籍
        Console.WriteLine();
        Console.WriteLine("========== 刪除書籍 ==========");

        bool removed = service.RemoveBook(2);

        Console.WriteLine(
            removed ? "書籍刪除成功" : "找不到要刪除的書籍"
        );

        // 七、再次顯示清單
        Console.WriteLine();
        Console.WriteLine("========== 修改後的書籍清單 ==========");

        service.ShowAllBooks();

        // 八、將書籍清單序列化成 JSON
        Console.WriteLine();
        Console.WriteLine("========== JSON 與非同步檔案操作 ==========");

        string filePath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "books-review.json"
        );

        try
        {
            string json = JsonSerializer.Serialize(
                service.GetAllBooks(),
                new JsonSerializerOptions
                {
                    WriteIndented = true
                }
            );

            await File.WriteAllTextAsync(filePath, json);
            Console.WriteLine("JSON 檔案寫入成功");

            // 九、讀取 JSON 並還原成書籍清單
            string loadedJson = await File.ReadAllTextAsync(filePath);

            List<Book>? loadedBooks =
                JsonSerializer.Deserialize<List<Book>>(loadedJson);

            if (loadedBooks != null)
            {
                Console.WriteLine("JSON 檔案讀取成功");
                Console.WriteLine("還原的書籍數量：" + loadedBooks.Count);

                foreach (Book book in loadedBooks)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("JSON 內容無法還原成書籍清單");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("檔案操作失敗：" + ex.Message);
        }
        catch (JsonException ex)
        {
            Console.WriteLine("JSON 處理失敗：" + ex.Message);
        }

        Console.WriteLine();
        Console.WriteLine("========== 程式執行完成 ==========");
    }
}

// 書籍狀態
enum BookStatus
{
    Available,
    Borrowed
}

// 書籍資料類別
class Book
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Author { get; set; } = "";
    public BookStatus Status { get; set; }

    public override string ToString()
    {
        return "編號：" + Id
            + "，書名：" + Title
            + "，作者：" + Author
            + "，狀態：" + Status;
    }
}

// 書籍管理介面
interface IBookService
{
    void AddBook(Book book);
    void ShowAllBooks();
    Book FindBookById(int id);
    void UpdateBookTitle(int id, string newTitle);
    bool RemoveBook(int id);
    List<Book> GetAllBooks();
}

// 實作書籍管理功能
class BookService : IBookService
{
    private readonly List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        if (string.IsNullOrWhiteSpace(book.Title))
        {
            throw new ArgumentException("書名不可空白");
        }

        if (books.Exists(item => item.Id == book.Id))
        {
            throw new InvalidOperationException("書籍編號不可重複");
        }

        books.Add(book);
    }

    public void ShowAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("目前沒有書籍");
            return;
        }

        foreach (Book book in books)
        {
            Console.WriteLine(book);
        }
    }

    public Book FindBookById(int id)
    {
        Book? book = books.Find(item => item.Id == id);

        if (book == null)
        {
            throw new KeyNotFoundException("找不到編號 " + id);
        }

        return book;
    }

    public void UpdateBookTitle(int id, string newTitle)
    {
        if (string.IsNullOrWhiteSpace(newTitle))
        {
            throw new ArgumentException("新書名不可空白");
        }

        Book book = FindBookById(id);
        book.Title = newTitle;
    }

    public bool RemoveBook(int id)
    {
        Book? book = books.Find(item => item.Id == id);

        if (book == null)
        {
            return false;
        }

        return books.Remove(book);
    }

    public List<Book> GetAllBooks()
    {
        return books;
    }
}