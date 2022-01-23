using Microsoft.EntityFrameworkCore;


namespace DatabaseKontekst
{
    public class DatabaseCtx : DbContext
    {
        public DatabaseCtx(DbContextOptions o) : base(o){ }
        public DbSet<Kamer> kamers { get; set; }
    }
}
