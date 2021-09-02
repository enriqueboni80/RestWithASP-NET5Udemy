using System.Collections.Generic;
using RestWithAPSNETUdemy.Model;
using RestWithAPSNETUdemy.Model.Base;

namespace RestWithAPSNETUdemy.Repository.Implementations
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindByID(long id);
        List<T> FindAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}
