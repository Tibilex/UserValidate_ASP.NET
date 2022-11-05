using System.ComponentModel.DataAnnotations;

namespace UserValidate_ASP.NET.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(11)]
        [MaxLength(int.MaxValue)]
        public string? Email { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(int.MaxValue)]
        public string? Password { get; set; }
    }
}
