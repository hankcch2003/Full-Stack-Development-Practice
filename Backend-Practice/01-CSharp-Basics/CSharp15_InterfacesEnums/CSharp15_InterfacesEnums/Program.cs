using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("================================");
        Console.WriteLine("C# 程式設計練習");
        Console.WriteLine("第十五章：介面與列舉");
        Console.WriteLine("================================");

        // 一、使用 enum 表示書籍狀態。
        Console.WriteLine();
        Console.WriteLine("========== 書籍狀態 ==========");

        BookStatus status = BookStatus.Available;
        Console.WriteLine("目前狀態：" + status);

        status = BookStatus.Borrowed;
        Console.WriteLine("修改後狀態：" + status);
        Console.WriteLine("狀態數值：" + (int)status);

        // 二、使用 enum 搭配 switch 判斷狀態。
        Console.WriteLine();
        Console.WriteLine("========== 狀態說明 ==========");
        ShowStatus(status);
        ShowStatus(BookStatus.Reserved);
        ShowStatus(BookStatus.Available);

        // 三、定義介面型別的變數。
        // IBookService 規定實作類別必須提供指定的方法。

        IBookService service = new BookService();

        Console.WriteLine();
        Console.WriteLine("========== 圖書服務 ==========");
        service.AddBook("C# 入門教學");
        service.AddBook("Java 程式設計");
        service.ShowBooks();

        // 四、使用介面統一操作不同實作。
        INotification email = new EmailNotification();
        INotification message = new MessageNotification();

        Console.WriteLine();
        Console.WriteLine("========== 通知功能 ==========");
        email.Send("書籍已成功借出");
        message.Send("借閱期限即將到期");

        // 五、使用 List 儲存多筆書籍狀態。
        List<BookStatus> statuses = new List<BookStatus>
        {
            BookStatus.Available,
            BookStatus.Borrowed,
            BookStatus.Reserved
        };

        Console.WriteLine();
        Console.WriteLine("========== 狀態清單 ==========");
        foreach (BookStatus item in statuses)
        {
            Console.WriteLine(item);
        }
    }

    static void ShowStatus(BookStatus status)
    {
        switch (status)
        {
            case BookStatus.Available:
                Console.WriteLine("可借閱");
                break;

            case BookStatus.Borrowed:
                Console.WriteLine("已借出");
                break;

            case BookStatus.Reserved:
                Console.WriteLine("已預約");
                break;

            default:
                Console.WriteLine("未知狀態");
                break;
        }
    }
}

// enum 定義固定的命名選項。
// 預設數值從 0 開始：Available = 0、Borrowed = 1、Reserved = 2。

enum BookStatus
{
    Available,
    Borrowed,
    Reserved
}

// 介面只規定功能，不在這裡撰寫一般的實作內容。
interface IBookService
{
    void AddBook(string title);
    void ShowBooks();
}

// 類別透過實作介面，必須提供介面要求的方法。
class BookService : IBookService
{
    private List<string> books = new List<string>();

    public void AddBook(string title)
    {
        books.Add(title);
        Console.WriteLine("已新增書籍：" + title);
    }

    public void ShowBooks()
    {
        foreach (string title in books)
        {
            Console.WriteLine("書名：" + title);
        }
    }
}

interface INotification
{
    void Send(string message);
}

class EmailNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("電子郵件通知：" + message);
    }
}

class MessageNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine("簡訊通知：" + message);
    }
}