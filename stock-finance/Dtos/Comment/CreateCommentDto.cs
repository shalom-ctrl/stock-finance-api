using System.ComponentModel.DataAnnotations;

namespace stock_finance.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be at least 5 Characters")]
        [MaxLength(280, ErrorMessage = "Title cannot be over 280 Characters")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(5, ErrorMessage = "Content must be at least 5 Characters")]
        [MaxLength(500, ErrorMessage = "Content cannot be over 500 Characters")]
        public string Content { get; set; } = string.Empty;
    }
}
