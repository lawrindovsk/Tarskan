using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Models.Project
{
    public class ProjectModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(45)]
        [Column("project_name", TypeName = "varchar(45)")]
        public string ProjectName { get; set; }

        [Required]
        [Column("created_at", TypeName = "DATE")]
        public DateTime DateStart { get; set; }
        [Required]
        [Column("created_done", TypeName = "DATE")]
        public DateTime DateDone { get; set; }
    }
}
