using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VuVanDoan_231230746_de01.Models
{
    // Tên bảng "HvtComputer" này phải khớp với tên bảng bạn tạo trong SQL Server
    // (Theo đề bài gốc của bạn là HvtComputer)
    [Table("vvdComputer")]
    public class VvdComputer // Tên lớp này khớp với DbSet trong Context
    {
        [Key] // Đánh dấu đây là khóa chính
        public int vvdComId { get; set; }

        [DisplayName("Tên máy tính")]
        [Required(ErrorMessage = "Tên máy không được để trống")]
        public string vvdComName { get; set; }

        [DisplayName("Giá")]
        [Required(ErrorMessage = "Giá không được để trống")]
        public decimal? vvdComPrice { get; set; } // Dùng decimal cho tiền tệ

        [DisplayName("Hình ảnh")]
        public string? vvdComImage { get; set; } // Dấu ? cho phép null

        [DisplayName("Trạng thái")]
        public bool? vvdComStatus { get; set; } // Dấu ? cho phép null
    }
}