using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]           //Xác định khóa chính
        [MaxLength(50)]
        public string ID { get; set; }

        [Required]      //Bát buộc phải nhập
        public string Content { get; set; }
    }
}