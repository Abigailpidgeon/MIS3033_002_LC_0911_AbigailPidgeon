using a;
using Microsoft.EntityFrameworkCore;

namespace b
{
    public class StudentDB:DbContext
    {
        public DbSet<Student> StudentsTbl { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {

            optionsbuilder.UseSqlite("Data Source=Stu.db");
        }
    }
}
