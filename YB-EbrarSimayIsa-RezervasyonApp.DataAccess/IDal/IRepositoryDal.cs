using System.Linq.Expressions;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Abstractions;

namespace YB_EbrarSimayIsa_RezervasyonApp.DataAccess.IDal
{
    public interface IRepositoryDal<T> where T : Entity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        IQueryable<T> GetAllQueryable(Expression<Func<T, bool>> filter = null);
    }
    
    
}