using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace IFEN.CSharp.TestePratico.Data
{
    public interface IRepository<T> : IQueryable<T> where T : class
    {
        IDataContext DataContext { get; }

        T GetById(int key);
    }

    internal class Repository<T> : IRepository<T> where T : class
    {
        private DbSet<T> set;

        public Repository(DataContext dataContext)
        {
            this.DataContext = dataContext;
            this.set = dataContext.DBContext.Set<T>();
        }

        #region IQueryable
        
        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)set).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)set).GetEnumerator();
        }

        public Type ElementType
        {
            get { return ((IQueryable<T>)set).ElementType; }
        }

        public System.Linq.Expressions.Expression Expression
        {
            get { return ((IQueryable<T>)set).Expression; }
        }

        public IQueryProvider Provider
        {
            get { return ((IQueryable<T>)set).Provider; }
        }

        #endregion

        #region IRepository

        public IDataContext DataContext { get; private set; }

        public T GetById(int key)
        {
            return set.Find(key);
        }

        #endregion
    }
}
