using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Abstractions;

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.Abstractions
{
    public interface IRepository<T> where T:Entity
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(Guid id);
        IEnumerable<T> GetAll();
        T? GetByID(Guid ID);
        public bool IfEntityExists(Expression<Func<T, bool>> filter);
    }
}
