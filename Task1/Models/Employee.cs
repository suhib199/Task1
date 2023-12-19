using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Task1.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public DateTime Birthdate { get; set; }

        public string PhoneNumber { get; set; }

        public string NationalId { get; set; }

        public string Nationality { get; set; }
   
        public string MaritalStatus { get; set; }
        public string PersonalPhoto { get; set; }

        public DateTime EntryDate { get; set; }
        public string Password { get; set; }

        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }

        public ICollection<Tasks> Tasks { get; set; }

    }
}
