using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace IFEN.CSharp.TestePratico.Data
{
    internal partial class IFENDbContext : DbContext
    {
        public IFENDbContext(IServiceProvider provider)
            : this(BuildOptions(provider))
        {
        }

        public IFENDbContext(DbContextOptions<IFENDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Model.ComsCargo> ComsCargo { get; set; }
        public virtual DbSet<Model.Produto> Produto { get; set; }
        public virtual DbSet<Model.Usuario> Usuario { get; set; }
        public virtual DbSet<Model.Venda> Venda { get; set; }

        private static DbContextOptions<IFENDbContext> BuildOptions(IServiceProvider provider)
        {
            var configuration = provider.GetService<IConfiguration>();
            var dbOptions = new DbContextOptionsBuilder<IFENDbContext>();

            dbOptions.UseSqlServer(configuration.GetConnectionString("DatabaseConnection"));

            return dbOptions.Options;
        }
    }
}
