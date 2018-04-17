
using Microsoft.EntityFrameworkCore;

namespace ToDoListVS.Models
{
    public class ToDoListContext : DbContext
    {
        public ToDoListContext()
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;Port=8889;database=todolist;uid=root;pwd=root;");
        
        public ToDoListContext(DbContextOptions<ToDoListContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}