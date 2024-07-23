using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YB_EbrarSimayIsa_RezervasyonApp.Entities.Abstractions;

namespace YB_EbrarSimayIsa_RezervasyonApp.Business.IService
{
    public interface IGenericService<T> where T: Entity, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAll();
        T GetById(string id);
        IQueryable<T> GetAllQueryable();
    }
}
