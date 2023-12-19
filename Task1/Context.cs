using Microsoft.EntityFrameworkCore;
using Task1.Models;

namespace Task1
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-JBL34FI\\SQLEXPRESS;Initial Catalog=Task1_MVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False");
        }

        public DbSet<Department> departments { get; set; }
        public DbSet<Feedback> feedbacks { get; set; }
        public DbSet<Tasks> tasks { get; set; }
        public DbSet<Employee> employees { get; set; }
    }
}
