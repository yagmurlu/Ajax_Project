using Microsoft.EntityFrameworkCore;

namespace Ajax_Project.DAL
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=YAGMUR\\SQLEXPRESS ; initial catalog= DbAjax; integrated security =true");
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
