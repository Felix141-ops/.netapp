using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int IdNum { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int DepId { get; set; }
    }
}
