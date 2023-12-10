using Microsoft.EntityFrameworkCore;

namespace lab10
{ 
    class ApplicationContext : DbContext
    {
        public DbSet<TicketPrice> TicketPrices { get; set; }
        public DbSet<TrainType> TrainTypes { get; set; }
        public ApplicationContext() : base()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=EntityTest;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
    
