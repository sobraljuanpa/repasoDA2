using Microsoft.EntityFrameworkCore;

namespace ListsApi.Models
{
    public class ListsContext : DbContext
    {
        public ListsContext(DbContextOptions<ListsContext> options) : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Grocery> Groceries { get; set; }
    }
}