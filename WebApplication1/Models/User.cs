using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("users")]
    public class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("first_name")]
        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Column("last_name")]
        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [Column("email")]
        [StringLength(100)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Column("password")]
        [StringLength(255)]
        public string Password { get; set; } = string.Empty;

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
