using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class Department
    {

        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
