using System.Collections.Generic;

namespace disaster.business.Abstract
{
    public interface IService<T>
    {
         bool Create(T entity);
         bool Delete(T entity);
         bool Update(T entity);
         List<T> GetAll();
         T GetById(int id);
    }
}