using Microsoft.EntityFrameworkCore;

namespace AutogermanaAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Transaccion> Transacciones => Set<Transaccion>();
    }
}
