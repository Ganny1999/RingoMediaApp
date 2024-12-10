using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RingoMediaProject.DomainModel.Models
{
    public class Department
    {
        [Key]
        public int Dept_Id { get; set; }
        [Required]
        public string Dept_Name { get; set; }
        public int? Dept_Parent_Id { get; set; }
    }
}
