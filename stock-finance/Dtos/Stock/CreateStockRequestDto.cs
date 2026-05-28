using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace stock_finance.Dtos.Stock
{
    public class CreateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 Characters")]
        public string Symbol { get; set; } = string.Empty;
        [Required]
        [MaxLength(30, ErrorMessage = "Company Name cannot be over 30 Characters")]
        public string CompanyName { get; set; } = string.Empty;
        [Required]
        [Range(1,10000000000)]
        public decimal Purchase { get; set; }
        [Required]
        [Range(0.001,1000)]
        public decimal LastDiv { get; set; }
        [Required]
        [MaxLength(20, ErrorMessage = "Industry cannot be over 20 Characters")]
        public string Industry { get; set; } = string.Empty;
        [Range(1,50000000000)]
        public long MarketCap { get; set; }
    }
}
