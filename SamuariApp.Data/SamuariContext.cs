using Microsoft.EntityFrameworkCore;
using SamuraiApp.Domain;

namespace SamuariApp.Data {
   public class SamuariContext :DbContext{
      public DbSet<Samurai> Samuaris { get; set; }
      public DbSet<Quote> Quotes { get; set; }

      protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSQLLocalDB; Initial Catalog=SamuraiAppData" );
      }
   }
}
