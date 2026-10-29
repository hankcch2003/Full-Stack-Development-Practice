using System.ComponentModel.DataAnnotations;

namespace BookManagement.Api.Models
{
    // 書籍資料模型：定義每本書需要儲存的資料
    public class Book
    {
        // 書籍編號
        public int Id { get; set; }

        // 書名：必填，且不可只輸入空白
        [Required(ErrorMessage = "書名不可空白")]
        public string Title { get; set; } = string.Empty;

        // 作者：必填
        [Required(ErrorMessage = "作者不可空白")]
        public string Author { get; set; } = string.Empty;

        // 書籍狀態，預設為可借閱
        public BookStatus Status { get; set; } = BookStatus.Available;
    }
}