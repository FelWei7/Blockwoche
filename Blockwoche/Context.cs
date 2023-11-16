using Microsoft.EntityFrameworkCore;

namespace Blockwoche
{
    public class BlockwocheContext : DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Blockwoche;Trusted_Connection=True;");
        }

        public DbSet<Schueler> Schueler { get; set; }
        public DbSet<Lehrer> Lehrer { get; set; }
        public DbSet<Buch> Buch { get; set; }
        public DbSet<SchuelerBuch> SchuelerBuch { get; set; }

    }

    
}

