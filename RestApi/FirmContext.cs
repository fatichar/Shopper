
using Microsoft.EntityFrameworkCore;

namespace Shopper.Core
{
    public class FirmContext : DbContext
    {
        internal const string ServiceEndPoint = "https://localhost:8081";
        internal const string AuthKey = "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==";
        internal const string DatabaseName = "MyDb";
        public DbSet<Model.Firm> Firms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseCosmos(
                ServiceEndPoint,
                AuthKey,
                DatabaseName
            );
        }
    }
}