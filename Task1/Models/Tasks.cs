using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Task1.Models
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime DueDate { get; set; }

        public string Description { get; set; }

        public int ImportanceLevel { get; set; }


        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } 
    }
}
