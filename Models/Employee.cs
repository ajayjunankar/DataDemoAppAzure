using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataDemoApp.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("Department")]

        public int DeptId { get; set; }
        public decimal Salary { get; set; }
        public bool IsActive { get; set; }
        public Department Department { get; set; }
    }
}
