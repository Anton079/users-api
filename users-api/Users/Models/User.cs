using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace users_api.Users.Models
{
    [Table("user")]

    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("first_name")]
        public string first_name { get; set; }

        [Required]
        [Column("last_name")]
        public string last_name { get; set; }

        [Required]
        [Column("mail")]
        public string mail { get; set; }

        [Required]
        [Column("password")]
        public string password { get; set; }

        [Required]
        [Column("phone")]
        public int phone { get; set; }
    }
}
