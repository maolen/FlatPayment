using Microsoft.EntityFrameworkCore;

namespace FlatPayment
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.EnsureCreated();
        }
        public DbSet<Fee> Fees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-NVDGPN3;Database=PaymentDb;Trusted_Connection=True;");
        }
    }
}
