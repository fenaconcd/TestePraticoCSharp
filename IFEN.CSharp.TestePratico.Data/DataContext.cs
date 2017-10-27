using System;
using System.Collections.Generic;

namespace IFEN.CSharp.TestePratico.Data
{
    internal partial class DataContext : IDataContext
    {
        private Dictionary<Type, object> repositories;

        public DataContext(IServiceProvider provider)
        {
            var dbContext = provider.GetService<IFENDbContext>();
            if (dbContext == null)
                throw new ArgumentException("Não foi possível resolver as dependências para instanciar o repositório.", "serviceProvider");

            this.DBContext = dbContext;
            this.repositories = new Dictionary<Type, object>();
        }

        public IFENDbContext DBContext { get; private set; }

        private IRepository<T> GetRepository<T>() where T : class
        {
            object repositoryObj;
            if (repositories.TryGetValue(typeof(T), out repositoryObj))
                return (IRepository<T>)repositoryObj;

            var repository = new Repository<T>(this);
            repositories.Add(typeof(T), repository);
            return repository;
        }

        public void Commit()
        {
            var db = DBContext;
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
