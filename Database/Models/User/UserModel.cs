using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models.User
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        [Column("username",TypeName = "varchar(25)")]
        public string Username { get; set; }
        

        [Required]
        [MaxLength(255)]
        [Column("email", TypeName = "varchar(255)")]
        public string Email { get; set; }

        [Required]
        [MaxLength(45)]
        [Column("password", TypeName = "varchar(45)")]
        public string Password { get; set; }

        [Required]
        [Column("created_at", TypeName = "DATE")]
        public DateTime CreatedAt { get; set; }

        [Required]
        [Column("last_login", TypeName = "DATE")]
        public DateTime LastLogin { get; set; }
    }
}
