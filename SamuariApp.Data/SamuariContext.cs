using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;

namespace SamuariApp.Data {
   public class SamuraiContext :DbContext{
      public DbSet<Samurai> Samurais { get; set; }
      public DbSet<Quote> Quotes { get; set; }

      protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer("Data Source = (localdb)\\ProjectsV13; Initial Catalog=SamuraiAppData" );
      }
   }
}
 